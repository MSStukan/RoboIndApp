
namespace RoboAppV01
{
    partial class ToastMessage
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
            this.TimerCloseToast = new System.Windows.Forms.Timer(this.components);
            this.ToastMes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TimerCloseToast
            // 
            this.TimerCloseToast.Interval = 1500;
            this.TimerCloseToast.Tick += new System.EventHandler(this.TimerCloseToast_Tick);
            // 
            // ToastMes
            // 
            this.ToastMes.AutoSize = true;
            this.ToastMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ToastMes.Location = new System.Drawing.Point(12, 9);
            this.ToastMes.Name = "ToastMes";
            this.ToastMes.Size = new System.Drawing.Size(60, 24);
            this.ToastMes.TabIndex = 0;
            this.ToastMes.Text = "label1";
            this.ToastMes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ToastMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 44);
            this.Controls.Add(this.ToastMes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ToastMessage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ToastMessage";
            this.Load += new System.EventHandler(this.ToastMessage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer TimerCloseToast;
        private System.Windows.Forms.Label ToastMes;
    }
}