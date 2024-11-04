using OpenCvSharp.Extensions;
using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThrowBot_GUI.Controller
{
    public class DataController : ControllerBase
    {
        private CancellationTokenSource _cancellationTokenSource;

        public void Initialize(TcpClient client, PictureBox main_pictureBox, Panel serverStatus_panel)
        {
            _ = Task.Run(() => Start(client, main_pictureBox, serverStatus_panel));
        }

        private async Task Start(TcpClient client, PictureBox main_pictureBox, Panel serverStatus_panel)
        {
            using (client)
            {
                _cancellationTokenSource = new CancellationTokenSource();

                var stream = client.GetStream();

                try
                {
                    while (!_cancellationTokenSource.Token.IsCancellationRequested)
                    {
                        // Read frame size
                        byte[] sizeBuffer = new byte[4];
                        int bytesRead = await stream.ReadAsync(sizeBuffer, 0, sizeBuffer.Length);
                        if (bytesRead == 0) 
                            break;

                        int frameSize = BitConverter.ToInt32(sizeBuffer, 0);
                        byte[] frameBuffer = new byte[frameSize];

                        // Read frame data
                        int totalBytesRead = 0;
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
                                main_pictureBox.Invoke(new Action(() => main_pictureBox.Image = bitmap));
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error in receiving frames: {ex.Message}");
                }
            }

        }
    }
}
