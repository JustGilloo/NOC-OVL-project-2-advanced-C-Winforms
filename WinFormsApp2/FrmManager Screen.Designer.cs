namespace WinFormsApp2
{
    partial class Manager_Screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manager_Screen));
            lblWelkomManager = new Label();
            menuStrip1 = new MenuStrip();
            werknemersToolStripMenuItem = new ToolStripMenuItem();
            lijstTonenToolStripMenuItem = new ToolStripMenuItem();
            aanmakenToolStripMenuItem = new ToolStripMenuItem();
            bewerkenToolStripMenuItem = new ToolStripMenuItem();
            verwijderenToolStripMenuItem = new ToolStripMenuItem();
            verkoopToolStripMenuItem = new ToolStripMenuItem();
            bestelbonAanmakenToolStripMenuItem = new ToolStripMenuItem();
            bestelbonOpenenToolStripMenuItem = new ToolStripMenuItem();
            StocktoolStripMenuItem1 = new ToolStripMenuItem();
            veldtoolStripMenuItem = new ToolStripMenuItem();
            bestandenToolStripMenuItem = new ToolStripMenuItem();
            uitMijnAfdelingToolStripMenuItem = new ToolStripMenuItem();
            lezenToolStripMenuItem = new ToolStripMenuItem();
            bewerkenToolStripMenuItem1 = new ToolStripMenuItem();
            verwijderenToolStripMenuItem1 = new ToolStripMenuItem();
            uitAndereToolStripMenuItem = new ToolStripMenuItem();
            openenToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            afsluitenToolStripMenuItem = new ToolStripMenuItem();
            lblWerknemers = new Label();
            lbWerknemers = new ListBox();
            pictureBox1 = new PictureBox();
            lblTijd = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblWelkomManager
            // 
            lblWelkomManager.AutoSize = true;
            lblWelkomManager.Location = new Point(14, 52);
            lblWelkomManager.Name = "lblWelkomManager";
            lblWelkomManager.Size = new Size(50, 20);
            lblWelkomManager.TabIndex = 0;
            lblWelkomManager.Text = "label1";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { werknemersToolStripMenuItem, verkoopToolStripMenuItem, StocktoolStripMenuItem1, veldtoolStripMenuItem, bestandenToolStripMenuItem, logoutToolStripMenuItem, afsluitenToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(568, 30);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // werknemersToolStripMenuItem
            // 
            werknemersToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { lijstTonenToolStripMenuItem, aanmakenToolStripMenuItem, bewerkenToolStripMenuItem, verwijderenToolStripMenuItem });
            werknemersToolStripMenuItem.Name = "werknemersToolStripMenuItem";
            werknemersToolStripMenuItem.Size = new Size(104, 24);
            werknemersToolStripMenuItem.Text = "Werknemers";
            // 
            // lijstTonenToolStripMenuItem
            // 
            lijstTonenToolStripMenuItem.Name = "lijstTonenToolStripMenuItem";
            lijstTonenToolStripMenuItem.Size = new Size(170, 26);
            lijstTonenToolStripMenuItem.Text = "Lijst Tonen";
            lijstTonenToolStripMenuItem.Click += lijstTonenToolStripMenuItem_Click;
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
            // verkoopToolStripMenuItem
            // 
            verkoopToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { bestelbonAanmakenToolStripMenuItem, bestelbonOpenenToolStripMenuItem });
            verkoopToolStripMenuItem.Name = "verkoopToolStripMenuItem";
            verkoopToolStripMenuItem.Size = new Size(78, 24);
            verkoopToolStripMenuItem.Text = "Verkoop";
            // 
            // bestelbonAanmakenToolStripMenuItem
            // 
            bestelbonAanmakenToolStripMenuItem.Name = "bestelbonAanmakenToolStripMenuItem";
            bestelbonAanmakenToolStripMenuItem.Size = new Size(230, 26);
            bestelbonAanmakenToolStripMenuItem.Text = "Bestelbon aanmaken";
            bestelbonAanmakenToolStripMenuItem.Click += bestelbonAanmakenToolStripMenuItem_Click;
            // 
            // bestelbonOpenenToolStripMenuItem
            // 
            bestelbonOpenenToolStripMenuItem.Name = "bestelbonOpenenToolStripMenuItem";
            bestelbonOpenenToolStripMenuItem.Size = new Size(230, 26);
            bestelbonOpenenToolStripMenuItem.Text = "Bestelbon openen";
            bestelbonOpenenToolStripMenuItem.Click += bestelbonOpenenToolStripMenuItem_Click;
            // 
            // StocktoolStripMenuItem1
            // 
            StocktoolStripMenuItem1.Name = "StocktoolStripMenuItem1";
            StocktoolStripMenuItem1.Size = new Size(105, 24);
            StocktoolStripMenuItem1.Text = "Stockbeheer";
            StocktoolStripMenuItem1.Click += StocktoolStripMenuItem1_Click;
            // 
            // veldtoolStripMenuItem
            // 
            veldtoolStripMenuItem.Name = "veldtoolStripMenuItem";
            veldtoolStripMenuItem.Size = new Size(52, 24);
            veldtoolStripMenuItem.Text = "Veld";
            veldtoolStripMenuItem.Click += veldtoolStripMenuItem_Click;
            // 
            // bestandenToolStripMenuItem
            // 
            bestandenToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { uitMijnAfdelingToolStripMenuItem, uitAndereToolStripMenuItem });
            bestandenToolStripMenuItem.Name = "bestandenToolStripMenuItem";
            bestandenToolStripMenuItem.Size = new Size(92, 24);
            bestandenToolStripMenuItem.Text = "Bestanden";
            // 
            // uitMijnAfdelingToolStripMenuItem
            // 
            uitMijnAfdelingToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { lezenToolStripMenuItem, bewerkenToolStripMenuItem1, verwijderenToolStripMenuItem1 });
            uitMijnAfdelingToolStripMenuItem.Name = "uitMijnAfdelingToolStripMenuItem";
            uitMijnAfdelingToolStripMenuItem.Size = new Size(240, 26);
            uitMijnAfdelingToolStripMenuItem.Text = "Uit Mijn Afdeling";
            // 
            // lezenToolStripMenuItem
            // 
            lezenToolStripMenuItem.Name = "lezenToolStripMenuItem";
            lezenToolStripMenuItem.Size = new Size(170, 26);
            lezenToolStripMenuItem.Text = "Lezen";
            lezenToolStripMenuItem.Click += lezenToolStripMenuItem_Click_1;
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
            // uitAndereToolStripMenuItem
            // 
            uitAndereToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openenToolStripMenuItem });
            uitAndereToolStripMenuItem.Name = "uitAndereToolStripMenuItem";
            uitAndereToolStripMenuItem.Size = new Size(240, 26);
            uitAndereToolStripMenuItem.Text = "Uit Andere Afdelingen";
            // 
            // openenToolStripMenuItem
            // 
            openenToolStripMenuItem.Name = "openenToolStripMenuItem";
            openenToolStripMenuItem.Size = new Size(144, 26);
            openenToolStripMenuItem.Text = "Openen";
            openenToolStripMenuItem.Click += openenToolStripMenuItem_Click;
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
            // lblWerknemers
            // 
            lblWerknemers.AutoSize = true;
            lblWerknemers.Location = new Point(14, 132);
            lblWerknemers.Name = "lblWerknemers";
            lblWerknemers.Size = new Size(118, 20);
            lblWerknemers.TabIndex = 2;
            lblWerknemers.Text = "Lijst werknemers";
            // 
            // lbWerknemers
            // 
            lbWerknemers.FormattingEnabled = true;
            lbWerknemers.ItemHeight = 20;
            lbWerknemers.Location = new Point(14, 155);
            lbWerknemers.Name = "lbWerknemers";
            lbWerknemers.Size = new Size(238, 224);
            lbWerknemers.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(547, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(21, 24);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // lblTijd
            // 
            lblTijd.AutoSize = true;
            lblTijd.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblTijd.Location = new Point(483, 37);
            lblTijd.Name = "lblTijd";
            lblTijd.Size = new Size(33, 20);
            lblTijd.TabIndex = 5;
            lblTijd.Text = "Tijd";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // Manager_Screen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGoldenrod;
            ClientSize = new Size(568, 389);
            Controls.Add(lblTijd);
            Controls.Add(pictureBox1);
            Controls.Add(lbWerknemers);
            Controls.Add(lblWerknemers);
            Controls.Add(lblWelkomManager);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Manager_Screen";
            Text = "Manager";
            Load += Manager_Screen_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelkomManager;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem werknemersToolStripMenuItem;
        private ToolStripMenuItem bestandenToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem afsluitenToolStripMenuItem;
        private ToolStripMenuItem lijstTonenToolStripMenuItem;
        private ToolStripMenuItem aanmakenToolStripMenuItem;
        private ToolStripMenuItem bewerkenToolStripMenuItem;
        private ToolStripMenuItem verwijderenToolStripMenuItem;
        private ToolStripMenuItem uitMijnAfdelingToolStripMenuItem;
        private ToolStripMenuItem lezenToolStripMenuItem;
        private ToolStripMenuItem bewerkenToolStripMenuItem1;
        private ToolStripMenuItem verwijderenToolStripMenuItem1;
        private ToolStripMenuItem uitAndereToolStripMenuItem;
        private ToolStripMenuItem openenToolStripMenuItem;
        private ToolStripMenuItem verkoopToolStripMenuItem;
        private ToolStripMenuItem bestelbonAanmakenToolStripMenuItem;
        private ToolStripMenuItem bestelbonOpenenToolStripMenuItem;
        private ToolStripMenuItem StocktoolStripMenuItem1;
        private ToolStripMenuItem veldtoolStripMenuItem;
        private Label lblWerknemers;
        private ListBox lbWerknemers;
        private PictureBox pictureBox1;
        private Label lblTijd;
        private System.Windows.Forms.Timer timer1;
    }
}