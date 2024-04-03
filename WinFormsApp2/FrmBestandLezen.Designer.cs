namespace WinFormsApp2
{
    partial class FrmBestandLezen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBestandLezen));
            txtPad = new TextBox();
            btnBestandKiezen = new Button();
            txtBestandInhoud = new TextBox();
            btnAnnuleer = new Button();
            btnBestandOpslaan = new Button();
            btnDecrypt = new Button();
            btnEncrypt = new Button();
            SuspendLayout();
            // 
            // txtPad
            // 
            txtPad.Location = new Point(11, 12);
            txtPad.Name = "txtPad";
            txtPad.Size = new Size(330, 27);
            txtPad.TabIndex = 0;
            // 
            // btnBestandKiezen
            // 
            btnBestandKiezen.Location = new Point(347, 11);
            btnBestandKiezen.Name = "btnBestandKiezen";
            btnBestandKiezen.Size = new Size(169, 29);
            btnBestandKiezen.TabIndex = 1;
            btnBestandKiezen.Text = "Bestand kiezen";
            btnBestandKiezen.UseVisualStyleBackColor = true;
            btnBestandKiezen.Click += btnBestandKiezen_Click;
            // 
            // txtBestandInhoud
            // 
            txtBestandInhoud.Location = new Point(11, 45);
            txtBestandInhoud.Multiline = true;
            txtBestandInhoud.Name = "txtBestandInhoud";
            txtBestandInhoud.ScrollBars = ScrollBars.Both;
            txtBestandInhoud.Size = new Size(330, 393);
            txtBestandInhoud.TabIndex = 2;
            // 
            // btnAnnuleer
            // 
            btnAnnuleer.Location = new Point(349, 411);
            btnAnnuleer.Name = "btnAnnuleer";
            btnAnnuleer.Size = new Size(169, 29);
            btnAnnuleer.TabIndex = 3;
            btnAnnuleer.Text = "Annuleer";
            btnAnnuleer.UseVisualStyleBackColor = true;
            btnAnnuleer.Click += btnAnnuleer_Click;
            // 
            // btnBestandOpslaan
            // 
            btnBestandOpslaan.Location = new Point(349, 45);
            btnBestandOpslaan.Name = "btnBestandOpslaan";
            btnBestandOpslaan.Size = new Size(169, 29);
            btnBestandOpslaan.TabIndex = 4;
            btnBestandOpslaan.Text = "Bestand opslaan";
            btnBestandOpslaan.UseVisualStyleBackColor = true;
            btnBestandOpslaan.Click += btnBestandOpslaan_Click;
            // 
            // btnDecrypt
            // 
            btnDecrypt.Location = new Point(523, 44);
            btnDecrypt.Name = "btnDecrypt";
            btnDecrypt.Size = new Size(169, 29);
            btnDecrypt.TabIndex = 13;
            btnDecrypt.Text = "Decrypt";
            btnDecrypt.UseVisualStyleBackColor = true;
            btnDecrypt.Click += btnDecrypt_Click;
            // 
            // btnEncrypt
            // 
            btnEncrypt.Location = new Point(523, 11);
            btnEncrypt.Name = "btnEncrypt";
            btnEncrypt.Size = new Size(169, 29);
            btnEncrypt.TabIndex = 12;
            btnEncrypt.Text = "Encrypt";
            btnEncrypt.UseVisualStyleBackColor = true;
            btnEncrypt.Click += btnEncrypt_Click;
            // 
            // FrmBestandLezen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGoldenrod;
            ClientSize = new Size(718, 456);
            Controls.Add(btnDecrypt);
            Controls.Add(btnEncrypt);
            Controls.Add(btnBestandOpslaan);
            Controls.Add(btnAnnuleer);
            Controls.Add(txtBestandInhoud);
            Controls.Add(btnBestandKiezen);
            Controls.Add(txtPad);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmBestandLezen";
            Text = "Bestand lezen";
            Load += FrmBestandLezen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPad;
        private Button btnBestandKiezen;
        private Button btnAnnuleer;
        public TextBox txtBestandInhoud;
        public Button btnBestandOpslaan;
        public Button btnDecrypt;
        public Button btnEncrypt;
    }
}