using Groep_project_2;
using Harvest_Moon_0._2;
using System.Xml;

namespace WinFormsApp2
{
    public partial class Manager_Screen : Form
    {
        public Gebruiker ingelogdeGebruikerManager = new Gebruiker();
        List<Gebruiker> LijstGebruikers = new List<Gebruiker>();
        List<Gebruiker> LijstGebruikersMetZelfdeAfdeling = new List<Gebruiker>();
        public Manager_Screen()
        {
            InitializeComponent();
        }
        private void Manager_Screen_Load(object sender, EventArgs e)
        {
            timer1.Start();
            //TODO: check op afdeling
            lblWelkomManager.Text = "Welkom " + ingelogdeGebruikerManager.GebruikersVoornaam.ToString() + "!";
            verkoopToolStripMenuItem.Enabled = false;
            verkoopToolStripMenuItem.Visible = false;
            StocktoolStripMenuItem1.Enabled = false;
            StocktoolStripMenuItem1.Visible = false;
            veldtoolStripMenuItem.Enabled = false;
            veldtoolStripMenuItem.Visible = false;
            if (ingelogdeGebruikerManager.GebruikersRol.KanBewerkenTxt == false)
            {
                bewerkenToolStripMenuItem1.Enabled = false;
                bewerkenToolStripMenuItem1.Visible = false;
            }
            if (ingelogdeGebruikerManager.GebruikersRol.KanAanmakenTxt == false)
            {
                bewerkenToolStripMenuItem1.Enabled = false;
                bewerkenToolStripMenuItem1.Visible = false;
            }
            if (ingelogdeGebruikerManager.GebruikersRol.KanLezenTxt == false)
            {
                lezenToolStripMenuItem.Enabled = false;
                lezenToolStripMenuItem.Visible = false;
            }
            if (ingelogdeGebruikerManager.GebruikersRol.KanAanmakenJson == false)
            {
                bewerkenToolStripMenuItem1.Enabled = false;
                bewerkenToolStripMenuItem1.Visible = false;
            }
            if (ingelogdeGebruikerManager.GebruikersRol.KanBewerkenJson == false)
            {
                bewerkenToolStripMenuItem1.Enabled = false;
                bewerkenToolStripMenuItem1.Visible = false;
            }
            if (ingelogdeGebruikerManager.GebruikersRol.KanLezenJson == false)
            {
                bewerkenToolStripMenuItem1.Enabled = false;
                bewerkenToolStripMenuItem1.Visible = false;
            }
            if (ingelogdeGebruikerManager.GebruikersRol.KanAanmakenXml == false)
            {
                bewerkenToolStripMenuItem1.Enabled = false;
                bewerkenToolStripMenuItem1.Visible = false;
            }
            if (ingelogdeGebruikerManager.GebruikersRol.KanBewerkenXml == false)
            {
                bewerkenToolStripMenuItem1.Enabled = false;
                bewerkenToolStripMenuItem1.Visible = false;
            }
            if (ingelogdeGebruikerManager.GebruikersRol.KanLezenXml == false)
            {
                bewerkenToolStripMenuItem1.Enabled = false;
                bewerkenToolStripMenuItem1.Visible = false;
            }
            foreach (Afdeling afdeling in ingelogdeGebruikerManager.LijstAfdelingen)
            {
                if (afdeling.Naam == "Verkoop")
                {
                    verkoopToolStripMenuItem.Enabled = true;
                    verkoopToolStripMenuItem.Visible = true;
                }
                if (afdeling.Naam == "Stock-managment")
                {
                    StocktoolStripMenuItem1.Enabled = true;
                    StocktoolStripMenuItem1.Visible = true;
                }
                if (afdeling.Naam == "Boer")
                {
                    veldtoolStripMenuItem.Enabled = true;
                    veldtoolStripMenuItem.Visible = true;
                }
            }
            if (ingelogdeGebruikerManager.GebruikersRol.Naam != "manager")
            {
                werknemersToolStripMenuItem.Enabled = false;
                werknemersToolStripMenuItem.Visible = false;
                openenToolStripMenuItem.Enabled = false;
                uitAndereToolStripMenuItem.Enabled = false;
                uitAndereToolStripMenuItem.Visible = false;
                lbWerknemers.Enabled = false;
                lbWerknemers.Visible = false;
                lblWerknemers.Enabled = false;
                lblWerknemers.Visible = false;
            }
            if (ingelogdeGebruikerManager.GebruikersRol.Naam == "verkoper")
            {
                verkoopToolStripMenuItem.Enabled = true;
                verkoopToolStripMenuItem.Visible = true;
            }
            if (ingelogdeGebruikerManager.GebruikersRol.Naam == "stock medewerker")
            {
                StocktoolStripMenuItem1.Enabled = true;
                StocktoolStripMenuItem1.Visible = true;
                bestelbonAanmakenToolStripMenuItem.Enabled = false;
                bestelbonAanmakenToolStripMenuItem.Visible = false;
            }
            if (ingelogdeGebruikerManager.GebruikersRol.Naam == "boer")
            {
                veldtoolStripMenuItem.Enabled = true;
                veldtoolStripMenuItem.Visible = true;
            }
        }

