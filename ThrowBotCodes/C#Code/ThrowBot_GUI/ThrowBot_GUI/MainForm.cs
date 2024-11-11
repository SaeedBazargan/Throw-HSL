using System;
using System.Windows.Forms;
using ThrowBot_GUI.Controller;
using System.Threading;

namespace ThrowBot_GUI
{
    public partial class MainForm : Form
    {
        private readonly CancellationTokenSource cancellationTokenSource;

        private string serverIP;
        private readonly int cameraPort = 8000;
        private readonly int messagePort = 1234;
        private readonly ServerConfig server_Configs;

        private readonly JoystickConfig joystick_Configs;

        private readonly CameraConfig camera_Configs;

        public MainForm()
        {
            InitializeComponent();

            cancellationTokenSource = new CancellationTokenSource();

            server_Configs = new ServerConfig(messagePort, cameraPort, ServerIP_label, ServerPort_label, ServerStatus_panel, cancellationTokenSource);
            serverIP = server_Configs.DisplayServerIP_Port();
            server_Configs.Start();

            joystick_Configs = new JoystickConfig(cancellationTokenSource, SendMessage);
            joystick_Configs.Initialize();

            camera_Configs = new CameraConfig(Main_pictureBox, cameraPort, serverIP, cancellationTokenSource);
            camera_Configs.Start();
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

        public string SendMessage(string message)
        {
            return server_Configs.SendMessage(message);
        }
    }
}
