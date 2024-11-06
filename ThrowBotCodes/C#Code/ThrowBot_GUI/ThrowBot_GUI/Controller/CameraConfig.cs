using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Sockets;
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
        private readonly PictureBox _mainPictureBox;
        private readonly CancellationTokenSource _cancellationTokenSource;

        public CameraConfig(PictureBox mainPictureBox, int cameraPort, string serverIP, CancellationTokenSource cancellationTokenSource)
        {
            _mainPictureBox = mainPictureBox;
            _cameraPort = cameraPort;
            _serverIP = serverIP;
            _cancellationTokenSource = cancellationTokenSource;
        }

        public void Start()
        {
            try
            {
                _cameraListener = new TcpListener(IPAddress.Parse(_serverIP), _cameraPort);
                _cameraListener.Start();
                _cameraListenerTask = Task.Factory.StartNew(() => ListenForCameraClients(), _cancellationTokenSource.Token);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error starting camera listener: {ex.Message}");
            }
        }

        private async Task ListenForCameraClients()
        {
            try
            {
                while (!_cancellationTokenSource.Token.IsCancellationRequested)
                {
                    Console.WriteLine("Waiting for camera client to connect...");
                    _cameraClient = await _cameraListener.AcceptTcpClientAsync();

                    if (_cameraClient != null && _cameraClient.Connected)
                    {
                        Console.WriteLine("Camera client connected.");
                        // Start the camera stream task
                        _cameraStreamTask = Task.Factory.StartNew(() => StreamCameraImages(_cameraClient), _cancellationTokenSource.Token);
                    }
                    else
                    {
                        Console.WriteLine("Failed to connect to camera client.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while listening for camera clients: {ex.Message}");
            }
        }

        private async Task StreamCameraImages(TcpClient cameraClient)
        {
            try
            {
                var stream = cameraClient.GetStream();
                while (!_cancellationTokenSource.Token.IsCancellationRequested)
                {
                    // Read the incoming image byte data from the client stream
                    byte[] buffer = new byte[1024 * 1024]; // Buffer size (adjust as needed)
                    int bytesRead;
                    using (MemoryStream ms = new MemoryStream())
                    {
                        while ((bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length)) > 0)
                        {
                            ms.Write(buffer, 0, bytesRead);
                        }

                        // Convert the byte array to a Bitmap
                        Bitmap bitmap = new Bitmap(ms);

                        // Display the Bitmap in the PictureBox
                        _mainPictureBox.Invoke(new Action(() =>
                        {
                            _mainPictureBox.Image = bitmap;
                        }));
                    }

                    // Adjust this delay as necessary to control frame rate
                    await Task.Delay(100, _cancellationTokenSource.Token); // 100ms delay between frames
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error streaming camera images: {ex.Message}");
            }
            finally
            {
                cameraClient.Close();
                Console.WriteLine("Camera client disconnected.");
            }
        }

        public void Stop()
        {
            _cameraListener?.Stop();
        }
    }
}
