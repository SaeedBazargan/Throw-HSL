using System;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public async void StartTcpServer(int port, Panel serverStatus_panel)
        {
            _listener = new TcpListener(IPAddress.Parse(serverIP), port);
            _listener.Start();

            _cancellationTokenSource = new CancellationTokenSource();
            try
            {
                while (!_cancellationTokenSource.Token.IsCancellationRequested)
                {
                    var client = await _listener.AcceptTcpClientAsync();
                    _ = Task.Run(() => HandleClientAsync(client, serverStatus_panel));
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

        private async Task HandleClientAsync(TcpClient client, Panel serverStatus_panel)
        {
            using (client)
            {
                var buffer = new byte[1024];
                var stream = client.GetStream();

                var responseMessage = "MRL?";
                var responseData = Encoding.UTF8.GetBytes(responseMessage);
                await stream.WriteAsync(responseData, 0, responseData.Length);

                int bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);
                var message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                if (message == "HSL!")
                {
                    ChangePanel(serverStatus_panel, "Green");           // Green for Connect
                }
            }
        }

        // Call this method to stop the server when needed
        public void StopTcpServer()
        {
            _cancellationTokenSource?.Cancel();
            _listener?.Stop();
        }
    }
}
