using System.Xml;
using WinFormsApp2;

namespace Groep_project_2
{
    public partial class FrmWerknemerVerwijderen : Form
    {
        public FrmWerknemerVerwijderen()
        {
            InitializeComponent();
        }
        public Gebruiker ingelogdeGebruikerWerknemerVerwijderen = new Gebruiker();
        List<Gebruiker> LijstGebruikers = new List<Gebruiker>();
        List<Gebruiker> LijstGebruikersMetZelfdeAfdeling = new List<Gebruiker>();
        private void FrmWerknemerVerwijderen_Load(object sender, EventArgs e) //Todo: Inladen via afdeling , had hier wat geprobeerd - Illya
        {
            GebruikersInlezen();
            foreach (Gebruiker gebruiker in LijstGebruikers)
            {
                foreach (Afdeling afdelingGebruiker in gebruiker.LijstAfdelingen)
                {
                    foreach (Afdeling afdelingIngelogdeGebruiker in ingelogdeGebruikerWerknemerVerwijderen.LijstAfdelingen)
                    {
                        if (afdelingGebruiker.Naam == afdelingIngelogdeGebruiker.Naam && gebruiker.Guid != ingelogdeGebruikerWerknemerVerwijderen.Guid)
                        {
                            LijstGebruikersMetZelfdeAfdeling.Add(gebruiker);
                        }
                    }
                }
            }
            cmbWerknemers.DataSource = null;
            cmbWerknemers.DataSource = LijstGebruikersMetZelfdeAfdeling;
        }
        private void btnVerwijderen_Click(object sender, EventArgs e)  // Dit zou altijd moeten werken, werkte voor grondstoffen :)
        {
            DialogResult result = MessageBox.Show($"Weet u zeker dat u {cmbWerknemers.SelectedItem} wilt verwijderen?", "Gebruiker verwijderen", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                LijstGebruikers.Remove((Gebruiker)cmbWerknemers.SelectedItem);
                LijstGebruikersMetZelfdeAfdeling.Remove((Gebruiker)cmbWerknemers.SelectedItem);
                cmbWerknemers.DataSource = null;
                cmbWerknemers.DataSource = LijstGebruikersMetZelfdeAfdeling;
                GebruikersSchrijven();
            }
        }

