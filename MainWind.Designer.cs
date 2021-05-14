
namespace RoboAppV01
{
    partial class MainWind
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWind));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.portToolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BoxJogOper = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SetSpeedBTN = new System.Windows.Forms.Button();
            this.RotAngTextLebel = new System.Windows.Forms.Label();
            this.AngVelTextLebel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.AngVeloSlider = new System.Windows.Forms.TrackBar();
            this.RotateAngSlider = new System.Windows.Forms.TrackBar();
            this.GripIncrBTN = new System.Windows.Forms.Button();
            this.BaseIncrBTN = new System.Windows.Forms.Button();
            this.WaistIncrBTN = new System.Windows.Forms.Button();
            this.UppArmIncrBTN = new System.Windows.Forms.Button();
            this.TwistIncrBTN = new System.Windows.Forms.Button();
            this.LowArmIncrBTN = new System.Windows.Forms.Button();
            this.WristIncrBTN = new System.Windows.Forms.Button();
            this.GripDecrBTN = new System.Windows.Forms.Button();
            this.BaseDecrBTN = new System.Windows.Forms.Button();
            this.WaistDecrBTN = new System.Windows.Forms.Button();
            this.UppArmDecrBTN = new System.Windows.Forms.Button();
            this.TwistDecrBTN = new System.Windows.Forms.Button();
            this.LowArmDecrBTN = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.WristDecrBTN = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.MessegesBox = new System.Windows.Forms.RichTextBox();
            this.ShowSend = new System.Windows.Forms.CheckBox();
            this.MessegesClearBTN = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.SendComBTN = new System.Windows.Forms.Button();
            this.CommandBox = new System.Windows.Forms.RichTextBox();
            this.ComList = new System.Windows.Forms.ListBox();
            this.SeComClearBTN = new System.Windows.Forms.Button();
            this.PortOpenBTN = new System.Windows.Forms.Button();
            this.PortCloseBTN = new System.Windows.Forms.Button();
            this.RadioBTN = new System.Windows.Forms.RadioButton();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.menuStrip1.SuspendLayout();
            this.BoxJogOper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AngVeloSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RotateAngSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Silver;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitAppToolStripMenuItem,
            this.fileToolStripMenuItem,
            this.portToolToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1176, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitAppToolStripMenuItem
            // 
            this.exitAppToolStripMenuItem.Name = "exitAppToolStripMenuItem";
            this.exitAppToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.exitAppToolStripMenuItem.Text = "ExitApp";
            this.exitAppToolStripMenuItem.Click += new System.EventHandler(this.exitAppToolStripMenuItem_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // portToolToolStripMenuItem
            // 
            this.portToolToolStripMenuItem.Name = "portToolToolStripMenuItem";
            this.portToolToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.portToolToolStripMenuItem.Text = "PortTool";
            this.portToolToolStripMenuItem.Click += new System.EventHandler(this.portToolToolStripMenuItem_Click);
            // 
            // BoxJogOper
            // 
            this.BoxJogOper.Controls.Add(this.label15);
            this.BoxJogOper.Controls.Add(this.label14);
            this.BoxJogOper.Controls.Add(this.label13);
            this.BoxJogOper.Controls.Add(this.label12);
            this.BoxJogOper.Controls.Add(this.label11);
            this.BoxJogOper.Controls.Add(this.label10);
            this.BoxJogOper.Controls.Add(this.SetSpeedBTN);
            this.BoxJogOper.Controls.Add(this.RotAngTextLebel);
            this.BoxJogOper.Controls.Add(this.AngVelTextLebel);
            this.BoxJogOper.Controls.Add(this.label9);
            this.BoxJogOper.Controls.Add(this.label8);
            this.BoxJogOper.Controls.Add(this.label7);
            this.BoxJogOper.Controls.Add(this.AngVeloSlider);
            this.BoxJogOper.Controls.Add(this.RotateAngSlider);
            this.BoxJogOper.Controls.Add(this.GripIncrBTN);
            this.BoxJogOper.Controls.Add(this.BaseIncrBTN);
            this.BoxJogOper.Controls.Add(this.WaistIncrBTN);
            this.BoxJogOper.Controls.Add(this.UppArmIncrBTN);
            this.BoxJogOper.Controls.Add(this.TwistIncrBTN);
            this.BoxJogOper.Controls.Add(this.LowArmIncrBTN);
            this.BoxJogOper.Controls.Add(this.WristIncrBTN);
            this.BoxJogOper.Controls.Add(this.GripDecrBTN);
            this.BoxJogOper.Controls.Add(this.BaseDecrBTN);
            this.BoxJogOper.Controls.Add(this.WaistDecrBTN);
            this.BoxJogOper.Controls.Add(this.UppArmDecrBTN);
            this.BoxJogOper.Controls.Add(this.TwistDecrBTN);
            this.BoxJogOper.Controls.Add(this.LowArmDecrBTN);
            this.BoxJogOper.Controls.Add(this.label6);
            this.BoxJogOper.Controls.Add(this.label5);
            this.BoxJogOper.Controls.Add(this.label4);
            this.BoxJogOper.Controls.Add(this.label3);
            this.BoxJogOper.Controls.Add(this.label2);
            this.BoxJogOper.Controls.Add(this.label1);
            this.BoxJogOper.Controls.Add(this.WristDecrBTN);
            this.BoxJogOper.Controls.Add(this.pictureBox1);
            this.BoxJogOper.Enabled = false;
            this.BoxJogOper.Location = new System.Drawing.Point(581, 31);
            this.BoxJogOper.Name = "BoxJogOper";
            this.BoxJogOper.Size = new System.Drawing.Size(583, 585);
            this.BoxJogOper.TabIndex = 1;
            this.BoxJogOper.TabStop = false;
            this.BoxJogOper.Text = "Jog Operation";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(6, 553);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 16);
            this.label15.TabIndex = 46;
            this.label15.Text = "Axis 1";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(6, 503);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 16);
            this.label14.TabIndex = 45;
            this.label14.Text = "Axis 2";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(6, 458);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 16);
            this.label13.TabIndex = 44;
            this.label13.Text = "Axis 3";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(6, 411);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 16);
            this.label12.TabIndex = 43;
            this.label12.Text = "Axis 4";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(6, 366);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 16);
            this.label11.TabIndex = 42;
            this.label11.Text = "Axis 5";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(6, 321);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 16);
            this.label10.TabIndex = 41;
            this.label10.Text = "Axis 6";
            // 
            // SetSpeedBTN
            // 
            this.SetSpeedBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SetSpeedBTN.ForeColor = System.Drawing.Color.Black;
            this.SetSpeedBTN.Location = new System.Drawing.Point(9, 98);
            this.SetSpeedBTN.Name = "SetSpeedBTN";
            this.SetSpeedBTN.Size = new System.Drawing.Size(61, 36);
            this.SetSpeedBTN.TabIndex = 40;
            this.SetSpeedBTN.Text = "Set Speed";
            this.SetSpeedBTN.UseVisualStyleBackColor = true;
            this.SetSpeedBTN.Click += new System.EventHandler(this.SetSpeedBTN_Click);
            // 
            // RotAngTextLebel
            // 
            this.RotAngTextLebel.AutoSize = true;
            this.RotAngTextLebel.ForeColor = System.Drawing.Color.Black;
            this.RotAngTextLebel.Location = new System.Drawing.Point(91, 221);
            this.RotAngTextLebel.Name = "RotAngTextLebel";
            this.RotAngTextLebel.Size = new System.Drawing.Size(58, 17);
            this.RotAngTextLebel.TabIndex = 40;
            this.RotAngTextLebel.Text = "RotAngl";
            // 
            // AngVelTextLebel
            // 
            this.AngVelTextLebel.AutoSize = true;
            this.AngVelTextLebel.ForeColor = System.Drawing.Color.Black;
            this.AngVelTextLebel.Location = new System.Drawing.Point(91, 92);
            this.AngVelTextLebel.Name = "AngVelTextLebel";
            this.AngVelTextLebel.Size = new System.Drawing.Size(61, 17);
            this.AngVelTextLebel.TabIndex = 37;
            this.AngVelTextLebel.Text = "AngVelo";
            this.AngVelTextLebel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.DimGray;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Location = new System.Drawing.Point(25, 159);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(150, 20);
            this.label9.TabIndex = 36;
            this.label9.Text = "Jog Rotation Angle";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.DimGray;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(51, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 20);
            this.label8.TabIndex = 35;
            this.label8.Text = "Jog Velocity";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.DimGray;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(152, 407);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 20);
            this.label7.TabIndex = 34;
            this.label7.Text = "Twist";
            // 
            // AngVeloSlider
            // 
            this.AngVeloSlider.Location = new System.Drawing.Point(6, 53);
            this.AngVeloSlider.Maximum = 20;
            this.AngVeloSlider.Minimum = 1;
            this.AngVeloSlider.Name = "AngVeloSlider";
            this.AngVeloSlider.Size = new System.Drawing.Size(187, 56);
            this.AngVeloSlider.TabIndex = 14;
            this.AngVeloSlider.Value = 1;
            this.AngVeloSlider.Scroll += new System.EventHandler(this.AngVeloSlider_Scroll_1);
            // 
            // RotateAngSlider
            // 
            this.RotateAngSlider.Location = new System.Drawing.Point(6, 182);
            this.RotateAngSlider.Maximum = 30;
            this.RotateAngSlider.Minimum = 1;
            this.RotateAngSlider.Name = "RotateAngSlider";
            this.RotateAngSlider.Size = new System.Drawing.Size(187, 56);
            this.RotateAngSlider.TabIndex = 39;
            this.RotateAngSlider.Value = 1;
            this.RotateAngSlider.Scroll += new System.EventHandler(this.RotateAngSlider_Scroll);
            // 
            // GripIncrBTN
            // 
            this.GripIncrBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GripIncrBTN.ForeColor = System.Drawing.Color.Black;
            this.GripIncrBTN.Location = new System.Drawing.Point(231, 270);
            this.GripIncrBTN.Name = "GripIncrBTN";
            this.GripIncrBTN.Size = new System.Drawing.Size(61, 23);
            this.GripIncrBTN.TabIndex = 33;
            this.GripIncrBTN.Text = "Open";
            this.GripIncrBTN.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.GripIncrBTN.UseVisualStyleBackColor = true;
            this.GripIncrBTN.Click += new System.EventHandler(this.GripIncrBTN_Click);
            // 
            // BaseIncrBTN
            // 
            this.BaseIncrBTN.BackColor = System.Drawing.Color.Transparent;
            this.BaseIncrBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BaseIncrBTN.ForeColor = System.Drawing.Color.Black;
            this.BaseIncrBTN.Location = new System.Drawing.Point(244, 549);
            this.BaseIncrBTN.Name = "BaseIncrBTN";
            this.BaseIncrBTN.Size = new System.Drawing.Size(48, 23);
            this.BaseIncrBTN.TabIndex = 32;
            this.BaseIncrBTN.Text = ">";
            this.BaseIncrBTN.UseVisualStyleBackColor = false;
            this.BaseIncrBTN.Click += new System.EventHandler(this.BaseIncrBTN_Click);
            // 
            // WaistIncrBTN
            // 
            this.WaistIncrBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WaistIncrBTN.ForeColor = System.Drawing.Color.Black;
            this.WaistIncrBTN.Location = new System.Drawing.Point(244, 501);
            this.WaistIncrBTN.Name = "WaistIncrBTN";
            this.WaistIncrBTN.Size = new System.Drawing.Size(48, 23);
            this.WaistIncrBTN.TabIndex = 31;
            this.WaistIncrBTN.Text = ">";
            this.WaistIncrBTN.UseVisualStyleBackColor = true;
            this.WaistIncrBTN.Click += new System.EventHandler(this.WaistIncrBTN_Click);
            // 
            // UppArmIncrBTN
            // 
            this.UppArmIncrBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UppArmIncrBTN.ForeColor = System.Drawing.Color.Black;
            this.UppArmIncrBTN.Location = new System.Drawing.Point(244, 454);
            this.UppArmIncrBTN.Name = "UppArmIncrBTN";
            this.UppArmIncrBTN.Size = new System.Drawing.Size(48, 23);
            this.UppArmIncrBTN.TabIndex = 30;
            this.UppArmIncrBTN.Text = ">";
            this.UppArmIncrBTN.UseVisualStyleBackColor = true;
            this.UppArmIncrBTN.Click += new System.EventHandler(this.UppArmIncrBTN_Click);
            // 
            // TwistIncrBTN
            // 
            this.TwistIncrBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TwistIncrBTN.ForeColor = System.Drawing.Color.Black;
            this.TwistIncrBTN.Location = new System.Drawing.Point(244, 407);
            this.TwistIncrBTN.Name = "TwistIncrBTN";
            this.TwistIncrBTN.Size = new System.Drawing.Size(48, 23);
            this.TwistIncrBTN.TabIndex = 29;
            this.TwistIncrBTN.Text = ">";
            this.TwistIncrBTN.UseVisualStyleBackColor = true;
            this.TwistIncrBTN.Click += new System.EventHandler(this.TwistIncrBTN_Click);
            // 
            // LowArmIncrBTN
            // 
            this.LowArmIncrBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LowArmIncrBTN.ForeColor = System.Drawing.Color.Black;
            this.LowArmIncrBTN.Location = new System.Drawing.Point(244, 362);
            this.LowArmIncrBTN.Name = "LowArmIncrBTN";
            this.LowArmIncrBTN.Size = new System.Drawing.Size(48, 23);
            this.LowArmIncrBTN.TabIndex = 28;
            this.LowArmIncrBTN.Text = ">";
            this.LowArmIncrBTN.UseVisualStyleBackColor = true;
            this.LowArmIncrBTN.Click += new System.EventHandler(this.LowArmIncrBTN_Click);
            // 
            // WristIncrBTN
            // 
            this.WristIncrBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WristIncrBTN.ForeColor = System.Drawing.Color.Black;
            this.WristIncrBTN.Location = new System.Drawing.Point(244, 317);
            this.WristIncrBTN.Name = "WristIncrBTN";
            this.WristIncrBTN.Size = new System.Drawing.Size(48, 23);
            this.WristIncrBTN.TabIndex = 27;
            this.WristIncrBTN.Text = ">";
            this.WristIncrBTN.UseVisualStyleBackColor = true;
            this.WristIncrBTN.Click += new System.EventHandler(this.WristIncrBTN_Click);
            // 
            // GripDecrBTN
            // 
            this.GripDecrBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GripDecrBTN.ForeColor = System.Drawing.Color.Black;
            this.GripDecrBTN.Location = new System.Drawing.Point(62, 270);
            this.GripDecrBTN.Name = "GripDecrBTN";
            this.GripDecrBTN.Size = new System.Drawing.Size(58, 23);
            this.GripDecrBTN.TabIndex = 26;
            this.GripDecrBTN.Text = "Close";
            this.GripDecrBTN.UseVisualStyleBackColor = true;
            this.GripDecrBTN.Click += new System.EventHandler(this.GripDecrBTN_Click);
            // 
            // BaseDecrBTN
            // 
            this.BaseDecrBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BaseDecrBTN.ForeColor = System.Drawing.Color.Black;
            this.BaseDecrBTN.Location = new System.Drawing.Point(62, 549);
            this.BaseDecrBTN.Name = "BaseDecrBTN";
            this.BaseDecrBTN.Size = new System.Drawing.Size(48, 23);
            this.BaseDecrBTN.TabIndex = 25;
            this.BaseDecrBTN.Text = "<";
            this.BaseDecrBTN.UseVisualStyleBackColor = true;
            this.BaseDecrBTN.Click += new System.EventHandler(this.BaseDecrBTN_Click);
            // 
            // WaistDecrBTN
            // 
            this.WaistDecrBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WaistDecrBTN.ForeColor = System.Drawing.Color.Black;
            this.WaistDecrBTN.Location = new System.Drawing.Point(62, 501);
            this.WaistDecrBTN.Name = "WaistDecrBTN";
            this.WaistDecrBTN.Size = new System.Drawing.Size(48, 23);
            this.WaistDecrBTN.TabIndex = 24;
            this.WaistDecrBTN.Text = "<";
            this.WaistDecrBTN.UseVisualStyleBackColor = true;
            this.WaistDecrBTN.Click += new System.EventHandler(this.WaistDecrBTN_Click);
            // 
            // UppArmDecrBTN
            // 
            this.UppArmDecrBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UppArmDecrBTN.ForeColor = System.Drawing.Color.Black;
            this.UppArmDecrBTN.Location = new System.Drawing.Point(62, 454);
            this.UppArmDecrBTN.Name = "UppArmDecrBTN";
            this.UppArmDecrBTN.Size = new System.Drawing.Size(48, 23);
            this.UppArmDecrBTN.TabIndex = 23;
            this.UppArmDecrBTN.Text = "<";
            this.UppArmDecrBTN.UseVisualStyleBackColor = true;
            this.UppArmDecrBTN.Click += new System.EventHandler(this.UppArmDecrBTN_Click);
            // 
            // TwistDecrBTN
            // 
            this.TwistDecrBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TwistDecrBTN.ForeColor = System.Drawing.Color.Black;
            this.TwistDecrBTN.Location = new System.Drawing.Point(62, 407);
            this.TwistDecrBTN.Name = "TwistDecrBTN";
            this.TwistDecrBTN.Size = new System.Drawing.Size(48, 23);
            this.TwistDecrBTN.TabIndex = 22;
            this.TwistDecrBTN.Text = "<";
            this.TwistDecrBTN.UseVisualStyleBackColor = true;
            this.TwistDecrBTN.Click += new System.EventHandler(this.TwistDecrBTN_Click);
            // 
            // LowArmDecrBTN
            // 
            this.LowArmDecrBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LowArmDecrBTN.ForeColor = System.Drawing.Color.Black;
            this.LowArmDecrBTN.Location = new System.Drawing.Point(62, 362);
            this.LowArmDecrBTN.Name = "LowArmDecrBTN";
            this.LowArmDecrBTN.Size = new System.Drawing.Size(48, 23);
            this.LowArmDecrBTN.TabIndex = 21;
            this.LowArmDecrBTN.Text = "<";
            this.LowArmDecrBTN.UseVisualStyleBackColor = true;
            this.LowArmDecrBTN.Click += new System.EventHandler(this.LowArmDecrBTN_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DimGray;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(152, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Grip";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DimGray;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(152, 317);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Wrist";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DimGray;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(134, 362);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Lower Arm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DimGray;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(135, 454);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Upper Arm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DimGray;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(153, 499);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Waist";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DimGray;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(153, 552);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Base";
            // 
            // WristDecrBTN
            // 
            this.WristDecrBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WristDecrBTN.ForeColor = System.Drawing.Color.Black;
            this.WristDecrBTN.Location = new System.Drawing.Point(62, 317);
            this.WristDecrBTN.Name = "WristDecrBTN";
            this.WristDecrBTN.Size = new System.Drawing.Size(48, 23);
            this.WristDecrBTN.TabIndex = 0;
            this.WristDecrBTN.Text = "<";
            this.WristDecrBTN.UseVisualStyleBackColor = true;
            this.WristDecrBTN.Click += new System.EventHandler(this.WristDecrBTN_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(199, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(449, 536);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.MessegesBox);
            this.groupBox2.Controls.Add(this.ShowSend);
            this.groupBox2.Controls.Add(this.MessegesClearBTN);
            this.groupBox2.Location = new System.Drawing.Point(12, 401);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(464, 339);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Messages";
            // 
            // MessegesBox
            // 
            this.MessegesBox.Location = new System.Drawing.Point(7, 21);
            this.MessegesBox.Name = "MessegesBox";
            this.MessegesBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.MessegesBox.Size = new System.Drawing.Size(451, 283);
            this.MessegesBox.TabIndex = 3;
            this.MessegesBox.Text = "";
            // 
            // ShowSend
            // 
            this.ShowSend.AutoSize = true;
            this.ShowSend.ForeColor = System.Drawing.Color.Black;
            this.ShowSend.Location = new System.Drawing.Point(42, 310);
            this.ShowSend.Name = "ShowSend";
            this.ShowSend.Size = new System.Drawing.Size(144, 21);
            this.ShowSend.TabIndex = 4;
            this.ShowSend.Text = "Show only recived";
            this.ShowSend.UseVisualStyleBackColor = true;
            // 
            // MessegesClearBTN
            // 
            this.MessegesClearBTN.ForeColor = System.Drawing.Color.Black;
            this.MessegesClearBTN.Location = new System.Drawing.Point(383, 310);
            this.MessegesClearBTN.Name = "MessegesClearBTN";
            this.MessegesClearBTN.Size = new System.Drawing.Size(75, 23);
            this.MessegesClearBTN.TabIndex = 1;
            this.MessegesClearBTN.Text = "Clear";
            this.MessegesClearBTN.UseVisualStyleBackColor = true;
            this.MessegesClearBTN.Click += new System.EventHandler(this.MessegesClearBTN_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.SendComBTN);
            this.groupBox3.Controls.Add(this.CommandBox);
            this.groupBox3.Controls.Add(this.ComList);
            this.groupBox3.Controls.Add(this.SeComClearBTN);
            this.groupBox3.Location = new System.Drawing.Point(12, 111);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(563, 284);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Send Command";
            // 
            // SendComBTN
            // 
            this.SendComBTN.Enabled = false;
            this.SendComBTN.ForeColor = System.Drawing.Color.Black;
            this.SendComBTN.Location = new System.Drawing.Point(342, 24);
            this.SendComBTN.Name = "SendComBTN";
            this.SendComBTN.Size = new System.Drawing.Size(75, 24);
            this.SendComBTN.TabIndex = 4;
            this.SendComBTN.Text = "Send";
            this.SendComBTN.UseVisualStyleBackColor = true;
            this.SendComBTN.Click += new System.EventHandler(this.SendComBTN_Click);
            // 
            // CommandBox
            // 
            this.CommandBox.Location = new System.Drawing.Point(6, 25);
            this.CommandBox.Name = "CommandBox";
            this.CommandBox.Size = new System.Drawing.Size(305, 249);
            this.CommandBox.TabIndex = 3;
            this.CommandBox.Text = "";
            // 
            // ComList
            // 
            this.ComList.FormattingEnabled = true;
            this.ComList.ItemHeight = 16;
            this.ComList.Location = new System.Drawing.Point(329, 62);
            this.ComList.Name = "ComList";
            this.ComList.Size = new System.Drawing.Size(228, 212);
            this.ComList.TabIndex = 2;
            this.ComList.DoubleClick += new System.EventHandler(this.ComList_DoubleClick1);
            // 
            // SeComClearBTN
            // 
            this.SeComClearBTN.ForeColor = System.Drawing.Color.Black;
            this.SeComClearBTN.Location = new System.Drawing.Point(443, 25);
            this.SeComClearBTN.Name = "SeComClearBTN";
            this.SeComClearBTN.Size = new System.Drawing.Size(75, 23);
            this.SeComClearBTN.TabIndex = 1;
            this.SeComClearBTN.Text = "Clear";
            this.SeComClearBTN.UseVisualStyleBackColor = true;
            this.SeComClearBTN.Click += new System.EventHandler(this.SeComClearBTN_Click);
            // 
            // PortOpenBTN
            // 
            this.PortOpenBTN.ForeColor = System.Drawing.Color.Black;
            this.PortOpenBTN.Location = new System.Drawing.Point(7, 21);
            this.PortOpenBTN.Name = "PortOpenBTN";
            this.PortOpenBTN.Size = new System.Drawing.Size(77, 28);
            this.PortOpenBTN.TabIndex = 4;
            this.PortOpenBTN.Text = "Open";
            this.PortOpenBTN.UseVisualStyleBackColor = true;
            this.PortOpenBTN.Click += new System.EventHandler(this.PortOpenBTN_Click);
            // 
            // PortCloseBTN
            // 
            this.PortCloseBTN.Enabled = false;
            this.PortCloseBTN.ForeColor = System.Drawing.Color.Black;
            this.PortCloseBTN.Location = new System.Drawing.Point(90, 21);
            this.PortCloseBTN.Name = "PortCloseBTN";
            this.PortCloseBTN.Size = new System.Drawing.Size(79, 28);
            this.PortCloseBTN.TabIndex = 5;
            this.PortCloseBTN.Text = "Close";
            this.PortCloseBTN.UseVisualStyleBackColor = true;
            this.PortCloseBTN.Click += new System.EventHandler(this.PortCloseBTN_Click);
            // 
            // RadioBTN
            // 
            this.RadioBTN.AutoSize = true;
            this.RadioBTN.BackColor = System.Drawing.Color.Transparent;
            this.RadioBTN.Enabled = false;
            this.RadioBTN.ForeColor = System.Drawing.Color.Black;
            this.RadioBTN.Location = new System.Drawing.Point(175, 23);
            this.RadioBTN.Name = "RadioBTN";
            this.RadioBTN.Size = new System.Drawing.Size(94, 21);
            this.RadioBTN.TabIndex = 6;
            this.RadioBTN.TabStop = true;
            this.RadioBTN.Text = "Port Close";
            this.RadioBTN.UseVisualStyleBackColor = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.PortCloseBTN);
            this.groupBox6.Controls.Add(this.RadioBTN);
            this.groupBox6.Controls.Add(this.PortOpenBTN);
            this.groupBox6.Location = new System.Drawing.Point(12, 44);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(278, 56);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Port";
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // MainWind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1176, 752);
            this.Controls.Add(this.BoxJogOper);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.DimGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWind";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.BoxJogOper.ResumeLayout(false);
            this.BoxJogOper.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AngVeloSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RotateAngSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitAppToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem portToolToolStripMenuItem;
        private System.Windows.Forms.GroupBox BoxJogOper;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TrackBar AngVeloSlider;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button GripIncrBTN;
        private System.Windows.Forms.Button BaseIncrBTN;
        private System.Windows.Forms.Button WaistIncrBTN;
        private System.Windows.Forms.Button UppArmIncrBTN;
        private System.Windows.Forms.Button TwistIncrBTN;
        private System.Windows.Forms.Button LowArmIncrBTN;
        private System.Windows.Forms.Button WristIncrBTN;
        private System.Windows.Forms.Button GripDecrBTN;
        private System.Windows.Forms.Button BaseDecrBTN;
        private System.Windows.Forms.Button WaistDecrBTN;
        private System.Windows.Forms.Button UppArmDecrBTN;
        private System.Windows.Forms.Button TwistDecrBTN;
        private System.Windows.Forms.Button LowArmDecrBTN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button WristDecrBTN;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button MessegesClearBTN;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox ComList;
        private System.Windows.Forms.Button SeComClearBTN;
        private System.Windows.Forms.Button PortOpenBTN;
        private System.Windows.Forms.Button PortCloseBTN;
        private System.Windows.Forms.TrackBar RotateAngSlider;
        private System.Windows.Forms.Label AngVelTextLebel;
        private System.Windows.Forms.Label RotAngTextLebel;
        private System.Windows.Forms.RadioButton RadioBTN;
        private System.Windows.Forms.GroupBox groupBox6;
        public System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button SetSpeedBTN;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox MessegesBox;
        private System.Windows.Forms.CheckBox ShowSend;
        private System.Windows.Forms.Button SendComBTN;
        private System.Windows.Forms.RichTextBox CommandBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
    }
}

