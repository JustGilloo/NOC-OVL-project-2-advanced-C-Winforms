namespace WinFormsApp2
{
    partial class Super_Admin_Screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Super_Admin_Screen));
            groupBox1 = new GroupBox();
            cbJSONEncoderen = new CheckBox();
            cbJSONLezen = new CheckBox();
            cbJSONAanmaken = new CheckBox();
            cbJSONBewerken = new CheckBox();
            cbTXTEncoderen = new CheckBox();
            cbTXTLezen = new CheckBox();
            cbTXTAanmaken = new CheckBox();
            cbTXTBewerken = new CheckBox();
            cbXMLEncoderen = new CheckBox();
            cbXMLLezen = new CheckBox();
            cbXMLAanmaken = new CheckBox();
            cbXMLBewerken = new CheckBox();
            groupBox2 = new GroupBox();
            cmbAfdelingen = new ComboBox();
            label6 = new Label();
            btnGebruikerAanmaken = new Button();
            cmbGebruikersRol = new ComboBox();
            txtGebruikerPaswoord = new TextBox();
            txtGebruikerVoornaam = new TextBox();
            txtGebruikerNaam = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            btnAanmakenRol = new Button();
            textBox1 = new TextBox();
            btnCheckAll = new Button();
            btnUncheckAll = new Button();
            button2 = new Button();
            label7 = new Label();
            txtAanmakenAfdeling = new TextBox();
            btnAanmakenAfdeling = new Button();
            label8 = new Label();
            txtAfdelingBeschrijving = new TextBox();
            groupBox3 = new GroupBox();
            txtSleutel = new TextBox();
            txtPad = new TextBox();
            btnDisplayKeys = new Button();
            btnRenewKey = new Button();
            btnUitloggen = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbJSONEncoderen);
            groupBox1.Controls.Add(cbJSONLezen);
            groupBox1.Controls.Add(cbJSONAanmaken);
            groupBox1.Controls.Add(cbJSONBewerken);
            groupBox1.Controls.Add(cbTXTEncoderen);
            groupBox1.Controls.Add(cbTXTLezen);
            groupBox1.Controls.Add(cbTXTAanmaken);
            groupBox1.Controls.Add(cbTXTBewerken);
            groupBox1.Controls.Add(cbXMLEncoderen);
            groupBox1.Controls.Add(cbXMLLezen);
            groupBox1.Controls.Add(cbXMLAanmaken);
            groupBox1.Controls.Add(cbXMLBewerken);
            groupBox1.Location = new Point(50, 299);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(302, 452);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Rechten";
            // 
            // cbJSONEncoderen
            // 
            cbJSONEncoderen.AutoSize = true;
            cbJSONEncoderen.Location = new Point(7, 403);
            cbJSONEncoderen.Margin = new Padding(3, 4, 3, 4);
            cbJSONEncoderen.Name = "cbJSONEncoderen";
            cbJSONEncoderen.Size = new Size(169, 24);
            cbJSONEncoderen.TabIndex = 11;
            cbJSONEncoderen.Text = "Kan JSON Encoderen";
            cbJSONEncoderen.UseVisualStyleBackColor = true;
            // 
            // cbJSONLezen
            // 
            cbJSONLezen.AutoSize = true;
            cbJSONLezen.Location = new Point(7, 369);
            cbJSONLezen.Margin = new Padding(3, 4, 3, 4);
            cbJSONLezen.Name = "cbJSONLezen";
            cbJSONLezen.Size = new Size(137, 24);
            cbJSONLezen.TabIndex = 10;
            cbJSONLezen.Text = "Kan JSON Lezen";
            cbJSONLezen.UseVisualStyleBackColor = true;
            // 
            // cbJSONAanmaken
            // 
            cbJSONAanmaken.AutoSize = true;
            cbJSONAanmaken.Location = new Point(7, 336);
            cbJSONAanmaken.Margin = new Padding(3, 4, 3, 4);
            cbJSONAanmaken.Name = "cbJSONAanmaken";
            cbJSONAanmaken.Size = new Size(169, 24);
            cbJSONAanmaken.TabIndex = 9;
            cbJSONAanmaken.Text = "Kan JSON Aanmaken";
            cbJSONAanmaken.UseVisualStyleBackColor = true;
            // 
            // cbJSONBewerken
            // 
            cbJSONBewerken.AutoSize = true;
            cbJSONBewerken.Location = new Point(7, 303);
            cbJSONBewerken.Margin = new Padding(3, 4, 3, 4);
            cbJSONBewerken.Name = "cbJSONBewerken";
            cbJSONBewerken.Size = new Size(163, 24);
            cbJSONBewerken.TabIndex = 8;
            cbJSONBewerken.Text = "Kan JSON Bewerken";
            cbJSONBewerken.UseVisualStyleBackColor = true;
            // 
            // cbTXTEncoderen
            // 
            cbTXTEncoderen.AutoSize = true;
            cbTXTEncoderen.Location = new Point(7, 269);
            cbTXTEncoderen.Margin = new Padding(3, 4, 3, 4);
            cbTXTEncoderen.Name = "cbTXTEncoderen";
            cbTXTEncoderen.Size = new Size(159, 24);
            cbTXTEncoderen.TabIndex = 7;
            cbTXTEncoderen.Text = "Kan TXT Encoderen";
            cbTXTEncoderen.UseVisualStyleBackColor = true;
            // 
            // cbTXTLezen
            // 
            cbTXTLezen.AutoSize = true;
            cbTXTLezen.Location = new Point(7, 236);
            cbTXTLezen.Margin = new Padding(3, 4, 3, 4);
            cbTXTLezen.Name = "cbTXTLezen";
            cbTXTLezen.Size = new Size(127, 24);
            cbTXTLezen.TabIndex = 6;
            cbTXTLezen.Text = "Kan TXT Lezen";
            cbTXTLezen.UseVisualStyleBackColor = true;
            // 
            // cbTXTAanmaken
            // 
            cbTXTAanmaken.AutoSize = true;
            cbTXTAanmaken.Location = new Point(7, 203);
            cbTXTAanmaken.Margin = new Padding(3, 4, 3, 4);
            cbTXTAanmaken.Name = "cbTXTAanmaken";
            cbTXTAanmaken.Size = new Size(159, 24);
            cbTXTAanmaken.TabIndex = 5;
            cbTXTAanmaken.Text = "Kan TXT Aanmaken";
            cbTXTAanmaken.UseVisualStyleBackColor = true;
            // 
            // cbTXTBewerken
            // 
            cbTXTBewerken.AutoSize = true;
            cbTXTBewerken.Location = new Point(7, 169);
            cbTXTBewerken.Margin = new Padding(3, 4, 3, 4);
            cbTXTBewerken.Name = "cbTXTBewerken";
            cbTXTBewerken.Size = new Size(153, 24);
            cbTXTBewerken.TabIndex = 4;
            cbTXTBewerken.Text = "Kan TXT Bewerken";
            cbTXTBewerken.UseVisualStyleBackColor = true;
            // 
            // cbXMLEncoderen
            // 
            cbXMLEncoderen.AutoSize = true;
            cbXMLEncoderen.Location = new Point(7, 136);
            cbXMLEncoderen.Margin = new Padding(3, 4, 3, 4);
            cbXMLEncoderen.Name = "cbXMLEncoderen";
            cbXMLEncoderen.Size = new Size(163, 24);
            cbXMLEncoderen.TabIndex = 3;
            cbXMLEncoderen.Text = "Kan XML Encoderen";
            cbXMLEncoderen.UseVisualStyleBackColor = true;
            // 
            // cbXMLLezen
            // 
            cbXMLLezen.AutoSize = true;
            cbXMLLezen.Location = new Point(7, 103);
            cbXMLLezen.Margin = new Padding(3, 4, 3, 4);
            cbXMLLezen.Name = "cbXMLLezen";
            cbXMLLezen.Size = new Size(131, 24);
            cbXMLLezen.TabIndex = 2;
            cbXMLLezen.Text = "Kan XML Lezen";
            cbXMLLezen.UseVisualStyleBackColor = true;
            // 
            // cbXMLAanmaken
            // 
            cbXMLAanmaken.AutoSize = true;
            cbXMLAanmaken.Location = new Point(7, 64);
            cbXMLAanmaken.Margin = new Padding(3, 4, 3, 4);
            cbXMLAanmaken.Name = "cbXMLAanmaken";
            cbXMLAanmaken.Size = new Size(163, 24);
            cbXMLAanmaken.TabIndex = 1;
            cbXMLAanmaken.Text = "Kan XML Aanmaken";
            cbXMLAanmaken.UseVisualStyleBackColor = true;
            // 
            // cbXMLBewerken
            // 
            cbXMLBewerken.AutoSize = true;
            cbXMLBewerken.Location = new Point(7, 29);
            cbXMLBewerken.Margin = new Padding(3, 4, 3, 4);
            cbXMLBewerken.Name = "cbXMLBewerken";
            cbXMLBewerken.Size = new Size(157, 24);
            cbXMLBewerken.TabIndex = 0;
            cbXMLBewerken.Text = "Kan XML Bewerken";
            cbXMLBewerken.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cmbAfdelingen);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(btnGebruikerAanmaken);
            groupBox2.Controls.Add(cmbGebruikersRol);
            groupBox2.Controls.Add(txtGebruikerPaswoord);
            groupBox2.Controls.Add(txtGebruikerVoornaam);
            groupBox2.Controls.Add(txtGebruikerNaam);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(538, 299);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(395, 340);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Gebruiker";
            // 
            // cmbAfdelingen
            // 
            cmbAfdelingen.FormattingEnabled = true;
            cmbAfdelingen.Location = new Point(139, 199);
            cmbAfdelingen.Margin = new Padding(3, 4, 3, 4);
            cmbAfdelingen.Name = "cmbAfdelingen";
            cmbAfdelingen.Size = new Size(249, 28);
            cmbAfdelingen.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(7, 203);
            label6.Name = "label6";
            label6.Size = new Size(85, 20);
            label6.TabIndex = 14;
            label6.Text = "Afdelingen:";
            // 
            // btnGebruikerAanmaken
            // 
            btnGebruikerAanmaken.Location = new Point(219, 285);
            btnGebruikerAanmaken.Margin = new Padding(3, 4, 3, 4);
            btnGebruikerAanmaken.Name = "btnGebruikerAanmaken";
            btnGebruikerAanmaken.Size = new Size(169, 47);
            btnGebruikerAanmaken.TabIndex = 13;
            btnGebruikerAanmaken.Text = "Aanmaken";
            btnGebruikerAanmaken.UseVisualStyleBackColor = true;
            btnGebruikerAanmaken.Click += btnGebruikerAanmaken_Click_1;
            // 
            // cmbGebruikersRol
            // 
            cmbGebruikersRol.FormattingEnabled = true;
            cmbGebruikersRol.Location = new Point(139, 29);
            cmbGebruikersRol.Margin = new Padding(3, 4, 3, 4);
            cmbGebruikersRol.Name = "cmbGebruikersRol";
            cmbGebruikersRol.Size = new Size(249, 28);
            cmbGebruikersRol.TabIndex = 8;
            // 
            // txtGebruikerPaswoord
            // 
            txtGebruikerPaswoord.Location = new Point(139, 147);
            txtGebruikerPaswoord.Margin = new Padding(3, 4, 3, 4);
            txtGebruikerPaswoord.Name = "txtGebruikerPaswoord";
            txtGebruikerPaswoord.Size = new Size(249, 27);
            txtGebruikerPaswoord.TabIndex = 7;
            // 
            // txtGebruikerVoornaam
            // 
            txtGebruikerVoornaam.Location = new Point(139, 108);
            txtGebruikerVoornaam.Margin = new Padding(3, 4, 3, 4);
            txtGebruikerVoornaam.Name = "txtGebruikerVoornaam";
            txtGebruikerVoornaam.Size = new Size(249, 27);
            txtGebruikerVoornaam.TabIndex = 6;
            // 
            // txtGebruikerNaam
            // 
            txtGebruikerNaam.Location = new Point(139, 68);
            txtGebruikerNaam.Margin = new Padding(3, 4, 3, 4);
            txtGebruikerNaam.Name = "txtGebruikerNaam";
            txtGebruikerNaam.Size = new Size(249, 27);
            txtGebruikerNaam.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 151);
            label5.Name = "label5";
            label5.Size = new Size(76, 20);
            label5.TabIndex = 5;
            label5.Text = "Paswoord:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 112);
            label4.Name = "label4";
            label4.Size = new Size(80, 20);
            label4.TabIndex = 4;
            label4.Text = "Voornaam:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 33);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 2;
            label2.Text = "Gebruikersrol:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 72);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 3;
            label3.Text = "Naam:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 24);
            label1.Name = "label1";
            label1.Size = new Size(167, 20);
            label1.TabIndex = 0;
            label1.Text = "Benaming gebruikersrol";
            // 
            // btnAanmakenRol
            // 
            btnAanmakenRol.Location = new Point(318, 48);
            btnAanmakenRol.Margin = new Padding(3, 4, 3, 4);
            btnAanmakenRol.Name = "btnAanmakenRol";
            btnAanmakenRol.Size = new Size(144, 31);
            btnAanmakenRol.TabIndex = 12;
            btnAanmakenRol.Text = "Aanmaken";
            btnAanmakenRol.UseVisualStyleBackColor = true;
            btnAanmakenRol.Click += btnAanmakenRol_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(51, 48);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(249, 27);
            textBox1.TabIndex = 2;
            // 
            // btnCheckAll
            // 
            btnCheckAll.Location = new Point(50, 211);
            btnCheckAll.Margin = new Padding(3, 4, 3, 4);
            btnCheckAll.Name = "btnCheckAll";
            btnCheckAll.Size = new Size(163, 36);
            btnCheckAll.TabIndex = 9;
            btnCheckAll.Text = "Check All";
            btnCheckAll.UseVisualStyleBackColor = true;
            btnCheckAll.Click += btnCheckAll_Click_1;
            // 
            // btnUncheckAll
            // 
            btnUncheckAll.Location = new Point(50, 255);
            btnUncheckAll.Margin = new Padding(3, 4, 3, 4);
            btnUncheckAll.Name = "btnUncheckAll";
            btnUncheckAll.Size = new Size(163, 36);
            btnUncheckAll.TabIndex = 10;
            btnUncheckAll.Text = "Uncheck All";
            btnUncheckAll.UseVisualStyleBackColor = true;
            btnUncheckAll.Click += btnUncheckAll_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(763, 677);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(170, 49);
            button2.TabIndex = 14;
            button2.Text = "Afsluiten";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(50, 83);
            label7.Name = "label7";
            label7.Size = new Size(159, 20);
            label7.TabIndex = 15;
            label7.Text = "Naam nieuwe afdeling";
            // 
            // txtAanmakenAfdeling
            // 
            txtAanmakenAfdeling.Location = new Point(51, 107);
            txtAanmakenAfdeling.Margin = new Padding(3, 4, 3, 4);
            txtAanmakenAfdeling.Name = "txtAanmakenAfdeling";
            txtAanmakenAfdeling.Size = new Size(249, 27);
            txtAanmakenAfdeling.TabIndex = 16;
            // 
            // btnAanmakenAfdeling
            // 
            btnAanmakenAfdeling.Location = new Point(318, 136);
            btnAanmakenAfdeling.Margin = new Padding(3, 4, 3, 4);
            btnAanmakenAfdeling.Name = "btnAanmakenAfdeling";
            btnAanmakenAfdeling.Size = new Size(144, 31);
            btnAanmakenAfdeling.TabIndex = 17;
            btnAanmakenAfdeling.Text = "Aanmaken";
            btnAanmakenAfdeling.UseVisualStyleBackColor = true;
            btnAanmakenAfdeling.Click += btnAanmakenAfdeling_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(50, 141);
            label8.Name = "label8";
            label8.Size = new Size(147, 20);
            label8.TabIndex = 18;
            label8.Text = "Beschrijving afdeling";
            // 
            // txtAfdelingBeschrijving
            // 
            txtAfdelingBeschrijving.Location = new Point(51, 165);
            txtAfdelingBeschrijving.Margin = new Padding(3, 4, 3, 4);
            txtAfdelingBeschrijving.Name = "txtAfdelingBeschrijving";
            txtAfdelingBeschrijving.Size = new Size(249, 27);
            txtAfdelingBeschrijving.TabIndex = 19;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtSleutel);
            groupBox3.Controls.Add(txtPad);
            groupBox3.Controls.Add(btnDisplayKeys);
            groupBox3.Controls.Add(btnRenewKey);
            groupBox3.Location = new Point(538, 48);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(395, 243);
            groupBox3.TabIndex = 20;
            groupBox3.TabStop = false;
            groupBox3.Text = "Encryptie";
            // 
            // txtSleutel
            // 
            txtSleutel.Enabled = false;
            txtSleutel.Location = new Point(7, 135);
            txtSleutel.Margin = new Padding(3, 4, 3, 4);
            txtSleutel.Multiline = true;
            txtSleutel.Name = "txtSleutel";
            txtSleutel.ScrollBars = ScrollBars.Both;
            txtSleutel.Size = new Size(375, 99);
            txtSleutel.TabIndex = 24;
            // 
            // txtPad
            // 
            txtPad.Enabled = false;
            txtPad.Location = new Point(7, 73);
            txtPad.Margin = new Padding(3, 4, 3, 4);
            txtPad.Multiline = true;
            txtPad.Name = "txtPad";
            txtPad.ScrollBars = ScrollBars.Horizontal;
            txtPad.Size = new Size(375, 39);
            txtPad.TabIndex = 23;
            // 
            // btnDisplayKeys
            // 
            btnDisplayKeys.Location = new Point(219, 29);
            btnDisplayKeys.Margin = new Padding(3, 4, 3, 4);
            btnDisplayKeys.Name = "btnDisplayKeys";
            btnDisplayKeys.Size = new Size(163, 36);
            btnDisplayKeys.TabIndex = 22;
            btnDisplayKeys.Text = "Geef sleutels weer";
            btnDisplayKeys.UseVisualStyleBackColor = true;
            btnDisplayKeys.Click += btnDisplayKeys_Click;
            // 
            // btnRenewKey
            // 
            btnRenewKey.Location = new Point(7, 29);
            btnRenewKey.Margin = new Padding(3, 4, 3, 4);
            btnRenewKey.Name = "btnRenewKey";
            btnRenewKey.Size = new Size(163, 36);
            btnRenewKey.TabIndex = 21;
            btnRenewKey.Text = "Vernieuw sleutel";
            btnRenewKey.UseVisualStyleBackColor = true;
            btnRenewKey.Click += btnRenewKey_Click;
            // 
            // btnUitloggen
            // 
            btnUitloggen.Location = new Point(587, 677);
            btnUitloggen.Margin = new Padding(3, 4, 3, 4);
            btnUitloggen.Name = "btnUitloggen";
            btnUitloggen.Size = new Size(170, 49);
            btnUitloggen.TabIndex = 21;
            btnUitloggen.Text = "Uitloggen";
            btnUitloggen.UseVisualStyleBackColor = true;
            btnUitloggen.Click += btnUitloggen_Click;
            // 
            // Super_Admin_Screen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGoldenrod;
            ClientSize = new Size(1021, 776);
            Controls.Add(btnUitloggen);
            Controls.Add(groupBox3);
            Controls.Add(txtAfdelingBeschrijving);
            Controls.Add(label8);
            Controls.Add(btnAanmakenAfdeling);
            Controls.Add(txtAanmakenAfdeling);
            Controls.Add(label7);
            Controls.Add(button2);
            Controls.Add(btnCheckAll);
            Controls.Add(btnAanmakenRol);
            Controls.Add(btnUncheckAll);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Super_Admin_Screen";
            Text = "Superadmin";
            Load += Super_Admin_Screen_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label1;
        private CheckBox cbJSONEncoderen;
        private CheckBox cbJSONLezen;
        private CheckBox cbJSONAanmaken;
        private CheckBox cbJSONBewerken;
        private CheckBox cbTXTEncoderen;
        private CheckBox cbTXTLezen;
        private CheckBox cbTXTAanmaken;
        private CheckBox cbTXTBewerken;
        private CheckBox cbXMLEncoderen;
        private CheckBox cbXMLLezen;
        private CheckBox cbXMLAanmaken;
        private CheckBox cbXMLBewerken;
        private Button btnGebruikerAanmaken;
        private ComboBox cmbGebruikersRol;
        private TextBox txtGebruikerPaswoord;
        private TextBox txtGebruikerVoornaam;
        private TextBox txtGebruikerNaam;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label3;
        private Button btnAanmakenRol;
        private TextBox textBox1;
        private Button btnCheckAll;
        private Button btnUncheckAll;
        private Button button2;
        private Label label6;
        private Label label7;
        private TextBox txtAanmakenAfdeling;
        private Button btnAanmakenAfdeling;
        private Label label8;
        private TextBox txtAfdelingBeschrijving;
        private ComboBox cmbAfdelingen;
        private GroupBox groupBox3;
        private Button btnDisplayKeys;
        private Button btnRenewKey;
        private TextBox txtPad;
        private TextBox txtSleutel;
        public Button btnUitloggen;
    }
}