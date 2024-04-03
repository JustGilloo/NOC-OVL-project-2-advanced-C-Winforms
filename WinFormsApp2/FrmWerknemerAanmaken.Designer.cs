namespace Groep_project_2
{
    partial class FrmWerknemerAanmaken
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmWerknemerAanmaken));
            groupBox1 = new GroupBox();
            cmbWerknemer = new ComboBox();
            lblWerknemer = new Label();
            cmbAfdelingen = new ComboBox();
            label5 = new Label();
            txtGebruikerPaswoord = new TextBox();
            label4 = new Label();
            txtGebruikerVoornaam = new TextBox();
            label3 = new Label();
            txtGebruikerNaam = new TextBox();
            label2 = new Label();
            label1 = new Label();
            cmbGebruikersRol = new ComboBox();
            btnAanmaken = new Button();
            btnAnnuleren = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbWerknemer);
            groupBox1.Controls.Add(lblWerknemer);
            groupBox1.Controls.Add(cmbAfdelingen);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtGebruikerPaswoord);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtGebruikerVoornaam);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtGebruikerNaam);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cmbGebruikersRol);
            groupBox1.Location = new Point(10, 9);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(262, 190);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Werknemer";
            // 
            // cmbWerknemer
            // 
            cmbWerknemer.FormattingEnabled = true;
            cmbWerknemer.Location = new Point(95, 20);
            cmbWerknemer.Margin = new Padding(3, 2, 3, 2);
            cmbWerknemer.Name = "cmbWerknemer";
            cmbWerknemer.Size = new Size(133, 23);
            cmbWerknemer.TabIndex = 0;
            // 
            // lblWerknemer
            // 
            lblWerknemer.AutoSize = true;
            lblWerknemer.Location = new Point(5, 26);
            lblWerknemer.Name = "lblWerknemer";
            lblWerknemer.Size = new Size(68, 15);
            lblWerknemer.TabIndex = 9;
            lblWerknemer.Text = "Werknemer";
            // 
            // cmbAfdelingen
            // 
            cmbAfdelingen.FormattingEnabled = true;
            cmbAfdelingen.Location = new Point(95, 46);
            cmbAfdelingen.Margin = new Padding(3, 2, 3, 2);
            cmbAfdelingen.Name = "cmbAfdelingen";
            cmbAfdelingen.Size = new Size(133, 23);
            cmbAfdelingen.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(5, 77);
            label5.Name = "label5";
            label5.Size = new Size(77, 15);
            label5.TabIndex = 8;
            label5.Text = "Gebruikersrol";
            // 
            // txtGebruikerPaswoord
            // 
            txtGebruikerPaswoord.Location = new Point(95, 158);
            txtGebruikerPaswoord.Margin = new Padding(3, 2, 3, 2);
            txtGebruikerPaswoord.Name = "txtGebruikerPaswoord";
            txtGebruikerPaswoord.Size = new Size(133, 23);
            txtGebruikerPaswoord.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 164);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 6;
            label4.Text = "Paswoord";
            // 
            // txtGebruikerVoornaam
            // 
            txtGebruikerVoornaam.Location = new Point(95, 134);
            txtGebruikerVoornaam.Margin = new Padding(3, 2, 3, 2);
            txtGebruikerVoornaam.Name = "txtGebruikerVoornaam";
            txtGebruikerVoornaam.Size = new Size(133, 23);
            txtGebruikerVoornaam.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 139);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 4;
            label3.Text = "Voornaam";
            // 
            // txtGebruikerNaam
            // 
            txtGebruikerNaam.Location = new Point(95, 109);
            txtGebruikerNaam.Margin = new Padding(3, 2, 3, 2);
            txtGebruikerNaam.Name = "txtGebruikerNaam";
            txtGebruikerNaam.Size = new Size(133, 23);
            txtGebruikerNaam.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 114);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 2;
            label2.Text = "Naam";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 52);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 1;
            label1.Text = "Afdeling";
            // 
            // cmbGebruikersRol
            // 
            cmbGebruikersRol.FormattingEnabled = true;
            cmbGebruikersRol.Location = new Point(95, 71);
            cmbGebruikersRol.Margin = new Padding(3, 2, 3, 2);
            cmbGebruikersRol.Name = "cmbGebruikersRol";
            cmbGebruikersRol.Size = new Size(133, 23);
            cmbGebruikersRol.TabIndex = 2;
            // 
            // btnAanmaken
            // 
            btnAanmaken.Location = new Point(163, 213);
            btnAanmaken.Margin = new Padding(3, 2, 3, 2);
            btnAanmaken.Name = "btnAanmaken";
            btnAanmaken.Size = new Size(109, 29);
            btnAanmaken.TabIndex = 7;
            btnAanmaken.Text = "Aanmaken";
            btnAanmaken.UseVisualStyleBackColor = true;
            btnAanmaken.Click += btnAanmaken_Click;
            // 
            // btnAnnuleren
            // 
            btnAnnuleren.Location = new Point(10, 213);
            btnAnnuleren.Margin = new Padding(3, 2, 3, 2);
            btnAnnuleren.Name = "btnAnnuleren";
            btnAnnuleren.Size = new Size(109, 29);
            btnAnnuleren.TabIndex = 6;
            btnAnnuleren.Text = "Annuleren";
            btnAnnuleren.UseVisualStyleBackColor = true;
            btnAnnuleren.Click += btnAnnuleren_Click;
            // 
            // FrmWerknemerAanmaken
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGoldenrod;
            ClientSize = new Size(294, 258);
            Controls.Add(btnAnnuleren);
            Controls.Add(btnAanmaken);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmWerknemerAanmaken";
            Text = "Werknemer aanmaken";
            Load += FrmWerknemerAanmaken_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private ComboBox cmbGebruikersRol;
        private Label label3;
        private TextBox txtGebruikerNaam;
        private Label label2;
        private TextBox txtGebruikerPaswoord;
        private Label label4;
        private TextBox txtGebruikerVoornaam;
        private ComboBox cmbAfdelingen;
        private Label label5;
        private Button btnAnnuleren;
        public ComboBox cmbWerknemer;
        public Label lblWerknemer;
        public Button btnAanmaken;
    }
}