        private void lezenToolStripMenuItem_Click_1(object sender, EventArgs e) //uit mijn afdeling lezen
        {
            FrmBestandLezen frmBestandLezen = new FrmBestandLezen();
            frmBestandLezen.Text = "Bestand lezen";
            frmBestandLezen.btnEncrypt.Enabled = false;
            frmBestandLezen.btnEncrypt.Visible = false;
            frmBestandLezen.btnDecrypt.Enabled = false;
            frmBestandLezen.btnDecrypt.Visible = false;
            frmBestandLezen.txtBestandInhoud.Enabled = false;
            frmBestandLezen.btnBestandOpslaan.Enabled = false;
            frmBestandLezen.btnBestandOpslaan.Visible = false;
            frmBestandLezen.btnEncrypt.Enabled = false;
            frmBestandLezen.btnEncrypt.Visible = false;
            frmBestandLezen.btnDecrypt.Enabled = false;
            frmBestandLezen.btnDecrypt.Visible = false;
            frmBestandLezen.ShowDialog();
        }

        private void bewerkenToolStripMenuItem1_Click(object sender, EventArgs e) //uit mijn afdeling bewerken
        {
            FrmBestandLezen frmBestandLezen = new FrmBestandLezen();
            frmBestandLezen.Text = "Bestand bewerken";
            frmBestandLezen.ShowDialog();
        }
        private void openenToolStripMenuItem_Click(object sender, EventArgs e) //uit andere afdelingen openen
        {
            FrmBestandLezen frmBestandLezen = new FrmBestandLezen();
            frmBestandLezen.Text = "Bestand lezen - andere afdeling";
            frmBestandLezen.txtBestandInhoud.Enabled = false;
            frmBestandLezen.btnBestandOpslaan.Enabled = false;
            frmBestandLezen.btnBestandOpslaan.Visible = false;
            frmBestandLezen.btnEncrypt.Enabled = false;
            frmBestandLezen.btnEncrypt.Visible = false;
            frmBestandLezen.btnDecrypt.Enabled = false;
            frmBestandLezen.btnDecrypt.Visible = false;
            frmBestandLezen.ShowDialog();
        }
        private void verwijderenToolStripMenuItem1_Click(object sender, EventArgs e) //bestand verwijderen
        {
            FrmBestandVerwijderen frmBestandVerwijderen = new FrmBestandVerwijderen();
            frmBestandVerwijderen.ShowDialog();
        }

