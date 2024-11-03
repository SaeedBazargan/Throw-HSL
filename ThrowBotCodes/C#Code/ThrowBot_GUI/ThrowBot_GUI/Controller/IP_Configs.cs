using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp;
using OpenCvSharp.Extensions;

namespace ThrowBot_GUI.Controller
{
    public class IP_Configs : ControllerBase
    {
        private TcpListener _listener;
        string serverIP;

        private CancellationTokenSource _cancellationTokenSource;


        public void DisplayServerIP(Label serverIP_Port_label, int port)
        {
            serverIP = GetLocalIPAddress();
            string text = (serverIP == "0" ? "IP not found." : $"{serverIP}:{port}");
            ChangeLabel(serverIP_Port_label, text);
        }

        private string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            return "0";
        }

        public async void StartTcpServer(int port, Panel serverStatus_panel, PictureBox main_pictureBox)
        {
            _listener = new TcpListener(IPAddress.Parse(serverIP), port);
            _listener.Start();

            _cancellationTokenSource = new CancellationTokenSource();
            try
            {
                while (!_cancellationTokenSource.Token.IsCancellationRequested)
                {
                    var client = await _listener.AcceptTcpClientAsync();
                    _ = Task.Run(() => HandleClient(client, serverStatus_panel, main_pictureBox));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                ChangePanel(serverStatus_panel, "Red");                 // Red for Disconnect
            }
            finally
            {
                StopTcpServer();
                ChangePanel(serverStatus_panel, "Red");                 // Red for Disconnect
            }
        }

        private async Task HandleClient(TcpClient client, Panel serverStatus_panel, PictureBox main_pictureBox)
        {
            using (client)
            {
                var stream = client.GetStream();
                ChangePanel(serverStatus_panel, "Green");  // Green for Connect

                try
                {
                    while (!_cancellationTokenSource.Token.IsCancellationRequested)
                    {
                        // Read frame size
                        byte[] sizeBuffer = new byte[4];
                        int bytesRead = await stream.ReadAsync(sizeBuffer, 0, sizeBuffer.Length);
                        if (bytesRead == 0) break;

                        int frameSize = BitConverter.ToInt32(sizeBuffer, 0);
                        byte[] frameBuffer = new byte[frameSize];

                        // Read frame data
                        int totalBytesRead = 0;
                        while (totalBytesRead < frameSize)
                        {
                            int read = await stream.ReadAsync(frameBuffer, totalBytesRead, frameSize - totalBytesRead);
                            if (read == 0) break;
                            totalBytesRead += read;
                        }

                        // Decode and display the frame
                        if (totalBytesRead == frameSize)
                        {
                            // Decode the frame using OpenCvSharp
                            Mat frame = Cv2.ImDecode(frameBuffer, ImreadModes.Color);

                            if (frame != null && !frame.Empty())
                            {
                                // Convert Mat to Bitmap for displaying in PictureBox
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
                finally
                {
                    ChangePanel(serverStatus_panel, "Red");  // Red for Disconnect
                }
            }
        }

        public void StopTcpServer()
        {
            _cancellationTokenSource?.Cancel();
            _listener?.Stop();
        }
    }
}
