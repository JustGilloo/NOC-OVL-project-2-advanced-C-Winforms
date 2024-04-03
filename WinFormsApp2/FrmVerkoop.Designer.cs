namespace Groep_project_2
{
    partial class FrmVerkoop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVerkoop));
            btnLeesBestelling = new Button();
            btnLeveren = new Button();
            btnExit = new Button();
            txtPad = new TextBox();
            txtBestellingsbericht = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtBestandInhoud = new TextBox();
            SuspendLayout();
            // 
            // btnLeesBestelling
            // 
            btnLeesBestelling.Location = new Point(14, 16);
            btnLeesBestelling.Margin = new Padding(3, 4, 3, 4);
            btnLeesBestelling.Name = "btnLeesBestelling";
            btnLeesBestelling.Size = new Size(163, 31);
            btnLeesBestelling.TabIndex = 0;
            btnLeesBestelling.Text = "Lees Bestelling";
            btnLeesBestelling.UseVisualStyleBackColor = true;
            btnLeesBestelling.Click += btnLeesBestelling_Click;
            // 
            // btnLeveren
            // 
            btnLeveren.Location = new Point(14, 55);
            btnLeveren.Margin = new Padding(3, 4, 3, 4);
            btnLeveren.Name = "btnLeveren";
            btnLeveren.Size = new Size(163, 31);
            btnLeveren.TabIndex = 1;
            btnLeveren.Text = "Leveren";
            btnLeveren.UseVisualStyleBackColor = true;
            btnLeveren.Click += btnLeveren_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(14, 93);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(163, 31);
            btnExit.TabIndex = 2;
            btnExit.Text = "Sluiten";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // txtPad
            // 
            txtPad.Location = new Point(306, 17);
            txtPad.Margin = new Padding(3, 4, 3, 4);
            txtPad.Name = "txtPad";
            txtPad.Size = new Size(276, 27);
            txtPad.TabIndex = 3;
            // 
            // txtBestellingsbericht
            // 
            txtBestellingsbericht.Location = new Point(306, 51);
            txtBestellingsbericht.Margin = new Padding(3, 4, 3, 4);
            txtBestellingsbericht.Name = "txtBestellingsbericht";
            txtBestellingsbericht.Size = new Size(276, 27);
            txtBestellingsbericht.TabIndex = 4;
            txtBestellingsbericht.Text = "Dank u voor uw bestelling.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(200, 21);
            label1.Name = "label1";
            label1.Size = new Size(40, 20);
            label1.TabIndex = 5;
            label1.Text = "Pad: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(200, 55);
            label2.Name = "label2";
            label2.Size = new Size(113, 20);
            label2.TabIndex = 6;
            label2.Text = "Verkoopbericht:";
            // 
            // txtBestandInhoud
            // 
            txtBestandInhoud.Location = new Point(14, 132);
            txtBestandInhoud.Margin = new Padding(3, 4, 3, 4);
            txtBestandInhoud.Multiline = true;
            txtBestandInhoud.Name = "txtBestandInhoud";
            txtBestandInhoud.Size = new Size(569, 436);
            txtBestandInhoud.TabIndex = 7;
            // 
            // FrmVerkoop
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGoldenrod;
            ClientSize = new Size(599, 600);
            Controls.Add(txtBestandInhoud);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtBestellingsbericht);
            Controls.Add(txtPad);
            Controls.Add(btnExit);
            Controls.Add(btnLeveren);
            Controls.Add(btnLeesBestelling);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmVerkoop";
            Text = "Verkoop";
            Load += FrmVerkoop_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLeesBestelling;
        private Button btnLeveren;
        private Button btnExit;
        private TextBox txtPad;
        private TextBox txtBestellingsbericht;
        private Label label1;
        private Label label2;
        private TextBox txtBestandInhoud;
    }
}