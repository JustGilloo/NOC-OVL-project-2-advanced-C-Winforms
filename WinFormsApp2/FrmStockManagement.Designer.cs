namespace Groep_project_2
{
    partial class FrmStockManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStockManagement));
            button1 = new Button();
            btnGrondStofToevoegen = new Button();
            grpBoxToevoegen = new GroupBox();
            btnVerwijderen = new Button();
            txtPrijsToevoegen = new TextBox();
            lblPrijsToevoegenVerwijderen = new Label();
            txtAantalToevoegen = new TextBox();
            lblToevoegenVerwijderen = new Label();
            txtNaamToevoegen = new TextBox();
            lblNaamToevoegenVerwijderen = new Label();
            grpBoxBewerken = new GroupBox();
            txtPrijsbewerken = new TextBox();
            lblPrijsBewerken = new Label();
            btnPrijsBewerken = new Button();
            txtNaamBewerken = new TextBox();
            lblNaamBewerken = new Label();
            btnVerminder = new Button();
            txtAantalBewerken = new TextBox();
            lblAantalBewerken = new Label();
            btnVermeerder = new Button();
            button6 = new Button();
            menuStrip1 = new MenuStrip();
            stockbeheerToolStripMenuItem = new ToolStripMenuItem();
            grondstofToevoegenverwijderenToolStripMenuItem = new ToolStripMenuItem();
            grondstofBewerkenToolStripMenuItem = new ToolStripMenuItem();
            afsluitenToolStripMenuItem = new ToolStripMenuItem();
            lbDisplay = new ListBox();
            grpBoxToevoegen.SuspendLayout();
            grpBoxBewerken.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(121, 115);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(9, 11);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnGrondStofToevoegen
            // 
            btnGrondStofToevoegen.Location = new Point(37, 207);
            btnGrondStofToevoegen.Margin = new Padding(3, 4, 3, 4);
            btnGrondStofToevoegen.Name = "btnGrondStofToevoegen";
            btnGrondStofToevoegen.Size = new Size(217, 31);
            btnGrondStofToevoegen.TabIndex = 2;
            btnGrondStofToevoegen.Text = "Toevoegen";
            btnGrondStofToevoegen.UseVisualStyleBackColor = true;
            btnGrondStofToevoegen.Click += btnGrondStofToevoegen_Click;
            // 
            // grpBoxToevoegen
            // 
            grpBoxToevoegen.Controls.Add(btnVerwijderen);
            grpBoxToevoegen.Controls.Add(txtPrijsToevoegen);
            grpBoxToevoegen.Controls.Add(lblPrijsToevoegenVerwijderen);
            grpBoxToevoegen.Controls.Add(txtAantalToevoegen);
            grpBoxToevoegen.Controls.Add(lblToevoegenVerwijderen);
            grpBoxToevoegen.Controls.Add(txtNaamToevoegen);
            grpBoxToevoegen.Controls.Add(lblNaamToevoegenVerwijderen);
            grpBoxToevoegen.Controls.Add(btnGrondStofToevoegen);
            grpBoxToevoegen.Controls.Add(button1);
            grpBoxToevoegen.Location = new Point(545, 59);
            grpBoxToevoegen.Margin = new Padding(3, 4, 3, 4);
            grpBoxToevoegen.Name = "grpBoxToevoegen";
            grpBoxToevoegen.Padding = new Padding(3, 4, 3, 4);
            grpBoxToevoegen.Size = new Size(274, 295);
            grpBoxToevoegen.TabIndex = 3;
            grpBoxToevoegen.TabStop = false;
            grpBoxToevoegen.Text = "Grondstof toevoegen of verwijderen";
            // 
            // btnVerwijderen
            // 
            btnVerwijderen.Location = new Point(38, 245);
            btnVerwijderen.Margin = new Padding(3, 4, 3, 4);
            btnVerwijderen.Name = "btnVerwijderen";
            btnVerwijderen.Size = new Size(217, 31);
            btnVerwijderen.TabIndex = 9;
            btnVerwijderen.Text = "Verwijderen";
            btnVerwijderen.UseVisualStyleBackColor = true;
            btnVerwijderen.Click += btnVerwijderen_Click;
            // 
            // txtPrijsToevoegen
            // 
            txtPrijsToevoegen.Location = new Point(121, 144);
            txtPrijsToevoegen.Margin = new Padding(3, 4, 3, 4);
            txtPrijsToevoegen.Name = "txtPrijsToevoegen";
            txtPrijsToevoegen.Size = new Size(114, 27);
            txtPrijsToevoegen.TabIndex = 8;
            // 
            // lblPrijsToevoegenVerwijderen
            // 
            lblPrijsToevoegenVerwijderen.AutoSize = true;
            lblPrijsToevoegenVerwijderen.Location = new Point(37, 155);
            lblPrijsToevoegenVerwijderen.Name = "lblPrijsToevoegenVerwijderen";
            lblPrijsToevoegenVerwijderen.Size = new Size(39, 20);
            lblPrijsToevoegenVerwijderen.TabIndex = 7;
            lblPrijsToevoegenVerwijderen.Text = "Prijs:";
            // 
            // txtAantalToevoegen
            // 
            txtAantalToevoegen.Location = new Point(121, 105);
            txtAantalToevoegen.Margin = new Padding(3, 4, 3, 4);
            txtAantalToevoegen.Name = "txtAantalToevoegen";
            txtAantalToevoegen.Size = new Size(114, 27);
            txtAantalToevoegen.TabIndex = 6;
            // 
            // lblToevoegenVerwijderen
            // 
            lblToevoegenVerwijderen.AutoSize = true;
            lblToevoegenVerwijderen.Location = new Point(37, 112);
            lblToevoegenVerwijderen.Name = "lblToevoegenVerwijderen";
            lblToevoegenVerwijderen.Size = new Size(55, 20);
            lblToevoegenVerwijderen.TabIndex = 5;
            lblToevoegenVerwijderen.Text = "Aantal:";
            // 
            // txtNaamToevoegen
            // 
            txtNaamToevoegen.Location = new Point(121, 65);
            txtNaamToevoegen.Margin = new Padding(3, 4, 3, 4);
            txtNaamToevoegen.Name = "txtNaamToevoegen";
            txtNaamToevoegen.Size = new Size(114, 27);
            txtNaamToevoegen.TabIndex = 4;
            // 
            // lblNaamToevoegenVerwijderen
            // 
            lblNaamToevoegenVerwijderen.AutoSize = true;
            lblNaamToevoegenVerwijderen.Location = new Point(37, 69);
            lblNaamToevoegenVerwijderen.Name = "lblNaamToevoegenVerwijderen";
            lblNaamToevoegenVerwijderen.Size = new Size(52, 20);
            lblNaamToevoegenVerwijderen.TabIndex = 3;
            lblNaamToevoegenVerwijderen.Text = "Naam:";
            // 
            // grpBoxBewerken
            // 
            grpBoxBewerken.Controls.Add(txtPrijsbewerken);
            grpBoxBewerken.Controls.Add(lblPrijsBewerken);
            grpBoxBewerken.Controls.Add(btnPrijsBewerken);
            grpBoxBewerken.Controls.Add(txtNaamBewerken);
            grpBoxBewerken.Controls.Add(lblNaamBewerken);
            grpBoxBewerken.Controls.Add(btnVerminder);
            grpBoxBewerken.Controls.Add(txtAantalBewerken);
            grpBoxBewerken.Controls.Add(lblAantalBewerken);
            grpBoxBewerken.Controls.Add(btnVermeerder);
            grpBoxBewerken.Controls.Add(button6);
            grpBoxBewerken.Location = new Point(545, 36);
            grpBoxBewerken.Margin = new Padding(3, 4, 3, 4);
            grpBoxBewerken.Name = "grpBoxBewerken";
            grpBoxBewerken.Padding = new Padding(3, 4, 3, 4);
            grpBoxBewerken.Size = new Size(327, 351);
            grpBoxBewerken.TabIndex = 10;
            grpBoxBewerken.TabStop = false;
            grpBoxBewerken.Text = "Grondstof bewerken";
            // 
            // txtPrijsbewerken
            // 
            txtPrijsbewerken.Location = new Point(121, 143);
            txtPrijsbewerken.Margin = new Padding(3, 4, 3, 4);
            txtPrijsbewerken.Name = "txtPrijsbewerken";
            txtPrijsbewerken.Size = new Size(114, 27);
            txtPrijsbewerken.TabIndex = 13;
            // 
            // lblPrijsBewerken
            // 
            lblPrijsBewerken.AutoSize = true;
            lblPrijsBewerken.Location = new Point(37, 147);
            lblPrijsBewerken.Name = "lblPrijsBewerken";
            lblPrijsBewerken.Size = new Size(39, 20);
            lblPrijsBewerken.TabIndex = 10;
            lblPrijsBewerken.Text = "Prijs:";
            // 
            // btnPrijsBewerken
            // 
            btnPrijsBewerken.Location = new Point(37, 263);
            btnPrijsBewerken.Margin = new Padding(3, 4, 3, 4);
            btnPrijsBewerken.Name = "btnPrijsBewerken";
            btnPrijsBewerken.Size = new Size(217, 31);
            btnPrijsBewerken.TabIndex = 12;
            btnPrijsBewerken.Text = "Verander prijs";
            btnPrijsBewerken.UseVisualStyleBackColor = true;
            btnPrijsBewerken.Click += btnPrijsBewerken_Click;
            // 
            // txtNaamBewerken
            // 
            txtNaamBewerken.Location = new Point(121, 72);
            txtNaamBewerken.Margin = new Padding(3, 4, 3, 4);
            txtNaamBewerken.Name = "txtNaamBewerken";
            txtNaamBewerken.Size = new Size(114, 27);
            txtNaamBewerken.TabIndex = 11;
            // 
            // lblNaamBewerken
            // 
            lblNaamBewerken.AutoSize = true;
            lblNaamBewerken.Location = new Point(37, 76);
            lblNaamBewerken.Name = "lblNaamBewerken";
            lblNaamBewerken.Size = new Size(52, 20);
            lblNaamBewerken.TabIndex = 10;
            lblNaamBewerken.Text = "Naam:";
            // 
            // btnVerminder
            // 
            btnVerminder.Location = new Point(38, 224);
            btnVerminder.Margin = new Padding(3, 4, 3, 4);
            btnVerminder.Name = "btnVerminder";
            btnVerminder.Size = new Size(217, 31);
            btnVerminder.TabIndex = 9;
            btnVerminder.Text = "Verminder";
            btnVerminder.UseVisualStyleBackColor = true;
            btnVerminder.Click += btnVerminder_Click;
            // 
            // txtAantalBewerken
            // 
            txtAantalBewerken.Location = new Point(121, 105);
            txtAantalBewerken.Margin = new Padding(3, 4, 3, 4);
            txtAantalBewerken.Name = "txtAantalBewerken";
            txtAantalBewerken.Size = new Size(114, 27);
            txtAantalBewerken.TabIndex = 6;
            // 
            // lblAantalBewerken
            // 
            lblAantalBewerken.AutoSize = true;
            lblAantalBewerken.Location = new Point(37, 112);
            lblAantalBewerken.Name = "lblAantalBewerken";
            lblAantalBewerken.Size = new Size(55, 20);
            lblAantalBewerken.TabIndex = 5;
            lblAantalBewerken.Text = "Aantal:";
            // 
            // btnVermeerder
            // 
            btnVermeerder.Location = new Point(38, 185);
            btnVermeerder.Margin = new Padding(3, 4, 3, 4);
            btnVermeerder.Name = "btnVermeerder";
            btnVermeerder.Size = new Size(217, 31);
            btnVermeerder.TabIndex = 2;
            btnVermeerder.Text = "Vermeerder";
            btnVermeerder.UseVisualStyleBackColor = true;
            btnVermeerder.Click += btnVermeerder_Click;
            // 
            // button6
            // 
            button6.Location = new Point(121, 115);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(9, 11);
            button6.TabIndex = 1;
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { stockbeheerToolStripMenuItem, afsluitenToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(969, 30);
            menuStrip1.TabIndex = 13;
            menuStrip1.Text = "menuStrip1";
            // 
            // stockbeheerToolStripMenuItem
            // 
            stockbeheerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { grondstofToevoegenverwijderenToolStripMenuItem, grondstofBewerkenToolStripMenuItem });
            stockbeheerToolStripMenuItem.Name = "stockbeheerToolStripMenuItem";
            stockbeheerToolStripMenuItem.Size = new Size(105, 24);
            stockbeheerToolStripMenuItem.Text = "Stockbeheer";
            // 
            // grondstofToevoegenverwijderenToolStripMenuItem
            // 
            grondstofToevoegenverwijderenToolStripMenuItem.Name = "grondstofToevoegenverwijderenToolStripMenuItem";
            grondstofToevoegenverwijderenToolStripMenuItem.Size = new Size(316, 26);
            grondstofToevoegenverwijderenToolStripMenuItem.Text = "Grondstof toevoegen/verwijderen";
            grondstofToevoegenverwijderenToolStripMenuItem.Click += grondstofToevoegenverwijderenToolStripMenuItem_Click;
            // 
            // grondstofBewerkenToolStripMenuItem
            // 
            grondstofBewerkenToolStripMenuItem.Name = "grondstofBewerkenToolStripMenuItem";
            grondstofBewerkenToolStripMenuItem.Size = new Size(316, 26);
            grondstofBewerkenToolStripMenuItem.Text = "Grondstof bewerken";
            grondstofBewerkenToolStripMenuItem.Click += grondstofBewerkenToolStripMenuItem_Click;
            // 
            // afsluitenToolStripMenuItem
            // 
            afsluitenToolStripMenuItem.Name = "afsluitenToolStripMenuItem";
            afsluitenToolStripMenuItem.Size = new Size(81, 24);
            afsluitenToolStripMenuItem.Text = "Afsluiten";
            afsluitenToolStripMenuItem.Click += afsluitenToolStripMenuItem_Click;
            // 
            // lbDisplay
            // 
            lbDisplay.FormattingEnabled = true;
            lbDisplay.ItemHeight = 20;
            lbDisplay.Location = new Point(14, 29);
            lbDisplay.Margin = new Padding(3, 4, 3, 4);
            lbDisplay.Name = "lbDisplay";
            lbDisplay.Size = new Size(524, 324);
            lbDisplay.TabIndex = 14;
            lbDisplay.SelectedIndexChanged += lbDisplay_SelectedIndexChanged;
            // 
            // FrmStockManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGoldenrod;
            ClientSize = new Size(969, 460);
            Controls.Add(lbDisplay);
            Controls.Add(grpBoxBewerken);
            Controls.Add(grpBoxToevoegen);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmStockManagement";
            Text = "Stock management";
            Load += FrmStockManagement_Load;
            grpBoxToevoegen.ResumeLayout(false);
            grpBoxToevoegen.PerformLayout();
            grpBoxBewerken.ResumeLayout(false);
            grpBoxBewerken.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Button btnGrondStofToevoegen;
        private GroupBox grpBoxToevoegen;
        private TextBox txtPrijsToevoegen;
        private Label lblPrijsToevoegenVerwijderen;
        private TextBox txtAantalToevoegen;
        private Label lblToevoegenVerwijderen;
        private TextBox txtNaamToevoegen;
        private Label lblNaamToevoegenVerwijderen;
        private Button btnVerwijderen;
        private GroupBox grpBoxBewerken;
        private Label lblNaamBewerken;
        private Button btnVerminder;
        private TextBox txtAantalBewerken;
        private Label lblAantalBewerken;
        private Button btnVermeerder;
        private Button button6;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem stockbeheerToolStripMenuItem;
        private ToolStripMenuItem grondstofToevoegenverwijderenToolStripMenuItem;
        private ToolStripMenuItem grondstofBewerkenToolStripMenuItem;
        private ToolStripMenuItem afsluitenToolStripMenuItem;
        private ListBox lbDisplay;
        private TextBox txtNaamBewerken;
        private TextBox txtPrijsbewerken;
        private Label lblPrijsBewerken;
        private Button btnPrijsBewerken;
    }
}