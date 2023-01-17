using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Threading; //  om sleep te kunnen gebruiken

namespace WindFormsAppTestTenniscorebordSTARTPROJECT
{
    public partial class frmScorebord : Form
    {
        //arrays om één display aan te sturen
        byte[] display = new byte[10] { 0x30, 0x31, 0x32, 0x33, 0x34, 0x35, 0x36, 0x37, 0x38, 0x39 }; // DISPLAYNUMMERS in juiste volgorde
        byte[] waarde = new byte[13] { 0x30, 0x31, 0x32, 0x33, 0x34, 0x35, 0x36, 0x37, 0x38, 0x39, 0x41, 0x45, 0xFF }; // ALLE MOGELIJKE WAARDEN in zelfde volgorde als in comboboxen
        byte[] stuurCode = new byte[5] { 0x02, 0x30, 0x30, 0x30, 0x03 }; //{STX, CMD, DISPLAYNR, DISPLAYWAARDE, ETX}
        public frmScorebord()
        {
            InitializeComponent();
            // voeg alle waarden toe aan de combobox
            for(int i = 0; i < waarde.Length; i++)
            {
                cmbWaarde.Items.Add(waarde[i]);
            }
        }

        private void btnZoekPoorten_Click(object sender, EventArgs e)
        {
            cmbPoort.Items.Clear(); // verwijder alle com poorten
            string[] ports = System.IO.Ports.SerialPort.GetPortNames();
            foreach (string port in ports)
                cmbPoort.Items.Add(port);
        }

        string poort = "";
        private void cmbPoort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPoort.SelectedIndex == -1) return;
            poort = cmbPoort.SelectedItem.ToString();
        }

        private void btnVerbindPoort_Click(object sender, EventArgs e)
        {
            if (poort == Serial.PortName) return; // dezelfde poort
            Serial.Close();
            try
            {
                this.Text = "Verbinden...";
                Serial.PortName = poort;
                Serial.Open();
                if (Serial.IsOpen)
                {
                    this.Text = "Nieuwe poort op: " + poort;
                    pnlScoreBord.Enabled = true;
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnVerbreekPoort_Click(object sender, EventArgs e)
        {
            try
            {
                this.Text = "Verbreken...";
                if (Serial.IsOpen)
                {
                    Serial.Close();
                    Serial.PortName = "COM"; // portname veranderen
                    this.Text = "Verbroken";
                    pnlScoreBord.Enabled = false;
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        private void btnStuurDisplay_Click(object sender, EventArgs e)
        {
            if (cmbWaarde.SelectedIndex == -1) return;
            string begin = "02";
            string mode = "30"; // enkelvoudige display
            string adres = display[(int)numDisplaynr.Value].ToString("X"); // voeg scherm toe aan het commando
            string value = waarde[(int)cmbWaarde.SelectedIndex].ToString("X"); // voeg waarde toe
            string eind= "03"; // eind

            // hier
            Serial.Write(commandos, 0, 5);
        }
    }
}
