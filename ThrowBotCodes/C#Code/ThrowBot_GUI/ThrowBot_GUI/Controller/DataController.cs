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
using SharpDX.DirectInput;

namespace ThrowBot_GUI.Controller
{
    public class DataController : ControllerBase
    {
        private CancellationTokenSource _cancellationTokenSource;
        private TcpClient _client;

        public async Task Initialize(TcpClient client, PictureBox main_pictureBox, Panel serverStatus_panel)
        {
            _cancellationTokenSource = new CancellationTokenSource();
            _client = client;
            await CheckConnectivity(client, main_pictureBox, serverStatus_panel, _cancellationTokenSource.Token);
        }

        private async Task CheckConnectivity(TcpClient client, PictureBox main_pictureBox, Panel serverStatus_panel, CancellationToken token)
        {
            var mainPictureBox_mainBitmap = new Bitmap("D:\\sbzrgn\\سمینار\\Seminar\\Papers\\MyPapers\\ThrowBot\\Fig_First.png");

            while (!_cancellationTokenSource.Token.IsCancellationRequested)
            {
                try
                {
                    if (_client.Connected)
                    {
                        var responseMessage = await SendMessageAsync("MRL?");
                        Console.WriteLine(responseMessage);
                        if (responseMessage == "HSL!")
                        {
                            ChangePanel(serverStatus_panel, "Green"); // Green for Connect
                            await StartCamera(client, main_pictureBox, serverStatus_panel);
                        }
                        else
                        {
                            ChangePanel(serverStatus_panel, "Red"); // Red for Disconnect
                            ChangePictureBox(main_pictureBox, mainPictureBox_mainBitmap);
                        }
                    }
                    else
                    {
                        ChangePanel(serverStatus_panel, "Red"); // Red for Disconnect
                        ChangePictureBox(main_pictureBox, mainPictureBox_mainBitmap);
                    }

                    await Task.Delay(2000, _cancellationTokenSource.Token);
                }
                catch (Exception ex)
                {
                    ChangePanel(serverStatus_panel, "Red"); // Red for Disconnect
                    ChangePictureBox(main_pictureBox, mainPictureBox_mainBitmap);
                }
            }
        }

        public async Task<string> SendMessageAsync(string message)
        {
            var buffer = new byte[1024];
            var responseData = Encoding.UTF8.GetBytes(message);

            try
            {
                var stream = _client.GetStream();
                await stream.WriteAsync(responseData, 0, responseData.Length, _cancellationTokenSource.Token);

                int bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length, _cancellationTokenSource.Token);
                return Encoding.UTF8.GetString(buffer, 0, bytesRead);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error sending message: {ex.Message}");
                return null;
            }
        }

        private async Task StartCamera(TcpClient client, PictureBox main_pictureBox, Panel serverStatus_panel)
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
                                ChangePictureBox(main_pictureBox, bitmap);
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

        public async Task StartJoystick(JoystickState joystickState)
        {
            //joystickState.Buttons[0]    Button_1
            //joystickState.Buttons[1]    Button_2
            //joystickState.Buttons[2]    Button_3
            //joystickState.Buttons[3]    Button_4

            //joystickState.X     Left-Shock -> X
            //joystickState.Y     Left-Shock -> Y

            if (joystickState.Buttons[0])
            {
            }
            else if (joystickState.Buttons[9])               // Start Button
            {
                Application.Exit();
            }

        }
    }
}
