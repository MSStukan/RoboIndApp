using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.IO;
using System.Windows.Forms;

namespace RoboAppV01
{

    public partial class MainWind : Form
    {

        public MainWind()
        {
            InitializeComponent();
            CommListInit();
            AngVelTextLebel.Text = "" + AngVeloSlider.Value + " %";
            RotAngTextLebel.Text = "" + RotateAngSlider.Value + "\u00b0";
        }

        #region   auxiliary  function
        private void exitAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult Dr = MessageBox.Show("Are you sure to exit", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Dr == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void portToolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PortTool PT = new PortTool(this);
            PT.ShowDialog();
        }

        private void EnDisAbleJogBox(bool val)
        {
            BoxJogOper.Enabled = val;
            SendComBTN.Enabled = val;

        }
        private void showToast(String message, Color bgColor)
        {
            ToastMessage toast = new ToastMessage(message, bgColor);
            toast.ShowDialog();

        }
        #endregion

        #region Port_Controls
        private void PortOpenBTN_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Open();
                    RadioBTN.Checked = true;
                    RadioBTN.Text = "Port Open";
                    PortOpenBTN.Enabled = false;
                    PortCloseBTN.Enabled = true;
                    EnDisAbleJogBox(true);
                    // showToast("Port open", Color.FromArgb(160, 160, 160));
                    //  warningBox.Text = "";
                }
                catch
                {
                    PortOpenBTN.Enabled = true;
                    PortCloseBTN.Enabled = false;
                    RadioBTN.Text = "Port Close";
                    showToast("Port opening failed", Color.FromArgb(160, 160, 160));
                }
            }
            else {

            } //warningBox.Text = "Port otwarty";
        }

        private void PortCloseBTN_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Close();
                    RadioBTN.Checked = false;
                    RadioBTN.Text = "Port Close";
                    PortOpenBTN.Enabled = true;
                    PortCloseBTN.Enabled = false;
                    EnDisAbleJogBox(false);
                    //warningBox.Text = "";
                }
                catch
                {
                    RadioBTN.Text = "Port did not close properly";
                    //  warningBox.Text = "Błąd podczas zamykania portu";
                }
            }
        }

        #endregion

        #region Jog Operation buttons
        bool SpeadSeted = false;

        private void RotateAngSlider_Scroll(object sender, EventArgs e)
        {
            RotAngTextLebel.Text = "" + RotateAngSlider.Value + "\u00b0";
        }

        private void AngVeloSlider_Scroll_1(object sender, EventArgs e)
        {
            AngVelTextLebel.Text = "" + AngVeloSlider.Value + " %";

        }
        private void SetSpeedBTN_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                SendCommand("SP " + AngVeloSlider.Value);
                SpeadSeted = true;
            }
        }

        private void BaseDecrBTN_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen & SpeadSeted)
            {
                SendCommand("DJ 1," + -RotateAngSlider.Value);
            }
            else if (serialPort1.IsOpen & !SpeadSeted)
            {
                MessageBox.Show("Firstly you must set the velocity by draging slider!");
            }
        }

        private void BaseIncrBTN_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen & SpeadSeted)
            {
                SendCommand("DJ 1," + RotateAngSlider.Value);
            }
            else if (serialPort1.IsOpen & !SpeadSeted)
            {
                MessageBox.Show("Firstly you must set the velocity by draging slider!");
            }
        }

        private void WaistDecrBTN_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen & SpeadSeted)
            {
                SendCommand("DJ 2," + -RotateAngSlider.Value);
            }
            else if (serialPort1.IsOpen & !SpeadSeted)
            {
                MessageBox.Show("Firstly you must set the velocity by draging slider!");
            }
        }

        private void WaistIncrBTN_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen & SpeadSeted)
            {
                SendCommand("DJ 2," + RotateAngSlider.Value);
            }
            else if (serialPort1.IsOpen & !SpeadSeted)
            {
                MessageBox.Show("Firstly you must set the velocity by draging slider!");
            }
        }

        private void UppArmDecrBTN_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen & SpeadSeted)
            {
                SendCommand("DJ 3," + -RotateAngSlider.Value);
            }
            else if (serialPort1.IsOpen & !SpeadSeted)
            {
                MessageBox.Show("Firstly you must set the velocity by draging slider!");
            }
        }

        private void UppArmIncrBTN_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen & SpeadSeted)
            {
                SendCommand("DJ 3," + RotateAngSlider.Value);
            }
            else if (serialPort1.IsOpen & !SpeadSeted)
            {
                MessageBox.Show("Firstly you must set the velocity by draging slider!");
            }
        }

        private void TwistDecrBTN_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen & SpeadSeted)
            {
                SendCommand("DJ 4," + -RotateAngSlider.Value);
            }
            else if (serialPort1.IsOpen & !SpeadSeted)
            {
                MessageBox.Show("Firstly you must set the velocity by draging slider!");
            }
        }

        private void TwistIncrBTN_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen & SpeadSeted)
            {
                SendCommand("DJ 4," + RotateAngSlider.Value);
            }
            else if (serialPort1.IsOpen & !SpeadSeted)
            {
                MessageBox.Show("Firstly you must set the velocity by draging slider!");
            }
        }

        private void LowArmDecrBTN_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen & SpeadSeted)
            {
                SendCommand("DJ 5," + -RotateAngSlider.Value);
            }
            else if (serialPort1.IsOpen & !SpeadSeted)
            {
                MessageBox.Show("Firstly you must set the velocity by draging slider!");
            }
        }

        private void LowArmIncrBTN_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen & SpeadSeted)
            {
                SendCommand("DJ 5," + RotateAngSlider.Value);
            }
            else if (serialPort1.IsOpen & !SpeadSeted)
            {
                MessageBox.Show("Firstly you must set the velocity by draging slider!");
            }
        }

        private void WristDecrBTN_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen & SpeadSeted)
            {
                SendCommand("DJ 6," + -RotateAngSlider.Value);
            }
            else if (serialPort1.IsOpen & !SpeadSeted)
            {
                MessageBox.Show("Firstly you must set the velocity by draging slider!");
            }
        }

        private void WristIncrBTN_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen & SpeadSeted)
            {
                SendCommand("DJ 6," + RotateAngSlider.Value);
            }
            else if (serialPort1.IsOpen & !SpeadSeted)
            {
                MessageBox.Show("Firstly you must set the velocity by draging slider!");
            }
        }

        private void GripDecrBTN_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen & SpeadSeted)
            {
                SendCommand("GC");
            }
        }

        private void GripIncrBTN_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen & SpeadSeted)
            {
                SendCommand("GO");
            }
        }
        #endregion

        #region Show messeges send recive 
        string indata;
        private void SendCommand(string command)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Write(command + "\r");
                if (!ShowSend.Checked)
                {
                    AddMessageInternal(command + "\r", Color.Gray);
                }
            }
        }

        private void Send_MultiCommand()
        {
            if (serialPort1.IsOpen)
            {
                
                for(int iter=0; iter < CommandBox.Lines.Count(); iter ++)
                {
                    serialPort1.Write(CommandBox.Lines[iter] + "\r");
                    if (!ShowSend.Checked)
                    {
                         AddMessageInternal(CommandBox.Lines[iter] + "\r", Color.Gray);
                    }
                }
            }
        }


        public void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            indata = serialPort1.ReadExisting();
            this.Invoke(new EventHandler(ShowData));
        }

        private void ShowData(object sender, EventArgs e)
        {
            
            AddMessageInternal(indata, Color.Empty);
        }
        private void AddMessageInternal(string message, Color color)
        {
            if (color != Color.Empty)
            {
                MessegesBox.SelectionColor = color;
            }
            MessegesBox.SelectedText = DateTime.Now.ToString("HH:mm:ss") + "   " + message;

            MessegesBox.SelectionStart = MessegesBox.Text.Length;
            MessegesBox.ScrollToCaret();
        }
        #endregion

        #region text boxes service
        private void MessegesClearBTN_Click(object sender, EventArgs e)
        {
            MessegesBox.Text = "";
        }
        private void SeComClearBTN_Click(object sender, EventArgs e)
        {
            CommandBox.Text = "";
        }

        private void ComList_DoubleClick1(object sender, System.EventArgs e)
        {
            if (ComList.SelectedItem != null)

                if (ComList.SelectedItem.ToString().Length != 0)
                {
                    int LineNumb = (CommandBox.Lines.Count() + 1) * 10;
                    if (CommandBox.TextLength == 0)
                    {
                        CommandBox.Text += LineNumb.ToString() + " " + Commends[ComList.SelectedIndex];
                    }
                    else
                    {
                        CommandBox.Text += "\r" + LineNumb.ToString() + " " + Commends[ComList.SelectedIndex];
                    }
                }
        }

        private void SendComBTN_Click(object sender, EventArgs e)
        {
            Send_MultiCommand();
        }
        #endregion
        string[] Commends = new string[26]{
            "SP val","MO pos, O/C","MS pos, O/C","MR p1,p2,p3","MA p1, p2",
            "MC pStart, pEnd","MJ j1, j2, j3, j4, j5, j6","MP .....","MT 1, x","MTS 1, x",
            "Empty ...","DJ ax, val","DS x, y, z","DW x, y, z","PD 0,0,0,0,0,0,0,0,1650,0",
            "PC v","PL old, new","PR v","HE v","WH",
            "Empty ...","GO","GC","GP vF, vF, tim","TI va","Maybe in futre"
        };
        private void CommListInit()
        {
            ComList.Items.Add("SP: (SP val) speed");
            ComList.Items.Add("MO: (MO pos x,O/Cgrp) axial, grip not neces");
            ComList.Items.Add("MS: (MS pos x,O/Cgrp) linear");
            ComList.Items.Add("MR:(MR 1poi,2poi,3poi) draw arc");
            ComList.Items.Add("MA: (MA 1pot,2pot) linera from 1 to 2");
            ComList.Items.Add("MC: (");
            ComList.Items.Add("MJ: (");
            ComList.Items.Add("MP: (");
            ComList.Items.Add("MT: (");
            ComList.Items.Add("MTS: (");
            ComList.Items.Add("        Move and Position |/");
            ComList.Items.Add("DJ: (DJ joint, val) axial");
            ComList.Items.Add("DS: (DS x, y, z) linear");
            ComList.Items.Add("DW: (DW x, y, z) axial");
            ComList.Items.Add("PD: (PD 10p) position define...");
            ComList.Items.Add("PC: (PC val) clear position");
            ComList.Items.Add("PL: (PL old, new) load new pos in old");
            ComList.Items.Add("PR: (PR val) Position read");
            ComList.Items.Add("HE: (HE val) Write act pos in place");
            ComList.Items.Add("WH: (WH) Where are you!?");
            ComList.Items.Add("         Grip  |/");
            ComList.Items.Add("GO: (GO) grip open");
            ComList.Items.Add("GC: (GC) grip close");
            ComList.Items.Add("GP: (GP valForc, valForc, time");
            ComList.Items.Add("TI: (TI valTime) Delay");
            ComList.Items.Add("      ect.. in future");
        }
       
        
    }
}
