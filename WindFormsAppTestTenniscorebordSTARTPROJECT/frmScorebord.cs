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
using System.Web;
using System.ComponentModel.Design;
using System.Runtime.ConstrainedExecution;

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
            if (cmbWaarde.SelectedIndex == -1) return; // check of er een waarde geselecteerd is

            // neem de juiste hexadecimale waarden uit de array
            char adres = (char)display[(int)numDisplaynr.Value -1];
            char value = (char)waarde[cmbWaarde.SelectedIndex];

            char[] command = { (char)0x02, (char)0x30, adres, value, (char)0x03 }; // zet alles in 1 commando
            Serial.Write(command, 0, 5); // stuur het commando
        }

        private void RdbCheckedChanged(object sender, EventArgs e)
        {
            RadioButton radio = sender as RadioButton;
            if(radio.Name == "rdbLed1" && radio.Checked) // radio button 1
            {
                char[] commandLed2 = { (char)0x02, (char)0x30, (char)0x59, (char)0x00, (char)0x03 }; // led2 uit
                Serial.Write(commandLed2, 0, 5); // stuur het commando
                Thread.Sleep(50); // wacht 50ms voor we de andere sturen
                char[] commandLed1 = { (char)0x02, (char)0x30, (char)0x58, (char)0x01, (char)0x03 }; // led1 aan
                Serial.Write(commandLed1, 0, 5); // stuur het commando
            }
            else if(radio.Name == "rdbLed2" && radio.Checked) // radio button 2
            {
                char[] commandLed1 = { (char)0x02, (char)0x30, (char)0x58, (char)0x00, (char)0x03 }; // led1 uit
                Serial.Write(commandLed1, 0, 5); // stuur het commando
                Thread.Sleep(50); // wacht 50ms voor we de andere sturen
                char[] commandLed2 = { (char)0x02, (char)0x30, (char)0x59, (char)0x01, (char)0x03 }; // led2 aan
                Serial.Write(commandLed2, 0, 5); // stuur het commando
            }
        }

        int[] ArrayWaarden = new int[10] {0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
        bool[] ArrayChanged = new bool[10] {false, false, false, false, false, false, false, false, false, false};
        private void btnStuurAlleDisplays_Click(object sender, EventArgs e)
        {
            for(int i = 0; i <= 9; i++) // loop door alle 10 de waarden in CmbChanged
            {
                if(ArrayChanged[i])
                {
                    ArrayChanged[i] = false;
                    char[] commandDisplay = { (char)0x02, (char)0x30, (char)display[i], (char)waarde[ArrayWaarden[i]], (char)0x03 };
                    Serial.Write(commandDisplay, 0, 5); // stuur commando
                    Thread.Sleep(50); // wacht 50ms
                }
            }
        }

        private void DisplaySelectedIndexChanged(object sender, EventArgs e) // verander de waarde als de index veranderd
        {
            ComboBox cmbHulp = sender as ComboBox;
            int tag = Convert.ToInt16(cmbHulp.Tag); // convert string naar 16 bit int
            ArrayWaarden[tag] = cmbHulp.SelectedIndex; // selected index voor de waarde te kunnen halen uit waarde array
            ArrayChanged[tag] = true; // bool op true zetten zodat we weten dat deze veranderd is
        }

        private void btnWisAlleDisplays_Click(object sender, EventArgs e)
        {
            for(int i = 0; i <= 9; i++)
            {
                ArrayChanged[i] = false; // reset naar false
                ArrayWaarden[i] = 0; // reset naar 0

                char[] commandDisplay = { (char)0x02, (char)0x30, (char)display[i], (char)0x45, (char)0x03 }; // wis display
                Serial.Write(commandDisplay, 0, 5);
                Thread.Sleep(50);
            }
        }
    }
}
