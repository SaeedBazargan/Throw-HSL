using OpenCvSharp.Extensions;
using OpenCvSharp;
using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThrowBot_GUI.Controller
{
    public class CameraConfig : ControllerBase
    {
        private string _serverIP;
        private readonly int _cameraPort;
        private TcpListener _cameraListener;
        private TcpClient _cameraClient;
        private Task _cameraListenerTask;
        private Task _cameraStreamTask;
        private TcpClient _connectedClient;
        private readonly PictureBox _mainPictureBox;
        private readonly CancellationTokenSource _cancellationTokenSource;

        public CameraConfig(PictureBox mainPictureBox, int cameraPort, string serverIP, CancellationTokenSource cancellationTokenSource)
        {
            _serverIP = serverIP;
            _cameraPort = cameraPort;
            _mainPictureBox = mainPictureBox;
            _cancellationTokenSource = cancellationTokenSource;
        }

        public void Start()
        {
            try
            {
                _cameraListener = new TcpListener(IPAddress.Parse(_serverIP), _cameraPort);
                _cameraListener.Start();
                _cameraListenerTask = Task.Factory.StartNew(() => CameraCapture(_cameraListener), _cancellationTokenSource.Token);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error starting camera listener: {ex.Message}");
            }
        }

        private async Task CameraCapture(TcpListener cameraListener)
        {
            try
            {
                while (!_cancellationTokenSource.Token.IsCancellationRequested)
                {
                    Console.WriteLine("Waiting for a client to connect...");
                    _connectedClient = await cameraListener.AcceptTcpClientAsync();

                    try
                    {
                        if (_connectedClient != null && _connectedClient.Connected)
                        {
                            var stream = _connectedClient.GetStream();
                            byte[] sizeBuffer = new byte[4];  // Buffer to store frame size

                            while (!_cancellationTokenSource.Token.IsCancellationRequested)
                            {
                                // Read the frame size first
                                int bytesRead = await stream.ReadAsync(sizeBuffer, 0, sizeBuffer.Length);
                                if (bytesRead == 0)
                                    break;

                                int frameSize = BitConverter.ToInt32(sizeBuffer, 0);  // Convert the size to integer
                                byte[] frameBuffer = new byte[frameSize];
                                int totalBytesRead = 0;

                                // Read the actual frame data based on the size
                                while (totalBytesRead < frameSize)
                                {
                                    int read = await stream.ReadAsync(frameBuffer, totalBytesRead, frameSize - totalBytesRead);
                                    if (read == 0)
                                        break;
                                    totalBytesRead += read;
                                }

                                if (totalBytesRead == frameSize)
                                {
                                    Mat frame = Cv2.ImDecode(frameBuffer, ImreadModes.Color);

                                    if (frame != null && !frame.Empty())
                                    {
                                        Bitmap bitmap = BitmapConverter.ToBitmap(frame);
                                        ChangePictureBox(_mainPictureBox, bitmap);  // Update PictureBox with the new frame
                                    }
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Server operation canceled. Reason: {ex.Message}");
            }
        }
    }
}
