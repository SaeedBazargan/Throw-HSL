using System;
using System.Drawing;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp;
using OpenCvSharp.Extensions;

namespace ThrowBot_GUI.Controller
{
    public class CameraController : ControllerBase
    {
        private TcpClient _client;
        private PictureBox _pictureBox;

        public CameraController(TcpClient client, PictureBox pictureBox)
        {
            _client = client ?? throw new ArgumentNullException(nameof(client), "TCP Client cannot be null.");
            _pictureBox = pictureBox ?? throw new ArgumentNullException(nameof(pictureBox), "PictureBox cannot be null.");
        }

        public async Task StartReceivingFrames()
        {
            if (_client == null)
            {
                throw new InvalidOperationException("TCP Client is not set.");
            }

            using (var stream = _client.GetStream())
            {
                try
                {
                    while (true)
                    {
                        byte[] sizeBuffer = new byte[4];
                        int bytesRead = await stream.ReadAsync(sizeBuffer, 0, sizeBuffer.Length);
                        if (bytesRead == 0) break; // Connection closed by client

                        int frameSize = BitConverter.ToInt32(sizeBuffer, 0);
                        byte[] frameBuffer = new byte[frameSize];

                        int totalBytesRead = 0;
                        while (totalBytesRead < frameSize)
                        {
                            int read = await stream.ReadAsync(frameBuffer, totalBytesRead, frameSize - totalBytesRead);
                            if (read == 0) break; // Connection closed by client
                            totalBytesRead += read;
                        }

                        if (totalBytesRead == frameSize)
                        {
                            DisplayFrame(frameBuffer);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error in receiving frames: {ex.Message}");
                }
            }
        }

        public void DisplayFrame(byte[] frameBuffer)
        {
            Mat frame = Cv2.ImDecode(frameBuffer, ImreadModes.Color);
            if (frame != null && !frame.Empty())
            {
                Bitmap bitmap = BitmapConverter.ToBitmap(frame);
                _pictureBox.Invoke(new Action(() => _pictureBox.Image = bitmap));
            }
        }
    }
}
