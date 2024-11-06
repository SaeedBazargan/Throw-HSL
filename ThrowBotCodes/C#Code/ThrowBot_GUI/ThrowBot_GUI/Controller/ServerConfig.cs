using System;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Text;

namespace ThrowBot_GUI.Controller
{
    public class ServerConfig : ControllerBase
    {
        private string _serverIP;
        private readonly int _cameraPort;
        private readonly int _messagePort;
        private TcpClient _connectedClient;
        private Task _checkConnectivityTask;
        private TcpListener _messageListener;
        private readonly Label _serverIPLabel;
        private readonly Label _serverPortLabel;
        private readonly Panel _serverStatusPanel;
        private CancellationTokenSource _cancellationTokenSource;

        public ServerConfig(int messagePort, int cameraPort, Label serverIPLabel, Label serverPortLabel, Panel serverStatusPanel, CancellationTokenSource cancellationTokenSource)
        {
            _cameraPort = cameraPort;
            _messagePort = messagePort;
            _serverIPLabel = serverIPLabel;
            _serverPortLabel = serverPortLabel;
            _serverStatusPanel = serverStatusPanel;
            _cancellationTokenSource = cancellationTokenSource;
        }

        public string DisplayServerIP_Port()
        {
            _serverIP = GetLocalIPAddress();

            string IPText = (_serverIP == "0" ? "IP not found." : $"{_serverIP}");
            string PortText = ($"{_cameraPort}:{_messagePort}");
            ChangeLabel(_serverIPLabel, IPText);
            ChangeLabel(_serverPortLabel, PortText);

            return _serverIP;
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

        public void Start()
        {
            try
            {
                _messageListener = new TcpListener(IPAddress.Parse(_serverIP), _messagePort);
                _messageListener.Start();
                _checkConnectivityTask = Task.Factory.StartNew(() => CheckConnectivity(_messageListener), _cancellationTokenSource.Token);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error starting server: {ex.Message}");
            }
        }

        private async Task CheckConnectivity(TcpListener messageListener)
        {
            try
            {
                while (!_cancellationTokenSource.Token.IsCancellationRequested)
                {
                    Console.WriteLine("Waiting for a client to connect...");
                    _connectedClient = await messageListener.AcceptTcpClientAsync();

                    if (_connectedClient != null && _connectedClient.Connected)
                    {
                        var responseMessage = "MRL?";
                        while (_connectedClient.Connected && !_cancellationTokenSource.Token.IsCancellationRequested)
                        {
                            var message = SendMessage(responseMessage);

                            if (message == "HSL!")
                            {
                                Console.WriteLine("Handshake successful.");
                                ChangePanel(_serverStatusPanel, "Green"); // Green for Connect
                            }
                            else
                            {
                                Console.WriteLine("Handshake failed.");
                                ChangePanel(_serverStatusPanel, "Red"); // Red for Disconnect
                            }

                            await Task.Delay(2000, _cancellationTokenSource.Token);
                        }
                    }
                    else
                    {
                        ChangePanel(_serverStatusPanel, "Red"); // Red for Disconnect
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Server operation canceled.");
                ChangePanel(_serverStatusPanel, "Red"); // Red for Disconnect
            }
            //finally
            //{
            //    messageListener.Stop();
            //}
        }

        public string SendMessage(string message)
        {
            try
            {
                if (_connectedClient != null && _connectedClient.Connected)
                {
                    var stream = _connectedClient.GetStream();

                    byte[] data = Encoding.UTF8.GetBytes(message);
                    stream.Write(data, 0, data.Length);
                    Console.WriteLine($"Sent: {message}");

                    // Wait for a response from the client
                    byte[] buffer = new byte[1024];
                    int bytesRead = stream.Read(buffer, 0, buffer.Length);
                    string response = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                    Console.WriteLine($"Received: {response}");

                    return response;
                }
                else
                {
                    Console.WriteLine("No client is connected to send the message.");
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error sending message: {ex.Message}");
                return null;
            }
        }
    }
}
