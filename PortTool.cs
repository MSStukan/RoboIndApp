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
    public partial class PortTool : Form
    {
        string conf = "Ustawienia portu:";
        string conf2 = "Komunikat";
        private MainWind menu;
        public PortTool(MainWind handler)
        {
            InitializeComponent();
           
            menu = handler;
            #region AddSettings
            string[] portlist;
            string[] paritieslist;
            portlist = SerialPort.GetPortNames();
            paritieslist = Enum.GetNames(typeof(Parity));
            foreach (String ports in portlist) this.Combo_Port.Items.Add(ports); // Porty

            foreach (String parities in paritieslist) this.Combo_Parity.Items.Add(parities); // Parzystość
            Combo_BaudRate.Text = menu.serialPort1.BaudRate.ToString(); // Prędkość transmisji
            Combo_BaudRate.Items.Add("300");
            Combo_BaudRate.Items.Add("1200");
            Combo_BaudRate.Items.Add("2400");
            Combo_BaudRate.Items.Add("4800");
            Combo_BaudRate.Items.Add("9600"); // Dodaj wartości do listy / Baud
            Combo_BaudRate.Items.Add("14400");
            Combo_BaudRate.Items.Add("19200");
            Combo_BaudRate.Items.Add("28800");
            Combo_BaudRate.Items.Add("38400");
            Combo_BaudRate.Items.Add("57600");
            Combo_BaudRate.Items.Add("115200");
            Combo_BaudRate.Items.Add("230400");
            Combo_BaudRate.Text = Combo_BaudRate.Items[4].ToString();

            Combo_DataBits.Items.Add("5"); // Dodaj wartości do listy /bity danych
            Combo_DataBits.Items.Add("6");
            Combo_DataBits.Items.Add("7");
            Combo_DataBits.Items.Add("8");
            Combo_DataBits.Text = Combo_DataBits.Items[3].ToString();

            Combo_StopBits.Items.Add("1"); // Dodaj wartości do listy /bity stopu
            Combo_StopBits.Items.Add("1,5");
            Combo_StopBits.Items.Add("2");
            Combo_StopBits.Text = Combo_StopBits.Items[0].ToString();
            #endregion
            #region LastSettings
            if (portlist.Contains(Properties.Settings.Default.Port)) // Jeśli lista zawiera default
            {
                Combo_Port.SelectedItem = Properties.Settings.Default.Port;

            }
            if (paritieslist.Contains(Properties.Settings.Default.Parity))
            {
                Combo_Parity.SelectedItem = Properties.Settings.Default.Parity;
            }

            Combo_BaudRate.SelectedItem = Properties.Settings.Default.Baud;   // Przypisz wybrane jako default
            Combo_DataBits.SelectedItem = Properties.Settings.Default.DatasBits;
            Combo_StopBits.SelectedItem = Properties.Settings.Default.StopBits;

            if (Properties.Settings.Default.DtrState == "True") DTRBox.Checked = true; else DTRBox.Checked = false;
            if (Properties.Settings.Default.RtsState == "True") RtsCtsBox.Checked = true; else RtsCtsBox.Checked = false;
            if (Properties.Settings.Default.XBoxState == "True") XBox.Checked = true; else XBox.Checked = false;
            #endregion
        }

        #region SaveSettings
        private void SaveBTN_Click(object sender, EventArgs e)
        {
            if (ValidatePortData())
            {
                if (!menu.serialPort1.IsOpen)
                {
                    menu.serialPort1.PortName = Convert.ToString(Combo_Port.Text);
                    menu.serialPort1.BaudRate = Convert.ToInt32(Combo_BaudRate.Text);
                    menu.serialPort1.DataBits = Convert.ToInt16(Combo_DataBits.Text);
                    menu.serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), Combo_StopBits.Text);
                    menu.serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), Combo_Parity.Text);
                    menu.serialPort1.DtrEnable = DTRBox.Checked;
                    menu.serialPort1.RtsEnable = RtsCtsBox.Checked;
                    if(Properties.Settings.Default.XBoxState == "True") menu.serialPort1.Handshake = (Handshake)1; else menu.serialPort1.Handshake = (Handshake)0;

                    Properties.Settings.Default.Port = Combo_Port.SelectedItem.ToString();
                    Properties.Settings.Default.Parity = Combo_Parity.SelectedItem.ToString();
                    Properties.Settings.Default.Baud = Combo_BaudRate.SelectedItem.ToString(); // Przypisz default do combo
                    Properties.Settings.Default.DatasBits = Combo_DataBits.SelectedItem.ToString();
                    Properties.Settings.Default.StopBits = Combo_StopBits.SelectedItem.ToString();

                    Properties.Settings.Default.DtrState = DTRBox.Checked.ToString();
                    Properties.Settings.Default.RtsState = RtsCtsBox.Checked.ToString();
                    Properties.Settings.Default.XBoxState = XBox.Checked.ToString();


                    Properties.Settings.Default.Save(); // Zapisz jako default

                    if (MessageBox.Show(conf + Environment.NewLine + Environment.NewLine + "Port: " + Combo_Port.Text + Environment.NewLine + "Prędkość transmisji: " + Combo_BaudRate.Text + " b/s" +
                        Environment.NewLine + "Bity danych: " + Combo_DataBits.Text + Environment.NewLine + "Bity stopu: " + Combo_StopBits.Text +
                        Environment.NewLine + "Parzystość: " + Combo_Parity.Text + Environment.NewLine + "RTS: " + RtsCtsBox.Checked.ToString() + 
                        Environment.NewLine + "Handshake: " + XBox.Checked.ToString() + Environment.NewLine + "DTR: " + DTRBox.Checked.ToString()
                        , conf2, MessageBoxButtons.OK, MessageBoxIcon.Asterisk) == DialogResult.OK) ; // Komunikat ustawień
                }
                Close(); // Jak ValidatePortData(), to zamknij

            }
        }

        private bool ValidatePortData() // Walidacja ; Unikanie białych znaków
        {
            return !string.IsNullOrWhiteSpace(Combo_Port.Text) &&
                !string.IsNullOrWhiteSpace(Combo_BaudRate.Text) &&
                !string.IsNullOrWhiteSpace(Combo_DataBits.Text) &&
                !string.IsNullOrWhiteSpace(Combo_StopBits.Text) &&
                !string.IsNullOrWhiteSpace(Combo_Parity.Text);
        }
        #endregion

        #region boxes dtr rts x(handshake) // To delete ?? Its Unnecessery if it is in save button
        private void DTRBox_CheckedChanged(object sender, EventArgs e)
        {
            if (DTRBox.Checked)
            {
                menu.serialPort1.DtrEnable = true;
                Properties.Settings.Default.DtrState = DTRBox.Checked.ToString();
            }
            else
            {
                menu.serialPort1.DtrEnable = false;
                Properties.Settings.Default.DtrState = DTRBox.Checked.ToString();
            }
            Properties.Settings.Default.Save();
        }

        private void RtsCtsBox_CheckedChanged(object sender, EventArgs e)
        {
            if (RtsCtsBox.Checked)
            {
                menu.serialPort1.RtsEnable = true;
                Properties.Settings.Default.RtsState = RtsCtsBox.Checked.ToString();
            }
            else
            {
                menu.serialPort1.RtsEnable = false;
                Properties.Settings.Default.RtsState = RtsCtsBox.Checked.ToString();
            }
            Properties.Settings.Default.Save();
        }

        private void XBox_CheckedChanged(object sender, EventArgs e)
        {
            if (XBox.Checked)
            {
                menu.serialPort1.Handshake = (Handshake)1;
                Properties.Settings.Default.XBoxState = XBox.Checked.ToString();
            }
            else
            {
                menu.serialPort1.Handshake = (Handshake)0;
                Properties.Settings.Default.XBoxState = XBox.Checked.ToString();
            }
            Properties.Settings.Default.Save();
        }
        #endregion
    }
}