        private void btnAnnuleren_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //methodes
        private void GebruikersInlezen()
        {
            if (System.IO.File.Exists("Gebruikers.xml"))
            {
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
        private void GebruikersSchrijven()
        {
            XmlDocument xmlDoc = new XmlDocument();

            XmlElement mainRoot = xmlDoc.CreateElement("Gebruikers");
            xmlDoc.AppendChild(mainRoot);

            foreach (Gebruiker dezeGebruiker in LijstGebruikers)
            {
                XmlElement root = xmlDoc.CreateElement("Gebruiker");
                mainRoot.AppendChild(root);

                XmlElement gebruikersID = xmlDoc.CreateElement("ID");
                gebruikersID.InnerText = dezeGebruiker.Guid.ToString();
                root.AppendChild(gebruikersID);

                XmlElement gebruikersNaam = xmlDoc.CreateElement("Naam");
                gebruikersNaam.InnerText = dezeGebruiker.GebruikersNaam;
                root.AppendChild(gebruikersNaam);

                XmlElement gebruikersVoornaam = xmlDoc.CreateElement("Voornaam");
                gebruikersVoornaam.InnerText = dezeGebruiker.GebruikersVoornaam;
                root.AppendChild(gebruikersVoornaam);

                XmlElement paswoord = xmlDoc.CreateElement("Paswoord");
                paswoord.InnerText = dezeGebruiker.Paswoord;
                root.AppendChild(paswoord);

                XmlElement afdelingen = xmlDoc.CreateElement("Afdelingen");
                foreach (Afdeling dezeAfdeling in dezeGebruiker.LijstAfdelingen)
                {
                    XmlElement afdeling = xmlDoc.CreateElement("Afdeling");
                    afdelingen.AppendChild(afdeling);

                    XmlElement afdelingsNaam = xmlDoc.CreateElement("Naam");
                    afdelingsNaam.InnerText = dezeAfdeling.Naam;
                    afdeling.AppendChild(afdelingsNaam);

                    XmlElement afdelingsID = xmlDoc.CreateElement("ID");
                    afdelingsID.InnerText = dezeAfdeling.Guid.ToString();
                    afdeling.AppendChild(afdelingsID);
                }
                root.AppendChild(afdelingen);

                XmlElement RolNaam = xmlDoc.CreateElement("RolNaam");
                RolNaam.InnerText = dezeGebruiker.GebruikersRol.Naam;
                root.AppendChild(RolNaam);

                XmlElement rolID = xmlDoc.CreateElement("RolID");
                rolID.InnerText = dezeGebruiker.GebruikersRol.Guid.ToString();
                root.AppendChild(rolID);

                XmlElement xmlBewerken = xmlDoc.CreateElement("XMLBewerken");
                xmlBewerken.InnerText = dezeGebruiker.GebruikersRol.KanBewerkenXml.ToString();
                root.AppendChild(xmlBewerken);

                XmlElement xmlAanmaken = xmlDoc.CreateElement("XMLAanmaken");
                xmlAanmaken.InnerText = dezeGebruiker.GebruikersRol.KanAanmakenXml.ToString();
                root.AppendChild(xmlAanmaken);

                XmlElement xmlLezen = xmlDoc.CreateElement("XMLLezen");
                xmlLezen.InnerText = dezeGebruiker.GebruikersRol.KanLezenXml.ToString();
                root.AppendChild(xmlLezen);

                XmlElement xmlEncrypteren = xmlDoc.CreateElement("XMLEncrypteren");
                xmlEncrypteren.InnerText = dezeGebruiker.GebruikersRol.KanEncrypterenXml.ToString();
                root.AppendChild(xmlEncrypteren);

                XmlElement txtBewerken = xmlDoc.CreateElement("TXTBewerken");
                txtBewerken.InnerText = dezeGebruiker.GebruikersRol.KanBewerkenTxt.ToString();
                root.AppendChild(txtBewerken);

                XmlElement txtAanmaken = xmlDoc.CreateElement("TXTAanmaken");
                txtAanmaken.InnerText = dezeGebruiker.GebruikersRol.KanAanmakenTxt.ToString();
                root.AppendChild(txtAanmaken);

                XmlElement txtLezen = xmlDoc.CreateElement("TXTLezen");
                txtLezen.InnerText = dezeGebruiker.GebruikersRol.KanLezenTxt.ToString();
                root.AppendChild(txtLezen);

                XmlElement txtEncrypteren = xmlDoc.CreateElement("TXTEncrypteren");
                txtEncrypteren.InnerText = dezeGebruiker.GebruikersRol.KanEncrypterenTxt.ToString();
                root.AppendChild(txtEncrypteren);

                XmlElement jsonBewerken = xmlDoc.CreateElement("JSONBewerken");
                jsonBewerken.InnerText = dezeGebruiker.GebruikersRol.KanBewerkenJson.ToString();
                root.AppendChild(jsonBewerken);

                XmlElement jsonAanmaken = xmlDoc.CreateElement("JSONAanmaken");
                jsonAanmaken.InnerText = dezeGebruiker.GebruikersRol.KanAanmakenJson.ToString();
                root.AppendChild(jsonAanmaken);

                XmlElement jsonLezen = xmlDoc.CreateElement("JSONLezen");
                jsonLezen.InnerText = dezeGebruiker.GebruikersRol.KanLezenJson.ToString();
                root.AppendChild(jsonLezen);

                XmlElement jsonEncrypteren = xmlDoc.CreateElement("JSONEncrypteren");
                jsonEncrypteren.InnerText = dezeGebruiker.GebruikersRol.KanEncrypterenJson.ToString();
                root.AppendChild(jsonEncrypteren);
            }
            xmlDoc.Save("Gebruikers.xml");
        }
    }
}
