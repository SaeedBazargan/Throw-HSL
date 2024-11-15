namespace ThrowBot_GUI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.ServerIP_label = new System.Windows.Forms.Label();
            this.ServerPort_label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.JoystickY_circularProgressBar = new CircularProgressBar.CircularProgressBar();
            this.JoystickX_circularProgressBar = new CircularProgressBar.CircularProgressBar();
            this.ServerStatus_panel = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Orientation_circularProgressBar = new CircularProgressBar.CircularProgressBar();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Exit_pictureBox = new System.Windows.Forms.PictureBox();
            this.Config_pictureBox = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Main_pictureBox = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.AudioEn_label = new System.Windows.Forms.Label();
            this.GrayEn_label = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.YoloEn_label = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.PresentSpeed2_label = new System.Windows.Forms.Label();
            this.LED2_label = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.PresentSpeed1_label = new System.Windows.Forms.Label();
            this.LED1_label = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.LowPower_label = new System.Windows.Forms.Label();
            this.AlarmLED_label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BatteryVoltage_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Exit_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Config_pictureBox)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Main_pictureBox)).BeginInit();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1020, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 710);
            this.panel1.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.ServerIP_label);
            this.panel6.Controls.Add(this.ServerPort_label);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.panel12);
            this.panel6.Controls.Add(this.panel11);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.JoystickY_circularProgressBar);
            this.panel6.Controls.Add(this.JoystickX_circularProgressBar);
            this.panel6.Controls.Add(this.ServerStatus_panel);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.Orientation_circularProgressBar);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(0, 177);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(248, 447);
            this.panel6.TabIndex = 5;
            // 
            // ServerIP_label
            // 
            this.ServerIP_label.AutoSize = true;
            this.ServerIP_label.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServerIP_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.ServerIP_label.Location = new System.Drawing.Point(107, 396);
            this.ServerIP_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ServerIP_label.Name = "ServerIP_label";
            this.ServerIP_label.Size = new System.Drawing.Size(93, 19);
            this.ServerIP_label.TabIndex = 29;
            this.ServerIP_label.Text = "192.168.1.1";
            // 
            // ServerPort_label
            // 
            this.ServerPort_label.AutoSize = true;
            this.ServerPort_label.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServerPort_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.ServerPort_label.Location = new System.Drawing.Point(107, 420);
            this.ServerPort_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ServerPort_label.Name = "ServerPort_label";
            this.ServerPort_label.Size = new System.Drawing.Size(133, 19);
            this.ServerPort_label.TabIndex = 28;
            this.ServerPort_label.Text = "8000, 1234, 1000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label4.Location = new System.Drawing.Point(0, 420);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 19);
            this.label4.TabIndex = 27;
            this.label4.Text = "Server_Port:";
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            this.panel12.Location = new System.Drawing.Point(95, 169);
            this.panel12.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(67, 4);
            this.panel12.TabIndex = 26;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            this.panel11.Location = new System.Drawing.Point(95, 319);
            this.panel11.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(67, 4);
            this.panel11.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(85, 187);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Joystick";
            // 
            // JoystickY_circularProgressBar
            // 
            this.JoystickY_circularProgressBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.JoystickY_circularProgressBar.AnimationSpeed = 500;
            this.JoystickY_circularProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.JoystickY_circularProgressBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JoystickY_circularProgressBar.ForeColor = System.Drawing.Color.White;
            this.JoystickY_circularProgressBar.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.JoystickY_circularProgressBar.InnerMargin = 2;
            this.JoystickY_circularProgressBar.InnerWidth = -1;
            this.JoystickY_circularProgressBar.Location = new System.Drawing.Point(131, 212);
            this.JoystickY_circularProgressBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.JoystickY_circularProgressBar.MarqueeAnimationSpeed = 2000;
            this.JoystickY_circularProgressBar.Name = "JoystickY_circularProgressBar";
            this.JoystickY_circularProgressBar.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.JoystickY_circularProgressBar.OuterMargin = -25;
            this.JoystickY_circularProgressBar.OuterWidth = 26;
            this.JoystickY_circularProgressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(249)))));
            this.JoystickY_circularProgressBar.ProgressWidth = 8;
            this.JoystickY_circularProgressBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.JoystickY_circularProgressBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JoystickY_circularProgressBar.Size = new System.Drawing.Size(107, 98);
            this.JoystickY_circularProgressBar.StartAngle = 268;
            this.JoystickY_circularProgressBar.Step = 1;
            this.JoystickY_circularProgressBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.JoystickY_circularProgressBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.JoystickY_circularProgressBar.SubscriptText = "";
            this.JoystickY_circularProgressBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.JoystickY_circularProgressBar.SuperscriptMargin = new System.Windows.Forms.Padding(0, 35, 0, 0);
            this.JoystickY_circularProgressBar.SuperscriptText = "";
            this.JoystickY_circularProgressBar.TabIndex = 9;
            this.JoystickY_circularProgressBar.Text = "y";
            this.JoystickY_circularProgressBar.TextMargin = new System.Windows.Forms.Padding(0);
            this.JoystickY_circularProgressBar.Value = 1;
            // 
            // JoystickX_circularProgressBar
            // 
            this.JoystickX_circularProgressBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.JoystickX_circularProgressBar.AnimationSpeed = 500;
            this.JoystickX_circularProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.JoystickX_circularProgressBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JoystickX_circularProgressBar.ForeColor = System.Drawing.Color.White;
            this.JoystickX_circularProgressBar.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.JoystickX_circularProgressBar.InnerMargin = 2;
            this.JoystickX_circularProgressBar.InnerWidth = -1;
            this.JoystickX_circularProgressBar.Location = new System.Drawing.Point(16, 212);
            this.JoystickX_circularProgressBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.JoystickX_circularProgressBar.MarqueeAnimationSpeed = 2000;
            this.JoystickX_circularProgressBar.Name = "JoystickX_circularProgressBar";
            this.JoystickX_circularProgressBar.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.JoystickX_circularProgressBar.OuterMargin = -25;
            this.JoystickX_circularProgressBar.OuterWidth = 26;
            this.JoystickX_circularProgressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(249)))));
            this.JoystickX_circularProgressBar.ProgressWidth = 8;
            this.JoystickX_circularProgressBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.JoystickX_circularProgressBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JoystickX_circularProgressBar.Size = new System.Drawing.Size(107, 98);
            this.JoystickX_circularProgressBar.StartAngle = 268;
            this.JoystickX_circularProgressBar.Step = 1;
            this.JoystickX_circularProgressBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.JoystickX_circularProgressBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.JoystickX_circularProgressBar.SubscriptText = "";
            this.JoystickX_circularProgressBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.JoystickX_circularProgressBar.SuperscriptMargin = new System.Windows.Forms.Padding(0, 35, 0, 0);
            this.JoystickX_circularProgressBar.SuperscriptText = "";
            this.JoystickX_circularProgressBar.TabIndex = 8;
            this.JoystickX_circularProgressBar.Text = "x";
            this.JoystickX_circularProgressBar.TextMargin = new System.Windows.Forms.Padding(0);
            this.JoystickX_circularProgressBar.Value = 1;
            // 
            // ServerStatus_panel
            // 
            this.ServerStatus_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ServerStatus_panel.Location = new System.Drawing.Point(8, 375);
            this.ServerStatus_panel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ServerStatus_panel.Name = "ServerStatus_panel";
            this.ServerStatus_panel.Size = new System.Drawing.Size(19, 17);
            this.ServerStatus_panel.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label10.Location = new System.Drawing.Point(0, 396);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 19);
            this.label10.TabIndex = 5;
            this.label10.Text = "Server_IP:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(72, 6);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 23);
            this.label6.TabIndex = 4;
            this.label6.Text = "Orientation";
            // 
            // Orientation_circularProgressBar
            // 
            this.Orientation_circularProgressBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.Orientation_circularProgressBar.AnimationSpeed = 500;
            this.Orientation_circularProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.Orientation_circularProgressBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Orientation_circularProgressBar.ForeColor = System.Drawing.Color.White;
            this.Orientation_circularProgressBar.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.Orientation_circularProgressBar.InnerMargin = 2;
            this.Orientation_circularProgressBar.InnerWidth = -1;
            this.Orientation_circularProgressBar.Location = new System.Drawing.Point(61, 33);
            this.Orientation_circularProgressBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Orientation_circularProgressBar.MarqueeAnimationSpeed = 2000;
            this.Orientation_circularProgressBar.Name = "Orientation_circularProgressBar";
            this.Orientation_circularProgressBar.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.Orientation_circularProgressBar.OuterMargin = -25;
            this.Orientation_circularProgressBar.OuterWidth = 26;
            this.Orientation_circularProgressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(249)))));
            this.Orientation_circularProgressBar.ProgressWidth = 8;
            this.Orientation_circularProgressBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Orientation_circularProgressBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Orientation_circularProgressBar.Size = new System.Drawing.Size(133, 123);
            this.Orientation_circularProgressBar.StartAngle = 268;
            this.Orientation_circularProgressBar.Step = 1;
            this.Orientation_circularProgressBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.Orientation_circularProgressBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.Orientation_circularProgressBar.SubscriptText = "";
            this.Orientation_circularProgressBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.Orientation_circularProgressBar.SuperscriptMargin = new System.Windows.Forms.Padding(0, 35, 0, 0);
            this.Orientation_circularProgressBar.SuperscriptText = "°";
            this.Orientation_circularProgressBar.TabIndex = 3;
            this.Orientation_circularProgressBar.Text = "0";
            this.Orientation_circularProgressBar.TextMargin = new System.Windows.Forms.Padding(8, 5, 0, 0);
            this.Orientation_circularProgressBar.Value = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Controls.Add(this.Exit_pictureBox);
            this.panel5.Controls.Add(this.Config_pictureBox);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 624);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(248, 86);
            this.panel5.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(249)))));
            this.panel3.Location = new System.Drawing.Point(57, 4);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(133, 4);
            this.panel3.TabIndex = 1;
            // 
            // Exit_pictureBox
            // 
            this.Exit_pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Exit_pictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("Exit_pictureBox.Image")));
            this.Exit_pictureBox.Location = new System.Drawing.Point(131, 16);
            this.Exit_pictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Exit_pictureBox.Name = "Exit_pictureBox";
            this.Exit_pictureBox.Size = new System.Drawing.Size(117, 63);
            this.Exit_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Exit_pictureBox.TabIndex = 2;
            this.Exit_pictureBox.TabStop = false;
            this.Exit_pictureBox.Click += new System.EventHandler(this.Exit_pictureBox_Click);
            // 
            // Config_pictureBox
            // 
            this.Config_pictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Config_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("Config_pictureBox.Image")));
            this.Config_pictureBox.Location = new System.Drawing.Point(0, 16);
            this.Config_pictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Config_pictureBox.Name = "Config_pictureBox";
            this.Config_pictureBox.Size = new System.Drawing.Size(119, 63);
            this.Config_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Config_pictureBox.TabIndex = 3;
            this.Config_pictureBox.TabStop = false;
            this.Config_pictureBox.Click += new System.EventHandler(this.Config_pictureBox_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(248, 177);
            this.panel2.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(226)))), ((int)(((byte)(178)))));
            this.label8.Location = new System.Drawing.Point(91, 134);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 19);
            this.label8.TabIndex = 4;
            this.label8.Text = "MRL-HSL";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(80, 27);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel4.Controls.Add(this.Main_pictureBox);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1020, 556);
            this.panel4.TabIndex = 1;
            // 
            // Main_pictureBox
            // 
            this.Main_pictureBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.Main_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("Main_pictureBox.Image")));
            this.Main_pictureBox.Location = new System.Drawing.Point(0, 0);
            this.Main_pictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Main_pictureBox.Name = "Main_pictureBox";
            this.Main_pictureBox.Size = new System.Drawing.Size(1020, 553);
            this.Main_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Main_pictureBox.TabIndex = 0;
            this.Main_pictureBox.TabStop = false;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel7.Controls.Add(this.panel10);
            this.panel7.Controls.Add(this.panel9);
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Controls.Add(this.AudioEn_label);
            this.panel7.Controls.Add(this.GrayEn_label);
            this.panel7.Controls.Add(this.label9);
            this.panel7.Controls.Add(this.YoloEn_label);
            this.panel7.Controls.Add(this.label11);
            this.panel7.Controls.Add(this.label16);
            this.panel7.Controls.Add(this.PresentSpeed2_label);
            this.panel7.Controls.Add(this.LED2_label);
            this.panel7.Controls.Add(this.label18);
            this.panel7.Controls.Add(this.label19);
            this.panel7.Controls.Add(this.label20);
            this.panel7.Controls.Add(this.label21);
            this.panel7.Controls.Add(this.PresentSpeed1_label);
            this.panel7.Controls.Add(this.LED1_label);
            this.panel7.Controls.Add(this.label12);
            this.panel7.Controls.Add(this.label13);
            this.panel7.Controls.Add(this.label14);
            this.panel7.Controls.Add(this.label15);
            this.panel7.Controls.Add(this.LowPower_label);
            this.panel7.Controls.Add(this.AlarmLED_label);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Controls.Add(this.BatteryVoltage_label);
            this.panel7.Controls.Add(this.label3);
            this.panel7.Controls.Add(this.label2);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 564);
            this.panel7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1020, 146);
            this.panel7.TabIndex = 2;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            this.panel10.Location = new System.Drawing.Point(708, 52);
            this.panel10.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(4, 62);
            this.panel10.TabIndex = 24;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            this.panel9.Location = new System.Drawing.Point(477, 52);
            this.panel9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(4, 62);
            this.panel9.TabIndex = 3;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            this.panel8.Location = new System.Drawing.Point(247, 52);
            this.panel8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(4, 62);
            this.panel8.TabIndex = 2;
            // 
            // AudioEn_label
            // 
            this.AudioEn_label.AutoSize = true;
            this.AudioEn_label.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AudioEn_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.AudioEn_label.Location = new System.Drawing.Point(823, 64);
            this.AudioEn_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AudioEn_label.Name = "AudioEn_label";
            this.AudioEn_label.Size = new System.Drawing.Size(65, 19);
            this.AudioEn_label.TabIndex = 23;
            this.AudioEn_label.Text = "Disable";
            // 
            // GrayEn_label
            // 
            this.GrayEn_label.AutoSize = true;
            this.GrayEn_label.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrayEn_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.GrayEn_label.Location = new System.Drawing.Point(823, 95);
            this.GrayEn_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GrayEn_label.Name = "GrayEn_label";
            this.GrayEn_label.Size = new System.Drawing.Size(60, 19);
            this.GrayEn_label.TabIndex = 22;
            this.GrayEn_label.Text = "Enable";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(226)))), ((int)(((byte)(178)))));
            this.label9.Location = new System.Drawing.Point(720, 95);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 19);
            this.label9.TabIndex = 21;
            this.label9.Text = "Gray Scale:";
            // 
            // YoloEn_label
            // 
            this.YoloEn_label.AutoSize = true;
            this.YoloEn_label.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YoloEn_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.YoloEn_label.Location = new System.Drawing.Point(823, 33);
            this.YoloEn_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.YoloEn_label.Name = "YoloEn_label";
            this.YoloEn_label.Size = new System.Drawing.Size(65, 19);
            this.YoloEn_label.TabIndex = 20;
            this.YoloEn_label.Text = "Disable";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(249)))));
            this.label11.Location = new System.Drawing.Point(720, 64);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 19);
            this.label11.TabIndex = 19;
            this.label11.Text = "Audio:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(719, 33);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(63, 19);
            this.label16.TabIndex = 18;
            this.label16.Text = "YOLO:";
            // 
            // PresentSpeed2_label
            // 
            this.PresentSpeed2_label.AutoSize = true;
            this.PresentSpeed2_label.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PresentSpeed2_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.PresentSpeed2_label.Location = new System.Drawing.Point(616, 64);
            this.PresentSpeed2_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PresentSpeed2_label.Name = "PresentSpeed2_label";
            this.PresentSpeed2_label.Size = new System.Drawing.Size(31, 19);
            this.PresentSpeed2_label.TabIndex = 17;
            this.PresentSpeed2_label.Text = "0.0";
            // 
            // LED2_label
            // 
            this.LED2_label.AutoSize = true;
            this.LED2_label.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LED2_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.LED2_label.Location = new System.Drawing.Point(616, 95);
            this.LED2_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LED2_label.Name = "LED2_label";
            this.LED2_label.Size = new System.Drawing.Size(44, 19);
            this.LED2_label.TabIndex = 16;
            this.LED2_label.Text = "OFF";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(226)))), ((int)(((byte)(178)))));
            this.label18.Location = new System.Drawing.Point(489, 95);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(49, 19);
            this.label18.TabIndex = 15;
            this.label18.Text = "LED:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label19.Location = new System.Drawing.Point(616, 33);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(45, 19);
            this.label19.TabIndex = 14;
            this.label19.Text = "ID_2";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(249)))));
            this.label20.Location = new System.Drawing.Point(489, 64);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(119, 19);
            this.label20.TabIndex = 13;
            this.label20.Text = "Present Speed:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(489, 33);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(90, 19);
            this.label21.TabIndex = 12;
            this.label21.Text = "Motor_ID:";
            // 
            // PresentSpeed1_label
            // 
            this.PresentSpeed1_label.AutoSize = true;
            this.PresentSpeed1_label.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PresentSpeed1_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.PresentSpeed1_label.Location = new System.Drawing.Point(385, 64);
            this.PresentSpeed1_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PresentSpeed1_label.Name = "PresentSpeed1_label";
            this.PresentSpeed1_label.Size = new System.Drawing.Size(31, 19);
            this.PresentSpeed1_label.TabIndex = 11;
            this.PresentSpeed1_label.Text = "0.0";
            // 
            // LED1_label
            // 
            this.LED1_label.AutoSize = true;
            this.LED1_label.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LED1_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.LED1_label.Location = new System.Drawing.Point(385, 95);
            this.LED1_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LED1_label.Name = "LED1_label";
            this.LED1_label.Size = new System.Drawing.Size(44, 19);
            this.LED1_label.TabIndex = 10;
            this.LED1_label.Text = "OFF";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(226)))), ((int)(((byte)(178)))));
            this.label12.Location = new System.Drawing.Point(259, 95);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 19);
            this.label12.TabIndex = 9;
            this.label12.Text = "LED:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label13.Location = new System.Drawing.Point(385, 33);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 19);
            this.label13.TabIndex = 8;
            this.label13.Text = "ID_1";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(249)))));
            this.label14.Location = new System.Drawing.Point(259, 64);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(119, 19);
            this.label14.TabIndex = 7;
            this.label14.Text = "Present Speed:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(259, 33);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(90, 19);
            this.label15.TabIndex = 6;
            this.label15.Text = "Motor_ID:";
            // 
            // LowPower_label
            // 
            this.LowPower_label.AutoSize = true;
            this.LowPower_label.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LowPower_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.LowPower_label.Location = new System.Drawing.Point(172, 64);
            this.LowPower_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LowPower_label.Name = "LowPower_label";
            this.LowPower_label.Size = new System.Drawing.Size(65, 19);
            this.LowPower_label.TabIndex = 5;
            this.LowPower_label.Text = "Disable";
            // 
            // AlarmLED_label
            // 
            this.AlarmLED_label.AutoSize = true;
            this.AlarmLED_label.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlarmLED_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.AlarmLED_label.Location = new System.Drawing.Point(172, 95);
            this.AlarmLED_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AlarmLED_label.Name = "AlarmLED_label";
            this.AlarmLED_label.Size = new System.Drawing.Size(47, 19);
            this.AlarmLED_label.TabIndex = 4;
            this.AlarmLED_label.Text = "None";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(226)))), ((int)(((byte)(178)))));
            this.label5.Location = new System.Drawing.Point(36, 95);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "Alarm LED:";
            // 
            // BatteryVoltage_label
            // 
            this.BatteryVoltage_label.AutoSize = true;
            this.BatteryVoltage_label.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BatteryVoltage_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.BatteryVoltage_label.Location = new System.Drawing.Point(172, 33);
            this.BatteryVoltage_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BatteryVoltage_label.Name = "BatteryVoltage_label";
            this.BatteryVoltage_label.Size = new System.Drawing.Size(46, 19);
            this.BatteryVoltage_label.TabIndex = 2;
            this.BatteryVoltage_label.Text = "0.0 V";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(249)))));
            this.label3.Location = new System.Drawing.Point(36, 64);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Low Power:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(36, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Battery Voltage:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1268, 710);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Exit_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Config_pictureBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Main_pictureBox)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Exit_pictureBox;
        private System.Windows.Forms.PictureBox Config_pictureBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label BatteryVoltage_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private CircularProgressBar.CircularProgressBar Orientation_circularProgressBar;
        private System.Windows.Forms.PictureBox Main_pictureBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label PresentSpeed2_label;
        private System.Windows.Forms.Label LED2_label;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label PresentSpeed1_label;
        private System.Windows.Forms.Label LED1_label;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label LowPower_label;
        private System.Windows.Forms.Label AlarmLED_label;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label AudioEn_label;
        private System.Windows.Forms.Label GrayEn_label;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label YoloEn_label;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel ServerStatus_panel;
        private CircularProgressBar.CircularProgressBar JoystickX_circularProgressBar;
        private CircularProgressBar.CircularProgressBar JoystickY_circularProgressBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label ServerIP_label;
        private System.Windows.Forms.Label ServerPort_label;
        private System.Windows.Forms.Label label4;
    }
}

