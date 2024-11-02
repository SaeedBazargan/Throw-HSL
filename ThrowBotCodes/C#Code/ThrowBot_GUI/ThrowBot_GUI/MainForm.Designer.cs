﻿namespace ThrowBot_GUI
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
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.circularProgressBar1 = new CircularProgressBar.CircularProgressBar();
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
            this.label5 = new System.Windows.Forms.Label();
            this.BatteryVoltage_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AlarmLED_label = new System.Windows.Forms.Label();
            this.LowPower_label = new System.Windows.Forms.Label();
            this.PresentSpeed1_label = new System.Windows.Forms.Label();
            this.LED1_label = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.PresentSpeed2_label = new System.Windows.Forms.Label();
            this.LED2_label = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.ServerIP_label = new System.Windows.Forms.Label();
            this.ServerIPandPort_label = new System.Windows.Forms.Label();
            this.AudioEn_label = new System.Windows.Forms.Label();
            this.GrayEn_label = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.YoloEn_label = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
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
            this.panel1.Location = new System.Drawing.Point(765, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 577);
            this.panel1.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.ServerIPandPort_label);
            this.panel6.Controls.Add(this.ServerIP_label);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.circularProgressBar1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(0, 144);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(186, 363);
            this.panel6.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label7.Location = new System.Drawing.Point(71, 262);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "Example:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(57, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 19);
            this.label6.TabIndex = 4;
            this.label6.Text = "Orientation";
            // 
            // circularProgressBar1
            // 
            this.circularProgressBar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar1.AnimationSpeed = 500;
            this.circularProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold);
            this.circularProgressBar1.ForeColor = System.Drawing.Color.White;
            this.circularProgressBar1.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.circularProgressBar1.InnerMargin = 2;
            this.circularProgressBar1.InnerWidth = -1;
            this.circularProgressBar1.Location = new System.Drawing.Point(24, 88);
            this.circularProgressBar1.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar1.Name = "circularProgressBar1";
            this.circularProgressBar1.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.circularProgressBar1.OuterMargin = -25;
            this.circularProgressBar1.OuterWidth = 26;
            this.circularProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(249)))));
            this.circularProgressBar1.ProgressWidth = 10;
            this.circularProgressBar1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.circularProgressBar1.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circularProgressBar1.Size = new System.Drawing.Size(150, 150);
            this.circularProgressBar1.StartAngle = 268;
            this.circularProgressBar1.Step = 1;
            this.circularProgressBar1.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar1.SubscriptText = "";
            this.circularProgressBar1.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar1.SuperscriptText = "°";
            this.circularProgressBar1.TabIndex = 3;
            this.circularProgressBar1.Text = "0";
            this.circularProgressBar1.TextMargin = new System.Windows.Forms.Padding(5, 8, 0, 0);
            this.circularProgressBar1.Value = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Controls.Add(this.Exit_pictureBox);
            this.panel5.Controls.Add(this.Config_pictureBox);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 507);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(186, 70);
            this.panel5.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(249)))));
            this.panel3.Location = new System.Drawing.Point(43, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(100, 3);
            this.panel3.TabIndex = 1;
            // 
            // Exit_pictureBox
            // 
            this.Exit_pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Exit_pictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("Exit_pictureBox.Image")));
            this.Exit_pictureBox.Location = new System.Drawing.Point(98, 13);
            this.Exit_pictureBox.Name = "Exit_pictureBox";
            this.Exit_pictureBox.Size = new System.Drawing.Size(88, 51);
            this.Exit_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Exit_pictureBox.TabIndex = 2;
            this.Exit_pictureBox.TabStop = false;
            this.Exit_pictureBox.Click += new System.EventHandler(this.Exit_pictureBox_Click);
            // 
            // Config_pictureBox
            // 
            this.Config_pictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Config_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("Config_pictureBox.Image")));
            this.Config_pictureBox.Location = new System.Drawing.Point(0, 13);
            this.Config_pictureBox.Name = "Config_pictureBox";
            this.Config_pictureBox.Size = new System.Drawing.Size(89, 51);
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
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 144);
            this.panel2.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(226)))), ((int)(((byte)(178)))));
            this.label8.Location = new System.Drawing.Point(68, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 15);
            this.label8.TabIndex = 4;
            this.label8.Text = "MRL-HSL";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(60, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
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
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(765, 452);
            this.panel4.TabIndex = 1;
            // 
            // Main_pictureBox
            // 
            this.Main_pictureBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.Main_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("Main_pictureBox.Image")));
            this.Main_pictureBox.Location = new System.Drawing.Point(0, 0);
            this.Main_pictureBox.Name = "Main_pictureBox";
            this.Main_pictureBox.Size = new System.Drawing.Size(765, 449);
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
            this.panel7.Location = new System.Drawing.Point(0, 458);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(765, 119);
            this.panel7.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(226)))), ((int)(((byte)(178)))));
            this.label5.Location = new System.Drawing.Point(27, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Alarm LED:";
            // 
            // BatteryVoltage_label
            // 
            this.BatteryVoltage_label.AutoSize = true;
            this.BatteryVoltage_label.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BatteryVoltage_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.BatteryVoltage_label.Location = new System.Drawing.Point(129, 27);
            this.BatteryVoltage_label.Name = "BatteryVoltage_label";
            this.BatteryVoltage_label.Size = new System.Drawing.Size(36, 15);
            this.BatteryVoltage_label.TabIndex = 2;
            this.BatteryVoltage_label.Text = "0.0 V";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(249)))));
            this.label3.Location = new System.Drawing.Point(27, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Low Power:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(27, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Battery Voltage:";
            // 
            // AlarmLED_label
            // 
            this.AlarmLED_label.AutoSize = true;
            this.AlarmLED_label.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlarmLED_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.AlarmLED_label.Location = new System.Drawing.Point(129, 77);
            this.AlarmLED_label.Name = "AlarmLED_label";
            this.AlarmLED_label.Size = new System.Drawing.Size(35, 15);
            this.AlarmLED_label.TabIndex = 4;
            this.AlarmLED_label.Text = "None";
            // 
            // LowPower_label
            // 
            this.LowPower_label.AutoSize = true;
            this.LowPower_label.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LowPower_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.LowPower_label.Location = new System.Drawing.Point(129, 52);
            this.LowPower_label.Name = "LowPower_label";
            this.LowPower_label.Size = new System.Drawing.Size(48, 15);
            this.LowPower_label.TabIndex = 5;
            this.LowPower_label.Text = "Disable";
            // 
            // PresentSpeed1_label
            // 
            this.PresentSpeed1_label.AutoSize = true;
            this.PresentSpeed1_label.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PresentSpeed1_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.PresentSpeed1_label.Location = new System.Drawing.Point(289, 52);
            this.PresentSpeed1_label.Name = "PresentSpeed1_label";
            this.PresentSpeed1_label.Size = new System.Drawing.Size(24, 15);
            this.PresentSpeed1_label.TabIndex = 11;
            this.PresentSpeed1_label.Text = "0.0";
            // 
            // LED1_label
            // 
            this.LED1_label.AutoSize = true;
            this.LED1_label.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LED1_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.LED1_label.Location = new System.Drawing.Point(289, 77);
            this.LED1_label.Name = "LED1_label";
            this.LED1_label.Size = new System.Drawing.Size(31, 15);
            this.LED1_label.TabIndex = 10;
            this.LED1_label.Text = "OFF";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(226)))), ((int)(((byte)(178)))));
            this.label12.Location = new System.Drawing.Point(194, 77);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 15);
            this.label12.TabIndex = 9;
            this.label12.Text = "LED:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label13.Location = new System.Drawing.Point(289, 27);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 15);
            this.label13.TabIndex = 8;
            this.label13.Text = "ID_1";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(249)))));
            this.label14.Location = new System.Drawing.Point(194, 52);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 15);
            this.label14.TabIndex = 7;
            this.label14.Text = "Present Speed:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(194, 27);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 15);
            this.label15.TabIndex = 6;
            this.label15.Text = "Motor_ID:";
            // 
            // PresentSpeed2_label
            // 
            this.PresentSpeed2_label.AutoSize = true;
            this.PresentSpeed2_label.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PresentSpeed2_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.PresentSpeed2_label.Location = new System.Drawing.Point(462, 52);
            this.PresentSpeed2_label.Name = "PresentSpeed2_label";
            this.PresentSpeed2_label.Size = new System.Drawing.Size(24, 15);
            this.PresentSpeed2_label.TabIndex = 17;
            this.PresentSpeed2_label.Text = "0.0";
            // 
            // LED2_label
            // 
            this.LED2_label.AutoSize = true;
            this.LED2_label.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LED2_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.LED2_label.Location = new System.Drawing.Point(462, 77);
            this.LED2_label.Name = "LED2_label";
            this.LED2_label.Size = new System.Drawing.Size(31, 15);
            this.LED2_label.TabIndex = 16;
            this.LED2_label.Text = "OFF";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(226)))), ((int)(((byte)(178)))));
            this.label18.Location = new System.Drawing.Point(367, 77);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(35, 15);
            this.label18.TabIndex = 15;
            this.label18.Text = "LED:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label19.Location = new System.Drawing.Point(462, 27);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(34, 15);
            this.label19.TabIndex = 14;
            this.label19.Text = "ID_2";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(249)))));
            this.label20.Location = new System.Drawing.Point(367, 52);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(89, 15);
            this.label20.TabIndex = 13;
            this.label20.Text = "Present Speed:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(367, 27);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(64, 15);
            this.label21.TabIndex = 12;
            this.label21.Text = "Motor_ID:";
            // 
            // ServerIP_label
            // 
            this.ServerIP_label.AutoSize = true;
            this.ServerIP_label.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServerIP_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.ServerIP_label.Location = new System.Drawing.Point(0, 341);
            this.ServerIP_label.Name = "ServerIP_label";
            this.ServerIP_label.Size = new System.Drawing.Size(67, 15);
            this.ServerIP_label.TabIndex = 5;
            this.ServerIP_label.Text = "Server_IP:";
            // 
            // ServerIPandPort_label
            // 
            this.ServerIPandPort_label.AutoSize = true;
            this.ServerIPandPort_label.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServerIPandPort_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.ServerIPandPort_label.Location = new System.Drawing.Point(62, 341);
            this.ServerIPandPort_label.Name = "ServerIPandPort_label";
            this.ServerIPandPort_label.Size = new System.Drawing.Size(104, 15);
            this.ServerIPandPort_label.TabIndex = 6;
            this.ServerIPandPort_label.Text = "192.168.1.1:8000";
            // 
            // AudioEn_label
            // 
            this.AudioEn_label.AutoSize = true;
            this.AudioEn_label.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AudioEn_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.AudioEn_label.Location = new System.Drawing.Point(617, 52);
            this.AudioEn_label.Name = "AudioEn_label";
            this.AudioEn_label.Size = new System.Drawing.Size(48, 15);
            this.AudioEn_label.TabIndex = 23;
            this.AudioEn_label.Text = "Disable";
            // 
            // GrayEn_label
            // 
            this.GrayEn_label.AutoSize = true;
            this.GrayEn_label.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrayEn_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.GrayEn_label.Location = new System.Drawing.Point(617, 77);
            this.GrayEn_label.Name = "GrayEn_label";
            this.GrayEn_label.Size = new System.Drawing.Size(43, 15);
            this.GrayEn_label.TabIndex = 22;
            this.GrayEn_label.Text = "Enable";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(226)))), ((int)(((byte)(178)))));
            this.label9.Location = new System.Drawing.Point(540, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 15);
            this.label9.TabIndex = 21;
            this.label9.Text = "Gray Scale:";
            // 
            // YoloEn_label
            // 
            this.YoloEn_label.AutoSize = true;
            this.YoloEn_label.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YoloEn_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.YoloEn_label.Location = new System.Drawing.Point(617, 27);
            this.YoloEn_label.Name = "YoloEn_label";
            this.YoloEn_label.Size = new System.Drawing.Size(43, 15);
            this.YoloEn_label.TabIndex = 20;
            this.YoloEn_label.Text = "Enable";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(249)))));
            this.label11.Location = new System.Drawing.Point(540, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 15);
            this.label11.TabIndex = 19;
            this.label11.Text = "Audio:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(539, 27);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 15);
            this.label16.TabIndex = 18;
            this.label16.Text = "YOLO:";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            this.panel8.Location = new System.Drawing.Point(185, 42);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(3, 50);
            this.panel8.TabIndex = 2;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            this.panel9.Location = new System.Drawing.Point(358, 42);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(3, 50);
            this.panel9.TabIndex = 3;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            this.panel10.Location = new System.Drawing.Point(531, 42);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(3, 50);
            this.panel10.TabIndex = 24;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private CircularProgressBar.CircularProgressBar circularProgressBar1;
        private System.Windows.Forms.PictureBox Main_pictureBox;
        private System.Windows.Forms.Label label7;
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
        private System.Windows.Forms.Label ServerIPandPort_label;
        private System.Windows.Forms.Label ServerIP_label;
        private System.Windows.Forms.Label AudioEn_label;
        private System.Windows.Forms.Label GrayEn_label;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label YoloEn_label;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
    }
}

