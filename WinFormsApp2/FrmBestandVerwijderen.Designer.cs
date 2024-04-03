namespace WinFormsApp2
{
    partial class FrmBestandVerwijderen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBestandVerwijderen));
            txtPad = new TextBox();
            btnBestandKiezen = new Button();
            btnBestandVerwijderen = new Button();
            btnAnnuleer = new Button();
            SuspendLayout();
            // 
            // txtPad
            // 
            txtPad.Location = new Point(12, 12);
            txtPad.Name = "txtPad";
            txtPad.Size = new Size(330, 27);
            txtPad.TabIndex = 1;
            // 
            // btnBestandKiezen
            // 
            btnBestandKiezen.Location = new Point(348, 12);
            btnBestandKiezen.Name = "btnBestandKiezen";
            btnBestandKiezen.Size = new Size(169, 29);
            btnBestandKiezen.TabIndex = 2;
            btnBestandKiezen.Text = "Bestand kiezen";
            btnBestandKiezen.UseVisualStyleBackColor = true;
            btnBestandKiezen.Click += btnBestandKiezen_Click;
            // 
            // btnBestandVerwijderen
            // 
            btnBestandVerwijderen.Location = new Point(348, 47);
            btnBestandVerwijderen.Name = "btnBestandVerwijderen";
            btnBestandVerwijderen.Size = new Size(169, 29);
            btnBestandVerwijderen.TabIndex = 4;
            btnBestandVerwijderen.Text = "Bestand verwijderen";
            btnBestandVerwijderen.UseVisualStyleBackColor = true;
            btnBestandVerwijderen.Click += btnBestandVerwijderen_Click;
            // 
            // btnAnnuleer
            // 
            btnAnnuleer.Location = new Point(348, 82);
            btnAnnuleer.Name = "btnAnnuleer";
            btnAnnuleer.Size = new Size(169, 29);
            btnAnnuleer.TabIndex = 5;
            btnAnnuleer.Text = "Annuleer";
            btnAnnuleer.UseVisualStyleBackColor = true;
            btnAnnuleer.Click += btnAnnuleer_Click;
            // 
            // FrmBestandVerwijderen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGoldenrod;
            ClientSize = new Size(531, 123);
            Controls.Add(btnAnnuleer);
            Controls.Add(btnBestandVerwijderen);
            Controls.Add(btnBestandKiezen);
            Controls.Add(txtPad);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmBestandVerwijderen";
            Text = "Bestand verwijderen";
            Load += FrmBestandVerwijderen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPad;
        private Button btnBestandKiezen;
        private Button btnBestandVerwijderen;
        private Button btnAnnuleer;
    }
}