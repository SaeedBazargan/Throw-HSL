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
                    if (client != null)
                    {
                        ChangePanel(serverStatus_panel, "Green"); // Green for Connect

                        DataController dataController = new DataController();
                        await dataController.Initialize(client, main_pictureBox, serverStatus_panel);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                ChangePanel(serverStatus_panel, "Red"); // Red for Disconnect
            }
            finally
            {
                StopTcpServer();
                ChangePanel(serverStatus_panel, "Red"); // Red for Disconnect
            }
        }


        public void StopTcpServer()
        {
            _cancellationTokenSource?.Cancel();
            _listener?.Stop();
        }
    }
}
