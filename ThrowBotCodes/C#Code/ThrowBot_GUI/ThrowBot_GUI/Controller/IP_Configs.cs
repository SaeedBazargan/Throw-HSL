using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThrowBot_GUI.Controller
{
    public class IP_Configs : ControllerBase
    {
        public void DisplayServerIP(Label label, int port)
        {
            string serverIP = GetLocalIPAddress();
            string text = (serverIP == "0" ? "IP not found." : $"{serverIP}:{port}");
            ChangeLabel(label, text);
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
    }
}

