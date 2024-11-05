using System;
using System.Threading;
using System.Windows.Forms;

namespace ThrowBot_GUI.Controller
{
    public class ServerConfig : ControllerBase
    {
        private readonly int _cameraPort;
        private readonly int _messagePort;
        private readonly Label _serverIP_label;
        private readonly Label _serverPort_label;
        private readonly Panel _serverStatus_panel;

        private readonly CancellationTokenSource _cancellationTokenSource;

        public ServerConfig(int cameraPort, int messagePort, Label serverIP_label, Label serverPort_label, Panel serverStatus_panel, CancellationTokenSource cancellationTokenSource)
        {
            _cameraPort = cameraPort;
            _messagePort = messagePort;
            _serverIP_label = serverIP_label;
            _serverPort_label = serverPort_label;
            _serverStatus_panel = serverStatus_panel;
            _cancellationTokenSource = cancellationTokenSource;
        }
    }
}
