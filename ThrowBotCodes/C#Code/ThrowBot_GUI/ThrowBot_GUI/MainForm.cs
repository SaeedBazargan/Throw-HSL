using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;


namespace ThrowBot_GUI
{
    public partial class MainForm : Form
    {
        private readonly int serverPort = 8000;

        public MainForm()
        {
            InitializeComponent();

            DisplayServerIP();
        }

        private void Exit_pictureBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Config_pictureBox_Click(object sender, EventArgs e)
        {
            ConfigForm configForm = new ConfigForm();
            configForm.ShowDialog(this);
        }







        private void DisplayServerIP()
        {
            string serverIP = GetLocalIPAddress();
            if(serverIP == "0")
                ServerIPandPort_label.Text = "  IP not found.";
            ServerIPandPort_label.Text = $"{serverIP}:{serverPort}";
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
