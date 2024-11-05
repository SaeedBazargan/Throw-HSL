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
using ThrowBot_GUI.Controller;
using System.Threading;


namespace ThrowBot_GUI
{
    public partial class MainForm : Form
    {
        private readonly CancellationTokenSource cancellationTokenSource;


        //private readonly int serverPort = 8000;
        //private readonly IP_Configs ip_Configs;

        //private readonly JoystickController joystick;

        //private readonly DataController dataController;

        public MainForm()
        {
            InitializeComponent();

            cancellationTokenSource = new CancellationTokenSource();

            //dataController = new DataController();

            //ip_Configs = new IP_Configs(serverPort, ServerStatus_panel, Main_pictureBox);
            //ip_Configs.DisplayServerIP(ServerIPandPort_label);
            //ip_Configs.StartTcpServer();

            //joystick = new JoystickController();
            //joystick.Initialize();
            //joystick.Start();
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
    }
}