        private void lijstTonenToolStripMenuItem_Click(object sender, EventArgs e) //lijst van werknemers weergeven
        {
            GebruikersInlezen();
            lbWerknemers.DataSource = null;
            lbWerknemers.Items.Clear();
            LijstGebruikersMetZelfdeAfdeling.Clear();
            foreach (Gebruiker gebruiker in LijstGebruikers)
            {
                foreach (Afdeling afdelingGebruiker in gebruiker.LijstAfdelingen)
                {
                    foreach (Afdeling afdelingIngelogdeGebruiker in ingelogdeGebruikerManager.LijstAfdelingen)
                    {
                        if (afdelingGebruiker.Naam == afdelingIngelogdeGebruiker.Naam && gebruiker.Guid != ingelogdeGebruikerManager.Guid)
                        {
                            LijstGebruikersMetZelfdeAfdeling.Add(gebruiker);
                        }
                    }
                }
            }
            lbWerknemers.DataSource = LijstGebruikersMetZelfdeAfdeling;
        }

        private void aanmakenToolStripMenuItem_Click(object sender, EventArgs e) //werknemers aanmaken
        {
            FrmWerknemerAanmaken frmWerknemerAanmaken = new FrmWerknemerAanmaken();
            frmWerknemerAanmaken.ingelogdeGebruikerWerknemerMaken = ingelogdeGebruikerManager;
            frmWerknemerAanmaken.lblWerknemer.Visible = false;
            frmWerknemerAanmaken.lblWerknemer.Enabled = false;
            frmWerknemerAanmaken.cmbWerknemer.Visible = false;
            frmWerknemerAanmaken.cmbWerknemer.Enabled = false;
            frmWerknemerAanmaken.ShowDialog();
        }

        private void bewerkenToolStripMenuItem_Click(object sender, EventArgs e) //werknemers bewerken
        {
            FrmWerknemerAanmaken frmWerknemerAanmaken = new FrmWerknemerAanmaken();
            frmWerknemerAanmaken.ingelogdeGebruikerWerknemerMaken = ingelogdeGebruikerManager;
            frmWerknemerAanmaken.Text = "Werknemer bewerken";
            frmWerknemerAanmaken.btnAanmaken.Text = "Bewerken";
            frmWerknemerAanmaken.ShowDialog();
        }

