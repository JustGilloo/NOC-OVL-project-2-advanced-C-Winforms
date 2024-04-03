namespace Groep_project_2
{
    partial class FrmWerknemerVerwijderen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmWerknemerVerwijderen));
            label1 = new Label();
            cmbWerknemers = new ComboBox();
            btnVerwijderen = new Button();
            btnAnnuleren = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 17);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 0;
            label1.Text = "Werknemer";
            // 
            // cmbWerknemers
            // 
            cmbWerknemers.FormattingEnabled = true;
            cmbWerknemers.Location = new Point(102, 17);
            cmbWerknemers.Name = "cmbWerknemers";
            cmbWerknemers.Size = new Size(151, 28);
            cmbWerknemers.TabIndex = 1;
            // 
            // btnVerwijderen
            // 
            btnVerwijderen.Location = new Point(259, 17);
            btnVerwijderen.Name = "btnVerwijderen";
            btnVerwijderen.Size = new Size(116, 29);
            btnVerwijderen.TabIndex = 2;
            btnVerwijderen.Text = "Verwijderen";
            btnVerwijderen.UseVisualStyleBackColor = true;
            btnVerwijderen.Click += btnVerwijderen_Click;
            // 
            // btnAnnuleren
            // 
            btnAnnuleren.Location = new Point(259, 52);
            btnAnnuleren.Name = "btnAnnuleren";
            btnAnnuleren.Size = new Size(116, 32);
            btnAnnuleren.TabIndex = 3;
            btnAnnuleren.Text = "Annuleren";
            btnAnnuleren.UseVisualStyleBackColor = true;
            btnAnnuleren.Click += btnAnnuleren_Click;
            // 
            // FrmWerknemerVerwijderen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGoldenrod;
            ClientSize = new Size(400, 101);
            Controls.Add(btnAnnuleren);
            Controls.Add(btnVerwijderen);
            Controls.Add(cmbWerknemers);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmWerknemerVerwijderen";
            Text = "Werknemer verwijderen";
            Load += FrmWerknemerVerwijderen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbWerknemers;
        private Button btnVerwijderen;
        private Button btnAnnuleren;
    }
}