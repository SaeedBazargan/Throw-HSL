using System;
using System.Windows.Forms;
using ThrowBot_GUI.Controller;
using System.Threading;

namespace ThrowBot_GUI
{
    public partial class MainForm : Form
    {
        private readonly CancellationTokenSource cancellationTokenSource;
        
        private readonly int cameraPort = 8000;
        private readonly int messagePort = 1234;
        private readonly ServerConfig server_Configs;

        public MainForm()
        {
            InitializeComponent();

            cancellationTokenSource = new CancellationTokenSource();
            
            server_Configs = new ServerConfig(cameraPort, messagePort, ServerIP_label, ServerPort_label, ServerStatus_panel, cancellationTokenSource);
            server_Configs.DisplayServerIP_Port();
            server_Configs.Start();
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
