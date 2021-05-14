
namespace RoboAppV01
{
    partial class PortTool
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
            this.Combo_Port = new System.Windows.Forms.ComboBox();
            this.Combo_BaudRate = new System.Windows.Forms.ComboBox();
            this.Combo_StopBits = new System.Windows.Forms.ComboBox();
            this.Combo_DataBits = new System.Windows.Forms.ComboBox();
            this.Combo_Parity = new System.Windows.Forms.ComboBox();
            this.RtsCtsBox = new System.Windows.Forms.CheckBox();
            this.DTRBox = new System.Windows.Forms.CheckBox();
            this.XBox = new System.Windows.Forms.CheckBox();
            this.PortLabel = new System.Windows.Forms.Label();
            this.BaudRateLabel = new System.Windows.Forms.Label();
            this.DataBitLabel = new System.Windows.Forms.Label();
            this.ParityLabel = new System.Windows.Forms.Label();
            this.StopBitsLabel = new System.Windows.Forms.Label();
            this.SaveBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Combo_Port
            // 
            this.Combo_Port.FormattingEnabled = true;
            this.Combo_Port.Location = new System.Drawing.Point(129, 20);
            this.Combo_Port.Name = "Combo_Port";
            this.Combo_Port.Size = new System.Drawing.Size(121, 24);
            this.Combo_Port.TabIndex = 0;
            // 
            // Combo_BaudRate
            // 
            this.Combo_BaudRate.FormattingEnabled = true;
            this.Combo_BaudRate.Location = new System.Drawing.Point(129, 63);
            this.Combo_BaudRate.Name = "Combo_BaudRate";
            this.Combo_BaudRate.Size = new System.Drawing.Size(121, 24);
            this.Combo_BaudRate.TabIndex = 1;
            // 
            // Combo_StopBits
            // 
            this.Combo_StopBits.FormattingEnabled = true;
            this.Combo_StopBits.Location = new System.Drawing.Point(129, 209);
            this.Combo_StopBits.Name = "Combo_StopBits";
            this.Combo_StopBits.Size = new System.Drawing.Size(121, 24);
            this.Combo_StopBits.TabIndex = 2;
            // 
            // Combo_DataBits
            // 
            this.Combo_DataBits.FormattingEnabled = true;
            this.Combo_DataBits.Location = new System.Drawing.Point(129, 110);
            this.Combo_DataBits.Name = "Combo_DataBits";
            this.Combo_DataBits.Size = new System.Drawing.Size(121, 24);
            this.Combo_DataBits.TabIndex = 3;
            // 
            // Combo_Parity
            // 
            this.Combo_Parity.FormattingEnabled = true;
            this.Combo_Parity.Location = new System.Drawing.Point(129, 157);
            this.Combo_Parity.Name = "Combo_Parity";
            this.Combo_Parity.Size = new System.Drawing.Size(121, 24);
            this.Combo_Parity.TabIndex = 4;
            // 
            // RtsCtsBox
            // 
            this.RtsCtsBox.AutoSize = true;
            this.RtsCtsBox.Location = new System.Drawing.Point(42, 273);
            this.RtsCtsBox.Name = "RtsCtsBox";
            this.RtsCtsBox.Size = new System.Drawing.Size(89, 21);
            this.RtsCtsBox.TabIndex = 5;
            this.RtsCtsBox.Text = "RTS/CTS";
            this.RtsCtsBox.UseVisualStyleBackColor = true;
            this.RtsCtsBox.CheckedChanged += new System.EventHandler(this.RtsCtsBox_CheckedChanged);
            // 
            // DTRBox
            // 
            this.DTRBox.AutoSize = true;
            this.DTRBox.Location = new System.Drawing.Point(42, 246);
            this.DTRBox.Name = "DTRBox";
            this.DTRBox.Size = new System.Drawing.Size(59, 21);
            this.DTRBox.TabIndex = 6;
            this.DTRBox.Text = "DTR";
            this.DTRBox.UseVisualStyleBackColor = true;
            this.DTRBox.CheckedChanged += new System.EventHandler(this.DTRBox_CheckedChanged);
            // 
            // XBox
            // 
            this.XBox.AutoSize = true;
            this.XBox.Location = new System.Drawing.Point(42, 300);
            this.XBox.Name = "XBox";
            this.XBox.Size = new System.Drawing.Size(84, 21);
            this.XBox.TabIndex = 7;
            this.XBox.Text = "Xon/Xoff";
            this.XBox.UseVisualStyleBackColor = true;
            this.XBox.CheckedChanged += new System.EventHandler(this.XBox_CheckedChanged);
            // 
            // PortLabel
            // 
            this.PortLabel.AutoSize = true;
            this.PortLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PortLabel.Location = new System.Drawing.Point(64, 18);
            this.PortLabel.Name = "PortLabel";
            this.PortLabel.Size = new System.Drawing.Size(59, 23);
            this.PortLabel.TabIndex = 8;
            this.PortLabel.Text = "Port :";
            this.PortLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BaudRateLabel
            // 
            this.BaudRateLabel.AutoSize = true;
            this.BaudRateLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BaudRateLabel.Location = new System.Drawing.Point(12, 61);
            this.BaudRateLabel.Name = "BaudRateLabel";
            this.BaudRateLabel.Size = new System.Drawing.Size(111, 23);
            this.BaudRateLabel.TabIndex = 9;
            this.BaudRateLabel.Text = "Baud Rate :";
            this.BaudRateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DataBitLabel
            // 
            this.DataBitLabel.AutoSize = true;
            this.DataBitLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataBitLabel.Location = new System.Drawing.Point(22, 108);
            this.DataBitLabel.Name = "DataBitLabel";
            this.DataBitLabel.Size = new System.Drawing.Size(101, 23);
            this.DataBitLabel.TabIndex = 10;
            this.DataBitLabel.Text = "Data Bits :";
            this.DataBitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ParityLabel
            // 
            this.ParityLabel.AutoSize = true;
            this.ParityLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ParityLabel.Location = new System.Drawing.Point(49, 155);
            this.ParityLabel.Name = "ParityLabel";
            this.ParityLabel.Size = new System.Drawing.Size(74, 23);
            this.ParityLabel.TabIndex = 11;
            this.ParityLabel.Text = "Parity :";
            this.ParityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StopBitsLabel
            // 
            this.StopBitsLabel.AutoSize = true;
            this.StopBitsLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopBitsLabel.Location = new System.Drawing.Point(25, 207);
            this.StopBitsLabel.Name = "StopBitsLabel";
            this.StopBitsLabel.Size = new System.Drawing.Size(98, 23);
            this.StopBitsLabel.TabIndex = 12;
            this.StopBitsLabel.Text = "Stop Bits :";
            this.StopBitsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SaveBTN
            // 
            this.SaveBTN.Location = new System.Drawing.Point(167, 268);
            this.SaveBTN.Name = "SaveBTN";
            this.SaveBTN.Size = new System.Drawing.Size(105, 30);
            this.SaveBTN.TabIndex = 15;
            this.SaveBTN.Text = "Save and Exit";
            this.SaveBTN.UseVisualStyleBackColor = true;
            this.SaveBTN.Click += new System.EventHandler(this.SaveBTN_Click);
            // 
            // PortTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(314, 347);
            this.Controls.Add(this.SaveBTN);
            this.Controls.Add(this.StopBitsLabel);
            this.Controls.Add(this.ParityLabel);
            this.Controls.Add(this.DataBitLabel);
            this.Controls.Add(this.BaudRateLabel);
            this.Controls.Add(this.PortLabel);
            this.Controls.Add(this.XBox);
            this.Controls.Add(this.DTRBox);
            this.Controls.Add(this.RtsCtsBox);
            this.Controls.Add(this.Combo_Parity);
            this.Controls.Add(this.Combo_DataBits);
            this.Controls.Add(this.Combo_StopBits);
            this.Controls.Add(this.Combo_BaudRate);
            this.Controls.Add(this.Combo_Port);
            this.Name = "PortTool";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Combo_Port;
        private System.Windows.Forms.ComboBox Combo_BaudRate;
        private System.Windows.Forms.ComboBox Combo_StopBits;
        private System.Windows.Forms.ComboBox Combo_DataBits;
        private System.Windows.Forms.ComboBox Combo_Parity;
        private System.Windows.Forms.CheckBox RtsCtsBox;
        private System.Windows.Forms.CheckBox DTRBox;
        private System.Windows.Forms.CheckBox XBox;
        private System.Windows.Forms.Label PortLabel;
        private System.Windows.Forms.Label BaudRateLabel;
        private System.Windows.Forms.Label DataBitLabel;
        private System.Windows.Forms.Label ParityLabel;
        private System.Windows.Forms.Label StopBitsLabel;
        private System.Windows.Forms.Button SaveBTN;
    }
}