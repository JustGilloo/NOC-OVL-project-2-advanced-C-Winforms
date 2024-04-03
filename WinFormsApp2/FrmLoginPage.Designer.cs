namespace WinFormsApp2
{
    partial class FrmLoginPage
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLoginPage));
            lblNaam = new Label();
            lblWachtwoord = new Label();
            txtNaam = new TextBox();
            txtWachtwoord = new TextBox();
            btnLogin = new Button();
            btnAfsluiten = new Button();
            pbLogo = new PictureBox();
            lblTijd = new Label();
            lblDatum = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // lblNaam
            // 
            lblNaam.AutoSize = true;
            lblNaam.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblNaam.Location = new Point(25, 187);
            lblNaam.Name = "lblNaam";
            lblNaam.Size = new Size(51, 20);
            lblNaam.TabIndex = 0;
            lblNaam.Text = "Naam";
            // 
            // lblWachtwoord
            // 
            lblWachtwoord.AutoSize = true;
            lblWachtwoord.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblWachtwoord.Location = new Point(25, 222);
            lblWachtwoord.Name = "lblWachtwoord";
            lblWachtwoord.Size = new Size(98, 20);
            lblWachtwoord.TabIndex = 1;
            lblWachtwoord.Text = "Wachtwoord";
            // 
            // txtNaam
            // 
            txtNaam.Location = new Point(144, 184);
            txtNaam.Margin = new Padding(3, 4, 3, 4);
            txtNaam.Name = "txtNaam";
            txtNaam.Size = new Size(214, 27);
            txtNaam.TabIndex = 2;
            // 
            // txtWachtwoord
            // 
            txtWachtwoord.Location = new Point(144, 219);
            txtWachtwoord.Margin = new Padding(3, 4, 3, 4);
            txtWachtwoord.Name = "txtWachtwoord";
            txtWachtwoord.PasswordChar = '#';
            txtWachtwoord.Size = new Size(214, 27);
            txtWachtwoord.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.Window;
            btnLogin.Location = new Point(383, 182);
            btnLogin.Margin = new Padding(3, 4, 3, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(86, 31);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnAfsluiten
            // 
            btnAfsluiten.BackColor = SystemColors.Window;
            btnAfsluiten.Location = new Point(383, 219);
            btnAfsluiten.Margin = new Padding(3, 4, 3, 4);
            btnAfsluiten.Name = "btnAfsluiten";
            btnAfsluiten.Size = new Size(86, 31);
            btnAfsluiten.TabIndex = 5;
            btnAfsluiten.Text = "Afsluiten";
            btnAfsluiten.UseVisualStyleBackColor = false;
            btnAfsluiten.Click += btnAfsluiten_Click;
            // 
            // pbLogo
            // 
            pbLogo.BackgroundImage = (Image)resources.GetObject("pbLogo.BackgroundImage");
            pbLogo.BackgroundImageLayout = ImageLayout.Stretch;
            pbLogo.Location = new Point(144, 12);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(214, 146);
            pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogo.TabIndex = 6;
            pbLogo.TabStop = false;
            // 
            // lblTijd
            // 
            lblTijd.AutoSize = true;
            lblTijd.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblTijd.Location = new Point(215, 160);
            lblTijd.Name = "lblTijd";
            lblTijd.Size = new Size(33, 20);
            lblTijd.TabIndex = 7;
            lblTijd.Text = "Tijd";
            // 
            // lblDatum
            // 
            lblDatum.AutoSize = true;
            lblDatum.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblDatum.Location = new Point(144, 138);
            lblDatum.Name = "lblDatum";
            lblDatum.Size = new Size(58, 20);
            lblDatum.TabIndex = 8;
            lblDatum.Text = "Datum";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // FrmLoginPage
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGoldenrod;
            CancelButton = btnAfsluiten;
            ClientSize = new Size(497, 267);
            Controls.Add(lblDatum);
            Controls.Add(lblTijd);
            Controls.Add(pbLogo);
            Controls.Add(btnAfsluiten);
            Controls.Add(btnLogin);
            Controls.Add(txtWachtwoord);
            Controls.Add(txtNaam);
            Controls.Add(lblWachtwoord);
            Controls.Add(lblNaam);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmLoginPage";
            Text = "Login";
            Load += LoginPage_Load;
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNaam;
        private Label lblWachtwoord;
        private TextBox txtNaam;
        private TextBox txtWachtwoord;
        private Button btnLogin;
        private Button btnAfsluiten;
        private PictureBox pbLogo;
        private Label lblTijd;
        private Label lblDatum;
        private System.Windows.Forms.Timer timer1;
    }
}