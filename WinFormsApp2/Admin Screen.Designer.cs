namespace WinFormsApp2
{
    partial class Admin_Screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Screen));
            menuStrip1 = new MenuStrip();
            gebruikersToolStripMenuItem = new ToolStripMenuItem();
            gebruikerToolStripMenuItem = new ToolStripMenuItem();
            aanmakenToolStripMenuItem = new ToolStripMenuItem();
            bewerkenToolStripMenuItem = new ToolStripMenuItem();
            verwijderenToolStripMenuItem = new ToolStripMenuItem();
            bestandenToolStripMenuItem = new ToolStripMenuItem();
            lezenToolStripMenuItem = new ToolStripMenuItem();
            bewerkenToolStripMenuItem1 = new ToolStripMenuItem();
            verwijderenToolStripMenuItem1 = new ToolStripMenuItem();
            SuperAdminToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            afsluitenToolStripMenuItem = new ToolStripMenuItem();
            lblWelkomAdmin = new Label();
            pictureBox1 = new PictureBox();
            lblTijd = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { gebruikersToolStripMenuItem, logoutToolStripMenuItem, afsluitenToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(557, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // gebruikersToolStripMenuItem
            // 
            gebruikersToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gebruikerToolStripMenuItem, bestandenToolStripMenuItem, SuperAdminToolStripMenuItem });
            gebruikersToolStripMenuItem.Name = "gebruikersToolStripMenuItem";
            gebruikersToolStripMenuItem.Size = new Size(60, 24);
            gebruikersToolStripMenuItem.Text = "Menu";
            // 
            // gebruikerToolStripMenuItem
            // 
            gebruikerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aanmakenToolStripMenuItem, bewerkenToolStripMenuItem, verwijderenToolStripMenuItem });
            gebruikerToolStripMenuItem.Name = "gebruikerToolStripMenuItem";
            gebruikerToolStripMenuItem.Size = new Size(172, 26);
            gebruikerToolStripMenuItem.Text = "Gebruiker ";
            // 
            // aanmakenToolStripMenuItem
            // 
            aanmakenToolStripMenuItem.Name = "aanmakenToolStripMenuItem";
            aanmakenToolStripMenuItem.Size = new Size(170, 26);
            aanmakenToolStripMenuItem.Text = "Aanmaken";
            aanmakenToolStripMenuItem.Click += aanmakenToolStripMenuItem_Click;
            // 
            // bewerkenToolStripMenuItem
            // 
            bewerkenToolStripMenuItem.Name = "bewerkenToolStripMenuItem";
            bewerkenToolStripMenuItem.Size = new Size(170, 26);
            bewerkenToolStripMenuItem.Text = "Bewerken";
            bewerkenToolStripMenuItem.Click += bewerkenToolStripMenuItem_Click;
            // 
            // verwijderenToolStripMenuItem
            // 
            verwijderenToolStripMenuItem.Name = "verwijderenToolStripMenuItem";
            verwijderenToolStripMenuItem.Size = new Size(170, 26);
            verwijderenToolStripMenuItem.Text = "Verwijderen";
            verwijderenToolStripMenuItem.Click += verwijderenToolStripMenuItem_Click;
            // 
            // bestandenToolStripMenuItem
            // 
            bestandenToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { lezenToolStripMenuItem, bewerkenToolStripMenuItem1, verwijderenToolStripMenuItem1 });
            bestandenToolStripMenuItem.Name = "bestandenToolStripMenuItem";
            bestandenToolStripMenuItem.Size = new Size(172, 26);
            bestandenToolStripMenuItem.Text = "Bestanden";
            // 
            // lezenToolStripMenuItem
            // 
            lezenToolStripMenuItem.Name = "lezenToolStripMenuItem";
            lezenToolStripMenuItem.Size = new Size(170, 26);
            lezenToolStripMenuItem.Text = "Lezen";
            lezenToolStripMenuItem.Click += lezenToolStripMenuItem_Click;
            // 
            // bewerkenToolStripMenuItem1
            // 
            bewerkenToolStripMenuItem1.Name = "bewerkenToolStripMenuItem1";
            bewerkenToolStripMenuItem1.Size = new Size(170, 26);
            bewerkenToolStripMenuItem1.Text = "Bewerken";
            bewerkenToolStripMenuItem1.Click += bewerkenToolStripMenuItem1_Click;
            // 
            // verwijderenToolStripMenuItem1
            // 
            verwijderenToolStripMenuItem1.Name = "verwijderenToolStripMenuItem1";
            verwijderenToolStripMenuItem1.Size = new Size(170, 26);
            verwijderenToolStripMenuItem1.Text = "Verwijderen";
            verwijderenToolStripMenuItem1.Click += verwijderenToolStripMenuItem1_Click;
            // 
            // SuperAdminToolStripMenuItem
            // 
            SuperAdminToolStripMenuItem.Name = "SuperAdminToolStripMenuItem";
            SuperAdminToolStripMenuItem.Size = new Size(172, 26);
            SuperAdminToolStripMenuItem.Text = "Superadmin";
            SuperAdminToolStripMenuItem.Click += SuperAdminToolStripMenuItem_Click;
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(89, 24);
            logoutToolStripMenuItem.Text = "Uitloggen";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // afsluitenToolStripMenuItem
            // 
            afsluitenToolStripMenuItem.Name = "afsluitenToolStripMenuItem";
            afsluitenToolStripMenuItem.Size = new Size(81, 24);
            afsluitenToolStripMenuItem.Text = "Afsluiten";
            afsluitenToolStripMenuItem.Click += afsluitenToolStripMenuItem_Click;
            // 
            // lblWelkomAdmin
            // 
            lblWelkomAdmin.AutoSize = true;
            lblWelkomAdmin.Location = new Point(12, 61);
            lblWelkomAdmin.Name = "lblWelkomAdmin";
            lblWelkomAdmin.Size = new Size(50, 20);
            lblWelkomAdmin.TabIndex = 1;
            lblWelkomAdmin.Text = "label1";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(535, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(22, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // lblTijd
            // 
            lblTijd.AutoSize = true;
            lblTijd.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblTijd.Location = new Point(466, 37);
            lblTijd.Name = "lblTijd";
            lblTijd.Size = new Size(33, 20);
            lblTijd.TabIndex = 3;
            lblTijd.Text = "Tijd";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // Admin_Screen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGoldenrod;
            ClientSize = new Size(557, 392);
            Controls.Add(lblTijd);
            Controls.Add(pictureBox1);
            Controls.Add(lblWelkomAdmin);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Admin_Screen";
            Text = "Admin";
            Load += Admin_Screen_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem gebruikersToolStripMenuItem;
        private ToolStripMenuItem gebruikerToolStripMenuItem;
        private ToolStripMenuItem aanmakenToolStripMenuItem;
        private ToolStripMenuItem bewerkenToolStripMenuItem;
        private ToolStripMenuItem verwijderenToolStripMenuItem;
        private ToolStripMenuItem bestandenToolStripMenuItem;
        private ToolStripMenuItem lezenToolStripMenuItem;
        private ToolStripMenuItem bewerkenToolStripMenuItem1;
        private ToolStripMenuItem verwijderenToolStripMenuItem1;
        private ToolStripMenuItem SuperAdminToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem afsluitenToolStripMenuItem;
        private Label lblWelkomAdmin;
        private PictureBox pictureBox1;
        private Label lblTijd;
        private System.Windows.Forms.Timer timer1;
    }
}