        private void verwijderenToolStripMenuItem_Click(object sender, EventArgs e) //werknemers verwijderen
        {
            FrmWerknemerVerwijderen frmWerknemerVerwijderen = new FrmWerknemerVerwijderen();
            frmWerknemerVerwijderen.ingelogdeGebruikerWerknemerVerwijderen = ingelogdeGebruikerManager;
            frmWerknemerVerwijderen.ShowDialog();
        }
        private void bestelbonAanmakenToolStripMenuItem_Click(object sender, EventArgs e) //verkoopbon aanmaken, enkel zichtbaar indien verkoper
        {
            FrmVerkoop frmVerkoop = new FrmVerkoop();
            frmVerkoop.ShowDialog();
        }
        private void bestelbonOpenenToolStripMenuItem_Click(object sender, EventArgs e) //verkoopbon openen, enkel zichtbaar indien verkoper
        {
            FrmBestandLezen frmBestandLezen = new FrmBestandLezen();
            frmBestandLezen.Text = "Bestelbon openen";
            frmBestandLezen.ShowDialog();
        }
        private void StocktoolStripMenuItem1_Click(object sender, EventArgs e) //stockbeheer openen
        {
            FrmStockManagement frmStockManagement = new FrmStockManagement();
            frmStockManagement.Text = "Stockbeheer";
            frmStockManagement.ShowDialog();
        }
        private void veldtoolStripMenuItem_Click(object sender, EventArgs e) //veldwerk openen
        {
            WerkVeld werkVeld = new WerkVeld();
            werkVeld.Text = "Here I grow my fucks";
            werkVeld.ShowDialog();
        }
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Uitloggen();
        }
        private void afsluitenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTijd.Text = DateTime.Now.ToLongTimeString();
        }

        //methodes
        private void GebruikersInlezen()
        {
            if (System.IO.File.Exists("Gebruikers.xml"))
            {
                LijstGebruikers.Clear();
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load("Gebruikers.xml");

                XmlNodeList nodeGebruikers = xmlDoc.SelectNodes("//Gebruiker");
                foreach (XmlNode nodeGebruiker in nodeGebruikers)
                {
                    Gebruiker dezeGebruiker = new Gebruiker();
                    dezeGebruiker.LijstAfdelingen = new List<Afdeling>();
                    dezeGebruiker.GebruikersRol = new GebruikersRol();
                    dezeGebruiker.Guid = Guid.Parse(nodeGebruiker.ChildNodes[0].InnerText);
                    dezeGebruiker.GebruikersNaam = nodeGebruiker.ChildNodes[1].InnerText;
                    dezeGebruiker.GebruikersVoornaam = nodeGebruiker.ChildNodes[2].InnerText;
                    dezeGebruiker.Paswoord = nodeGebruiker.ChildNodes[3].InnerText;

                    XmlNodeList nodesAfdelingen = nodeGebruiker.SelectNodes(".//Afdelingen/Afdeling");
                    foreach (XmlNode dezeAfdeling in nodesAfdelingen)
                    {
                        Afdeling afdeling1 = new Afdeling(); //gaat hier meerdere keren in
                        afdeling1.Naam = dezeAfdeling.ChildNodes[0].InnerText;
                        afdeling1.Guid = Guid.Parse(dezeAfdeling.ChildNodes[1].InnerText);
                        dezeGebruiker.LijstAfdelingen.Add(afdeling1);
                    }
                    dezeGebruiker.GebruikersRol.Naam = nodeGebruiker.ChildNodes[5].InnerText;
                    dezeGebruiker.GebruikersRol.Guid = Guid.Parse(nodeGebruiker.ChildNodes[6].InnerText);
                    dezeGebruiker.GebruikersRol.KanBewerkenXml = bool.Parse(nodeGebruiker.ChildNodes[7].InnerText);
                    dezeGebruiker.GebruikersRol.KanAanmakenXml = bool.Parse(nodeGebruiker.ChildNodes[8].InnerText);
                    dezeGebruiker.GebruikersRol.KanLezenXml = bool.Parse(nodeGebruiker.ChildNodes[9].InnerText);
                    dezeGebruiker.GebruikersRol.KanEncrypterenXml = bool.Parse(nodeGebruiker.ChildNodes[10].InnerText);
                    dezeGebruiker.GebruikersRol.KanBewerkenTxt = bool.Parse(nodeGebruiker.ChildNodes[11].InnerText);
                    dezeGebruiker.GebruikersRol.KanAanmakenTxt = bool.Parse(nodeGebruiker.ChildNodes[12].InnerText);
                    dezeGebruiker.GebruikersRol.KanLezenTxt = bool.Parse(nodeGebruiker.ChildNodes[13].InnerText);
                    dezeGebruiker.GebruikersRol.KanEncrypterenTxt = bool.Parse(nodeGebruiker.ChildNodes[14].InnerText);
                    dezeGebruiker.GebruikersRol.KanBewerkenJson = bool.Parse(nodeGebruiker.ChildNodes[15].InnerText);
                    dezeGebruiker.GebruikersRol.KanAanmakenJson = bool.Parse(nodeGebruiker.ChildNodes[16].InnerText);
                    dezeGebruiker.GebruikersRol.KanLezenJson = bool.Parse(nodeGebruiker.ChildNodes[17].InnerText);
                    dezeGebruiker.GebruikersRol.KanEncrypterenJson = bool.Parse(nodeGebruiker.ChildNodes[18].InnerText);
                    LijstGebruikers.Add(dezeGebruiker);
                }
            }
        }

    }
}
