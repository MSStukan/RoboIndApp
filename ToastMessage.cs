using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoboAppV01
{
    public partial class ToastMessage : Form
    {
        public ToastMessage(String message, Color bgColor)
        {
            InitializeComponent();

            this.BackColor = bgColor;
            this.ToastMes.Text = message;
        }

        private void ToastMessage_Load(object sender, EventArgs e)
        {
            TimerCloseToast.Start();
        }
        private void TimerCloseToast_Tick(object sender, EventArgs e)
        {
            Close();
        }

    }
}
