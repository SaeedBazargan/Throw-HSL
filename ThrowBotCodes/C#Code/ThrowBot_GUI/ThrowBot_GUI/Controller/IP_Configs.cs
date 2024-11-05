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

        private int portNumber;
        private Panel _serverStatus_panel;
        private PictureBox _main_pictureBox;

        private CancellationTokenSource _cancellationTokenSource;

        public IP_Configs(int port, Panel serverStatus_panel, PictureBox main_pictureBox)
        {
            portNumber = port;
            _serverStatus_panel = serverStatus_panel;
            _main_pictureBox = main_pictureBox;
        }

        public void DisplayServerIP(Label serverIP_Port_label)
        {
            serverIP = GetLocalIPAddress();
            string text = (serverIP == "0" ? "IP not found." : $"{serverIP}:{portNumber}");
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

        public async void StartTcpServer()
        {
            _listener = new TcpListener(IPAddress.Parse(serverIP), portNumber);
            _listener.Start();

            _cancellationTokenSource = new CancellationTokenSource();
            try
            {
                while (!_cancellationTokenSource.Token.IsCancellationRequested)
                {
                    var client = await _listener.AcceptTcpClientAsync();
                    if (client != null)
                    {
                        DataController dataController = new DataController();
                        await dataController.Initialize(client, _main_pictureBox, _serverStatus_panel);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                ChangePanel(_serverStatus_panel, "Red"); // Red for Disconnect
            }
            finally
            {
                StopTcpServer();
                ChangePanel(_serverStatus_panel, "Red"); // Red for Disconnect
            }
        }


        public void StopTcpServer()
        {
            _cancellationTokenSource?.Cancel();
            _listener?.Stop();
        }
    }
}
