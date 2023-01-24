namespace WindFormsAppTestTenniscorebordSTARTPROJECT
{
    partial class frmScorebord
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
            this.btnVerbreekPoort = new System.Windows.Forms.Button();
            this.btnVerbindPoort = new System.Windows.Forms.Button();
            this.pnlScoreBord = new System.Windows.Forms.Panel();
            this.pnlBordTest = new System.Windows.Forms.Panel();
            this.cmbD0 = new System.Windows.Forms.ComboBox();
            this.cmbD9 = new System.Windows.Forms.ComboBox();
            this.cmbD8 = new System.Windows.Forms.ComboBox();
            this.cmbD7 = new System.Windows.Forms.ComboBox();
            this.cmbD6 = new System.Windows.Forms.ComboBox();
            this.cmbD5 = new System.Windows.Forms.ComboBox();
            this.cmbD4 = new System.Windows.Forms.ComboBox();
            this.cmbD3 = new System.Windows.Forms.ComboBox();
            this.cmbD2 = new System.Windows.Forms.ComboBox();
            this.cmbD1 = new System.Windows.Forms.ComboBox();
            this.btnStuurAlleDisplays = new System.Windows.Forms.Button();
            this.btnWisAlleDisplays = new System.Windows.Forms.Button();
            this.pnlDisplayTest = new System.Windows.Forms.Panel();
            this.rdbLed2 = new System.Windows.Forms.RadioButton();
            this.rdbLed1 = new System.Windows.Forms.RadioButton();
            this.btnStuurDisplay = new System.Windows.Forms.Button();
            this.numDisplaynr = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbWaarde = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnZoekPoorten = new System.Windows.Forms.Button();
            this.cmbPoort = new System.Windows.Forms.ComboBox();
            this.Serial = new System.IO.Ports.SerialPort(this.components);
            this.pnlScoreBord.SuspendLayout();
            this.pnlBordTest.SuspendLayout();
            this.pnlDisplayTest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDisplaynr)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVerbreekPoort
            // 
            this.btnVerbreekPoort.Location = new System.Drawing.Point(424, 15);
            this.btnVerbreekPoort.Margin = new System.Windows.Forms.Padding(4);
            this.btnVerbreekPoort.Name = "btnVerbreekPoort";
            this.btnVerbreekPoort.Size = new System.Drawing.Size(164, 48);
            this.btnVerbreekPoort.TabIndex = 9;
            this.btnVerbreekPoort.Text = "Verbreek Verbinding met COM-poort";
            this.btnVerbreekPoort.UseVisualStyleBackColor = true;
            this.btnVerbreekPoort.Click += new System.EventHandler(this.btnVerbreekPoort_Click);
            // 
            // btnVerbindPoort
            // 
            this.btnVerbindPoort.Location = new System.Drawing.Point(252, 15);
            this.btnVerbindPoort.Margin = new System.Windows.Forms.Padding(4);
            this.btnVerbindPoort.Name = "btnVerbindPoort";
            this.btnVerbindPoort.Size = new System.Drawing.Size(164, 48);
            this.btnVerbindPoort.TabIndex = 8;
            this.btnVerbindPoort.Text = "Maak Verbinding met COM-poort";
            this.btnVerbindPoort.UseVisualStyleBackColor = true;
            this.btnVerbindPoort.Click += new System.EventHandler(this.btnVerbindPoort_Click);
            // 
            // pnlScoreBord
            // 
            this.pnlScoreBord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlScoreBord.Controls.Add(this.pnlBordTest);
            this.pnlScoreBord.Controls.Add(this.pnlDisplayTest);
            this.pnlScoreBord.Enabled = false;
            this.pnlScoreBord.Location = new System.Drawing.Point(13, 79);
            this.pnlScoreBord.Margin = new System.Windows.Forms.Padding(4);
            this.pnlScoreBord.Name = "pnlScoreBord";
            this.pnlScoreBord.Size = new System.Drawing.Size(578, 274);
            this.pnlScoreBord.TabIndex = 7;
            // 
            // pnlBordTest
            // 
            this.pnlBordTest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBordTest.Controls.Add(this.cmbD0);
            this.pnlBordTest.Controls.Add(this.cmbD9);
            this.pnlBordTest.Controls.Add(this.cmbD8);
            this.pnlBordTest.Controls.Add(this.cmbD7);
            this.pnlBordTest.Controls.Add(this.cmbD6);
            this.pnlBordTest.Controls.Add(this.cmbD5);
            this.pnlBordTest.Controls.Add(this.cmbD4);
            this.pnlBordTest.Controls.Add(this.cmbD3);
            this.pnlBordTest.Controls.Add(this.cmbD2);
            this.pnlBordTest.Controls.Add(this.cmbD1);
            this.pnlBordTest.Controls.Add(this.btnStuurAlleDisplays);
            this.pnlBordTest.Controls.Add(this.btnWisAlleDisplays);
            this.pnlBordTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBordTest.Location = new System.Drawing.Point(0, 98);
            this.pnlBordTest.Margin = new System.Windows.Forms.Padding(4);
            this.pnlBordTest.Name = "pnlBordTest";
            this.pnlBordTest.Size = new System.Drawing.Size(576, 174);
            this.pnlBordTest.TabIndex = 1;
            // 
            // cmbD0
            // 
            this.cmbD0.FormattingEnabled = true;
            this.cmbD0.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "A",
            "wis",
            "error"});
            this.cmbD0.Location = new System.Drawing.Point(29, 63);
            this.cmbD0.Margin = new System.Windows.Forms.Padding(4);
            this.cmbD0.Name = "cmbD0";
            this.cmbD0.Size = new System.Drawing.Size(77, 24);
            this.cmbD0.TabIndex = 17;
            this.cmbD0.Tag = "0";
            this.cmbD0.SelectedIndexChanged += new System.EventHandler(this.DisplaySelectedIndexChanged);
            // 
            // cmbD9
            // 
            this.cmbD9.FormattingEnabled = true;
            this.cmbD9.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "A",
            "wis",
            "error"});
            this.cmbD9.Location = new System.Drawing.Point(464, 18);
            this.cmbD9.Margin = new System.Windows.Forms.Padding(4);
            this.cmbD9.Name = "cmbD9";
            this.cmbD9.Size = new System.Drawing.Size(77, 24);
            this.cmbD9.TabIndex = 16;
            this.cmbD9.Tag = "9";
            this.cmbD9.SelectedIndexChanged += new System.EventHandler(this.DisplaySelectedIndexChanged);
            // 
            // cmbD8
            // 
            this.cmbD8.FormattingEnabled = true;
            this.cmbD8.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "A",
            "wis",
            "error"});
            this.cmbD8.Location = new System.Drawing.Point(352, 18);
            this.cmbD8.Margin = new System.Windows.Forms.Padding(4);
            this.cmbD8.Name = "cmbD8";
            this.cmbD8.Size = new System.Drawing.Size(77, 24);
            this.cmbD8.TabIndex = 15;
            this.cmbD8.Tag = "8";
            this.cmbD8.SelectedIndexChanged += new System.EventHandler(this.DisplaySelectedIndexChanged);
            // 
            // cmbD7
            // 
            this.cmbD7.FormattingEnabled = true;
            this.cmbD7.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "A",
            "wis",
            "error"});
            this.cmbD7.Location = new System.Drawing.Point(240, 18);
            this.cmbD7.Margin = new System.Windows.Forms.Padding(4);
            this.cmbD7.Name = "cmbD7";
            this.cmbD7.Size = new System.Drawing.Size(77, 24);
            this.cmbD7.TabIndex = 14;
            this.cmbD7.Tag = "7";
            this.cmbD7.SelectedIndexChanged += new System.EventHandler(this.DisplaySelectedIndexChanged);
            // 
            // cmbD6
            // 
            this.cmbD6.FormattingEnabled = true;
            this.cmbD6.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "A",
            "wis",
            "error"});
            this.cmbD6.Location = new System.Drawing.Point(136, 18);
            this.cmbD6.Margin = new System.Windows.Forms.Padding(4);
            this.cmbD6.Name = "cmbD6";
            this.cmbD6.Size = new System.Drawing.Size(77, 24);
            this.cmbD6.TabIndex = 13;
            this.cmbD6.Tag = "6";
            this.cmbD6.SelectedIndexChanged += new System.EventHandler(this.DisplaySelectedIndexChanged);
            // 
            // cmbD5
            // 
            this.cmbD5.FormattingEnabled = true;
            this.cmbD5.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "A",
            "wis",
            "error"});
            this.cmbD5.Location = new System.Drawing.Point(29, 18);
            this.cmbD5.Margin = new System.Windows.Forms.Padding(4);
            this.cmbD5.Name = "cmbD5";
            this.cmbD5.Size = new System.Drawing.Size(77, 24);
            this.cmbD5.TabIndex = 12;
            this.cmbD5.Tag = "5";
            this.cmbD5.SelectedIndexChanged += new System.EventHandler(this.DisplaySelectedIndexChanged);
            // 
            // cmbD4
            // 
            this.cmbD4.FormattingEnabled = true;
            this.cmbD4.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "A",
            "wis",
            "error"});
            this.cmbD4.Location = new System.Drawing.Point(464, 63);
            this.cmbD4.Margin = new System.Windows.Forms.Padding(4);
            this.cmbD4.Name = "cmbD4";
            this.cmbD4.Size = new System.Drawing.Size(77, 24);
            this.cmbD4.TabIndex = 11;
            this.cmbD4.Tag = "4";
            this.cmbD4.SelectedIndexChanged += new System.EventHandler(this.DisplaySelectedIndexChanged);
            // 
            // cmbD3
            // 
            this.cmbD3.FormattingEnabled = true;
            this.cmbD3.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "A",
            "wis",
            "error"});
            this.cmbD3.Location = new System.Drawing.Point(352, 63);
            this.cmbD3.Margin = new System.Windows.Forms.Padding(4);
            this.cmbD3.Name = "cmbD3";
            this.cmbD3.Size = new System.Drawing.Size(77, 24);
            this.cmbD3.TabIndex = 10;
            this.cmbD3.Tag = "3";
            this.cmbD3.SelectedIndexChanged += new System.EventHandler(this.DisplaySelectedIndexChanged);
            // 
            // cmbD2
            // 
            this.cmbD2.FormattingEnabled = true;
            this.cmbD2.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "A",
            "wis",
            "error"});
            this.cmbD2.Location = new System.Drawing.Point(240, 63);
            this.cmbD2.Margin = new System.Windows.Forms.Padding(4);
            this.cmbD2.Name = "cmbD2";
            this.cmbD2.Size = new System.Drawing.Size(77, 24);
            this.cmbD2.TabIndex = 9;
            this.cmbD2.Tag = "2";
            this.cmbD2.SelectedIndexChanged += new System.EventHandler(this.DisplaySelectedIndexChanged);
            // 
            // cmbD1
            // 
            this.cmbD1.FormattingEnabled = true;
            this.cmbD1.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "A",
            "wis",
            "error"});
            this.cmbD1.Location = new System.Drawing.Point(136, 63);
            this.cmbD1.Margin = new System.Windows.Forms.Padding(4);
            this.cmbD1.Name = "cmbD1";
            this.cmbD1.Size = new System.Drawing.Size(77, 24);
            this.cmbD1.TabIndex = 8;
            this.cmbD1.Tag = "1";
            this.cmbD1.SelectedIndexChanged += new System.EventHandler(this.DisplaySelectedIndexChanged);
            // 
            // btnStuurAlleDisplays
            // 
            this.btnStuurAlleDisplays.Location = new System.Drawing.Point(300, 113);
            this.btnStuurAlleDisplays.Margin = new System.Windows.Forms.Padding(4);
            this.btnStuurAlleDisplays.Name = "btnStuurAlleDisplays";
            this.btnStuurAlleDisplays.Size = new System.Drawing.Size(243, 37);
            this.btnStuurAlleDisplays.TabIndex = 7;
            this.btnStuurAlleDisplays.Text = "Stuur alle Gewijzigde Displays";
            this.btnStuurAlleDisplays.UseVisualStyleBackColor = true;
            this.btnStuurAlleDisplays.Click += new System.EventHandler(this.btnStuurAlleDisplays_Click);
            // 
            // btnWisAlleDisplays
            // 
            this.btnWisAlleDisplays.Location = new System.Drawing.Point(28, 113);
            this.btnWisAlleDisplays.Margin = new System.Windows.Forms.Padding(4);
            this.btnWisAlleDisplays.Name = "btnWisAlleDisplays";
            this.btnWisAlleDisplays.Size = new System.Drawing.Size(243, 37);
            this.btnWisAlleDisplays.TabIndex = 6;
            this.btnWisAlleDisplays.Text = "Wis alle Displays";
            this.btnWisAlleDisplays.UseVisualStyleBackColor = true;
            this.btnWisAlleDisplays.Click += new System.EventHandler(this.btnWisAlleDisplays_Click);
            // 
            // pnlDisplayTest
            // 
            this.pnlDisplayTest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDisplayTest.Controls.Add(this.rdbLed2);
            this.pnlDisplayTest.Controls.Add(this.rdbLed1);
            this.pnlDisplayTest.Controls.Add(this.btnStuurDisplay);
            this.pnlDisplayTest.Controls.Add(this.numDisplaynr);
            this.pnlDisplayTest.Controls.Add(this.label2);
            this.pnlDisplayTest.Controls.Add(this.cmbWaarde);
            this.pnlDisplayTest.Controls.Add(this.label1);
            this.pnlDisplayTest.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDisplayTest.Location = new System.Drawing.Point(0, 0);
            this.pnlDisplayTest.Margin = new System.Windows.Forms.Padding(4);
            this.pnlDisplayTest.Name = "pnlDisplayTest";
            this.pnlDisplayTest.Size = new System.Drawing.Size(576, 98);
            this.pnlDisplayTest.TabIndex = 0;
            // 
            // rdbLed2
            // 
            this.rdbLed2.AutoSize = true;
            this.rdbLed2.Location = new System.Drawing.Point(477, 55);
            this.rdbLed2.Margin = new System.Windows.Forms.Padding(4);
            this.rdbLed2.Name = "rdbLed2";
            this.rdbLed2.Size = new System.Drawing.Size(58, 20);
            this.rdbLed2.TabIndex = 7;
            this.rdbLed2.TabStop = true;
            this.rdbLed2.Tag = "2";
            this.rdbLed2.Text = "Led2";
            this.rdbLed2.UseVisualStyleBackColor = true;
            this.rdbLed2.CheckedChanged += new System.EventHandler(this.RdbCheckedChanged);
            // 
            // rdbLed1
            // 
            this.rdbLed1.AutoSize = true;
            this.rdbLed1.Location = new System.Drawing.Point(477, 16);
            this.rdbLed1.Margin = new System.Windows.Forms.Padding(4);
            this.rdbLed1.Name = "rdbLed1";
            this.rdbLed1.Size = new System.Drawing.Size(58, 20);
            this.rdbLed1.TabIndex = 6;
            this.rdbLed1.TabStop = true;
            this.rdbLed1.Tag = "µ1";
            this.rdbLed1.Text = "Led1";
            this.rdbLed1.UseVisualStyleBackColor = true;
            this.rdbLed1.CheckedChanged += new System.EventHandler(this.RdbCheckedChanged);
            // 
            // btnStuurDisplay
            // 
            this.btnStuurDisplay.Location = new System.Drawing.Point(319, 27);
            this.btnStuurDisplay.Margin = new System.Windows.Forms.Padding(4);
            this.btnStuurDisplay.Name = "btnStuurDisplay";
            this.btnStuurDisplay.Size = new System.Drawing.Size(134, 37);
            this.btnStuurDisplay.TabIndex = 5;
            this.btnStuurDisplay.Text = "Stuur Display aan";
            this.btnStuurDisplay.UseVisualStyleBackColor = true;
            this.btnStuurDisplay.Click += new System.EventHandler(this.btnStuurDisplay_Click);
            // 
            // numDisplaynr
            // 
            this.numDisplaynr.Location = new System.Drawing.Point(135, 36);
            this.numDisplaynr.Margin = new System.Windows.Forms.Padding(4);
            this.numDisplaynr.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numDisplaynr.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDisplaynr.Name = "numDisplaynr";
            this.numDisplaynr.Size = new System.Drawing.Size(49, 22);
            this.numDisplaynr.TabIndex = 4;
            this.numDisplaynr.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Waarde :";
            // 
            // cmbWaarde
            // 
            this.cmbWaarde.FormattingEnabled = true;
            this.cmbWaarde.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "A",
            "wis",
            "error"});
            this.cmbWaarde.Location = new System.Drawing.Point(247, 34);
            this.cmbWaarde.Margin = new System.Windows.Forms.Padding(4);
            this.cmbWaarde.Name = "cmbWaarde";
            this.cmbWaarde.Size = new System.Drawing.Size(64, 24);
            this.cmbWaarde.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Displaynummer :";
            // 
            // btnZoekPoorten
            // 
            this.btnZoekPoorten.Location = new System.Drawing.Point(13, 15);
            this.btnZoekPoorten.Margin = new System.Windows.Forms.Padding(4);
            this.btnZoekPoorten.Name = "btnZoekPoorten";
            this.btnZoekPoorten.Size = new System.Drawing.Size(120, 48);
            this.btnZoekPoorten.TabIndex = 6;
            this.btnZoekPoorten.Text = "Zoek alle COM-poorten";
            this.btnZoekPoorten.UseVisualStyleBackColor = true;
            this.btnZoekPoorten.Click += new System.EventHandler(this.btnZoekPoorten_Click);
            // 
            // cmbPoort
            // 
            this.cmbPoort.FormattingEnabled = true;
            this.cmbPoort.Location = new System.Drawing.Point(141, 27);
            this.cmbPoort.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPoort.Name = "cmbPoort";
            this.cmbPoort.Size = new System.Drawing.Size(101, 24);
            this.cmbPoort.TabIndex = 5;
            this.cmbPoort.SelectedIndexChanged += new System.EventHandler(this.cmbPoort_SelectedIndexChanged);
            // 
            // Serial
            // 
            this.Serial.BaudRate = 115200;
            // 
            // frmScorebord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 366);
            this.Controls.Add(this.btnVerbreekPoort);
            this.Controls.Add(this.btnVerbindPoort);
            this.Controls.Add(this.pnlScoreBord);
            this.Controls.Add(this.btnZoekPoorten);
            this.Controls.Add(this.cmbPoort);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmScorebord";
            this.Text = "Tennisscorebord testen";
            this.pnlScoreBord.ResumeLayout(false);
            this.pnlBordTest.ResumeLayout(false);
            this.pnlDisplayTest.ResumeLayout(false);
            this.pnlDisplayTest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDisplaynr)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVerbreekPoort;
        private System.Windows.Forms.Button btnVerbindPoort;
        private System.Windows.Forms.Panel pnlScoreBord;
        private System.Windows.Forms.Panel pnlBordTest;
        private System.Windows.Forms.ComboBox cmbD0;
        private System.Windows.Forms.ComboBox cmbD9;
        private System.Windows.Forms.ComboBox cmbD8;
        private System.Windows.Forms.ComboBox cmbD7;
        private System.Windows.Forms.ComboBox cmbD6;
        private System.Windows.Forms.ComboBox cmbD5;
        private System.Windows.Forms.ComboBox cmbD4;
        private System.Windows.Forms.ComboBox cmbD3;
        private System.Windows.Forms.ComboBox cmbD2;
        private System.Windows.Forms.ComboBox cmbD1;
        private System.Windows.Forms.Button btnStuurAlleDisplays;
        private System.Windows.Forms.Button btnWisAlleDisplays;
        private System.Windows.Forms.Panel pnlDisplayTest;
        private System.Windows.Forms.RadioButton rdbLed2;
        private System.Windows.Forms.RadioButton rdbLed1;
        private System.Windows.Forms.Button btnStuurDisplay;
        private System.Windows.Forms.NumericUpDown numDisplaynr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbWaarde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnZoekPoorten;
        private System.Windows.Forms.ComboBox cmbPoort;
        private System.IO.Ports.SerialPort Serial;
    }
}

