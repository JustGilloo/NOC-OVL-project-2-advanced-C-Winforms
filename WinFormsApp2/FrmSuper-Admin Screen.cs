using Groep_project_2;
using System.Xml;

namespace WinFormsApp2
{
    public partial class Super_Admin_Screen : Form
    {
        public Super_Admin_Screen()
        {
            InitializeComponent();
        }
        char[] symbolen;
        char[] sleutel;
        string inhoud;
        string bestandinhoud;
        string pad;
        public Gebruiker ingelogdeGebruikerSuperAdmin = new Gebruiker();
        private List<GebruikersRol> lijstGebruikersrollen = new List<GebruikersRol>();
        private List<Gebruiker> lijstGebruikers = new List<Gebruiker>();
        public List<Afdeling> lijstAfdelingen = new List<Afdeling>();
        public List<Afdeling> lijstMeegegevenAfdeling = new List<Afdeling>();
        public List<GebruikersRol> LijstGebruikersrollen
        {
            get { return lijstGebruikersrollen; }
            set { lijstGebruikersrollen = value; }
        }
        public List<Gebruiker> LijstGebruikers
        {
            get { return lijstGebruikers; }
            set { lijstGebruikers = value; }
        }
        public List<Afdeling> LijstAfdelingen
        {
            get { return lijstAfdelingen; }
            set { lijstAfdelingen = value; }
        }
        public List<Afdeling> LijstMeegegevenAfdelingen
        {
            get { return lijstMeegegevenAfdeling; }
            set { lijstMeegegevenAfdeling = value; }
        }
        private void Super_Admin_Screen_Load(object sender, EventArgs e) //we gaan wat afdelingen hardcoden en erin steken, we moeten nog een list maken van rollen en opvullen
        {
            symbolen = "' !\"#$%&()*+,-.\\/0123456789:<=>@?ABCDEFGHIJKLMNOPQRSTUVWXYZ[]^_`abcdefghijklmnopqrstuvwxyz{|}~;éèêëûüôöîïâäà\r\n".ToCharArray();
            sleutel = new char[symbolen.Length];
            inhoud = string.Join("", symbolen);
            RollenInlezen();
            AfdelingenInlezen();
            cmbAfdelingen.DataSource = null;
            cmbGebruikersRol.DataSource = LijstGebruikersrollen;
            cmbAfdelingen.DataSource = LijstAfdelingen;
            GebruikersInlezen();
        }

        private void btnAanmakenRol_Click(object sender, EventArgs e)
        {
            try
            {
                GebruikersRol mijnGebruikersRol = new GebruikersRol(textBox1.Text, cbXMLBewerken.Checked, cbXMLAanmaken.Checked, cbXMLLezen.Checked, cbXMLEncoderen.Checked, cbTXTBewerken.Checked, cbTXTAanmaken.Checked, cbTXTLezen.Checked, cbTXTEncoderen.Checked, cbJSONBewerken.Checked, cbJSONAanmaken.Checked, cbJSONLezen.Checked, cbJSONEncoderen.Checked);
                if (!(String.IsNullOrEmpty(textBox1.Text)))
                {
                    LijstGebruikersrollen.Add(mijnGebruikersRol);
                    RollenSchrijven();
                    cmbGebruikersRol.DataSource = null;
                    cmbGebruikersRol.DataSource = LijstGebruikersrollen;
                    MessageBox.Show("De rol is succesvol aangemaakt.", "Succes", MessageBoxButtons.OK);
                }
                else
                {
                    throw new wrongInputException("U gaf niet de juiste waarde in.");
                }
            }
            catch (wrongInputException wie)
            {
                MessageBox.Show(wie.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGebruikerAanmaken_Click_1(object sender, EventArgs e) //we moeten hem nog in een gebruikerslijst steken
        {
            try
            {
                if (!(String.IsNullOrEmpty(txtGebruikerNaam.Text)) || (!(String.IsNullOrEmpty(txtGebruikerVoornaam.Text))) || (!(String.IsNullOrEmpty(txtGebruikerPaswoord.Text))))
                { //nieuwe lijst maken en dan een lijst met 1 enkele input
                    lijstMeegegevenAfdeling = new List<Afdeling>();
                    lijstMeegegevenAfdeling.Add((Afdeling)cmbAfdelingen.SelectedItem);
                    Gebruiker gebruiker = new Gebruiker((GebruikersRol)cmbGebruikersRol.SelectedItem, txtGebruikerNaam.Text, txtGebruikerVoornaam.Text, txtGebruikerPaswoord.Text, LijstMeegegevenAfdelingen);
                    LijstGebruikers.Add(gebruiker);
                    GebruikersSchrijven(); ;
                    MessageBox.Show("De gebruiker is succesvol aangemaakt.", "Succes", MessageBoxButtons.OK);
                }
                else
                {
                    throw new wrongInputException("U gaf niet de juiste waarde in.");
                }
            }
            catch (wrongInputException wie)
            {
                MessageBox.Show(wie.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnAanmakenAfdeling_Click(object sender, EventArgs e)
        {
            try
            {
                Afdeling newAfdeling = new Afdeling(txtAanmakenAfdeling.Text, txtAfdelingBeschrijving.Text);
                LijstAfdelingen.Add(newAfdeling);
                AfdelingenSchrijven();
                cmbAfdelingen.DataSource = null;
                cmbAfdelingen.DataSource = lijstAfdelingen;
                MessageBox.Show("De afdeling is succesvol aangemaakt.", "Succes", MessageBoxButtons.OK);
            }
            catch (wrongInputException wie)
            {
                MessageBox.Show(wie.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCheckAll_Click_1(object sender, EventArgs e)
        {
            cbXMLAanmaken.Checked = true;
            cbXMLBewerken.Checked = true;
            cbXMLLezen.Checked = true;
            cbXMLEncoderen.Checked = true;
            cbTXTAanmaken.Checked = true;
            cbTXTBewerken.Checked = true;
            cbTXTLezen.Checked = true;
            cbTXTEncoderen.Checked = true;
            cbJSONAanmaken.Checked = true;
            cbJSONBewerken.Checked = true;
            cbJSONLezen.Checked = true;
            cbJSONEncoderen.Checked = true;
        }

        private void btnUncheckAll_Click_1(object sender, EventArgs e)
        {
            cbXMLAanmaken.Checked = false;
            cbXMLBewerken.Checked = false;
            cbXMLLezen.Checked = false;
            cbXMLEncoderen.Checked = false;
            cbTXTAanmaken.Checked = false;
            cbTXTBewerken.Checked = false;
            cbTXTLezen.Checked = false;
            cbTXTEncoderen.Checked = false;
            cbJSONAanmaken.Checked = false;
            cbJSONBewerken.Checked = false;
            cbJSONLezen.Checked = false;
            cbJSONEncoderen.Checked = false;
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
        private void RollenSchrijven()
        {
            XmlDocument xmlDoc = new XmlDocument();

            XmlElement mainRoot = xmlDoc.CreateElement("Rollen");
            xmlDoc.AppendChild(mainRoot);

            foreach (GebruikersRol dezeRol in LijstGebruikersrollen)
            {
                XmlElement root = xmlDoc.CreateElement("Rol");
                mainRoot.AppendChild(root);

                XmlElement rolNaam = xmlDoc.CreateElement("Naam");
                rolNaam.InnerText = dezeRol.Naam;
                root.AppendChild(rolNaam);

                XmlElement rolID = xmlDoc.CreateElement("RolID");
                rolID.InnerText = dezeRol.Guid.ToString();
                root.AppendChild(rolID);

                XmlElement xmlBewerken = xmlDoc.CreateElement("XMLBewerken");
                xmlBewerken.InnerText = dezeRol.KanBewerkenXml.ToString();
                root.AppendChild(xmlBewerken);

                XmlElement xmlAanmaken = xmlDoc.CreateElement("XMLAanmaken");
                xmlAanmaken.InnerText = dezeRol.KanAanmakenXml.ToString();
                root.AppendChild(xmlAanmaken);

                XmlElement xmlLezen = xmlDoc.CreateElement("XMLLezen");
                xmlLezen.InnerText = dezeRol.KanLezenXml.ToString();
                root.AppendChild(xmlLezen);

                XmlElement xmlEncrypteren = xmlDoc.CreateElement("XMLEncrypteren");
                xmlEncrypteren.InnerText = dezeRol.KanEncrypterenXml.ToString();
                root.AppendChild(xmlEncrypteren);

                XmlElement txtBewerken = xmlDoc.CreateElement("TXTBewerken");
                txtBewerken.InnerText = dezeRol.KanBewerkenTxt.ToString();
                root.AppendChild(txtBewerken);

                XmlElement txtAanmaken = xmlDoc.CreateElement("TXTAanmaken");
                txtAanmaken.InnerText = dezeRol.KanAanmakenTxt.ToString();
                root.AppendChild(txtAanmaken);

                XmlElement txtLezen = xmlDoc.CreateElement("TXTLezen");
                txtLezen.InnerText = dezeRol.KanLezenTxt.ToString();
                root.AppendChild(txtLezen);

                XmlElement txtEncrypteren = xmlDoc.CreateElement("TXTEncrypteren");
                txtEncrypteren.InnerText = dezeRol.KanEncrypterenTxt.ToString();
                root.AppendChild(txtEncrypteren);

                XmlElement jsonBewerken = xmlDoc.CreateElement("JSONBewerken");
                jsonBewerken.InnerText = dezeRol.KanBewerkenJson.ToString();
                root.AppendChild(jsonBewerken);

                XmlElement jsonAanmaken = xmlDoc.CreateElement("JSONAanmaken");
                jsonAanmaken.InnerText = dezeRol.KanAanmakenJson.ToString();
                root.AppendChild(jsonAanmaken);

                XmlElement jsonLezen = xmlDoc.CreateElement("JSONLezen");
                jsonLezen.InnerText = dezeRol.KanLezenJson.ToString();
                root.AppendChild(jsonLezen);

                XmlElement jsonEncrypteren = xmlDoc.CreateElement("JSONEncrypteren");
                jsonEncrypteren.InnerText = dezeRol.KanEncrypterenJson.ToString();
                root.AppendChild(jsonEncrypteren);
            }
            xmlDoc.Save("Gebruikersrollen.xml");
        }
        public void RollenInlezen()
        {
            if (System.IO.File.Exists("Gebruikersrollen.xml"))
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load("Gebruikersrollen.xml");

                XmlNodeList nodeGebruikersrollen = xmlDoc.SelectNodes("//Rol");
                foreach (XmlNode nodeRol in nodeGebruikersrollen)
                {
                    GebruikersRol dezeRol = new GebruikersRol();
                    dezeRol.Naam = nodeRol.ChildNodes[0].InnerText;
                    dezeRol.Guid = Guid.Parse(nodeRol.ChildNodes[1].InnerText);

                    dezeRol.KanBewerkenXml = bool.Parse(nodeRol.ChildNodes[2].InnerText);
                    dezeRol.KanAanmakenXml = bool.Parse(nodeRol.ChildNodes[3].InnerText);
                    dezeRol.KanLezenXml = bool.Parse(nodeRol.ChildNodes[4].InnerText);
                    dezeRol.KanEncrypterenXml = bool.Parse(nodeRol.ChildNodes[5].InnerText);
                    dezeRol.KanBewerkenTxt = bool.Parse(nodeRol.ChildNodes[6].InnerText);
                    dezeRol.KanAanmakenTxt = bool.Parse(nodeRol.ChildNodes[7].InnerText);
                    dezeRol.KanLezenTxt = bool.Parse(nodeRol.ChildNodes[8].InnerText);
                    dezeRol.KanEncrypterenTxt = bool.Parse(nodeRol.ChildNodes[9].InnerText);
                    dezeRol.KanBewerkenJson = bool.Parse(nodeRol.ChildNodes[10].InnerText);
                    dezeRol.KanAanmakenJson = bool.Parse(nodeRol.ChildNodes[11].InnerText);
                    dezeRol.KanLezenJson = bool.Parse(nodeRol.ChildNodes[12].InnerText);
                    dezeRol.KanEncrypterenJson = bool.Parse(nodeRol.ChildNodes[13].InnerText);
                    LijstGebruikersrollen.Add(dezeRol);
                }
            }
            else
            {
                GebruikersRollenResetten(); //in case van verloren bestand
            }
        }
        private void AfdelingenSchrijven()
        {
            XmlDocument xmlDoc = new XmlDocument();

            XmlElement mainRoot = xmlDoc.CreateElement("Afdelingen");
            xmlDoc.AppendChild(mainRoot);

            foreach (Afdeling dezeAfdeling in LijstAfdelingen)
            {
                XmlElement root = xmlDoc.CreateElement("Afdeling");
                mainRoot.AppendChild(root);

                XmlElement afdelingNaam = xmlDoc.CreateElement("Naam");
                afdelingNaam.InnerText = dezeAfdeling.Naam;
                root.AppendChild(afdelingNaam);

                XmlElement afdelingId = xmlDoc.CreateElement("ID");
                afdelingId.InnerText = dezeAfdeling.Guid.ToString();
                root.AppendChild(afdelingId);

                XmlElement afdelingBeschrijving = xmlDoc.CreateElement("Beschrijving");
                afdelingBeschrijving.InnerText = dezeAfdeling.Omschrijving.ToString();
                root.AppendChild(afdelingBeschrijving);
            }
            xmlDoc.Save("Afdelingen.xml");
        }
        public void AfdelingenInlezen()
        {
            if (System.IO.File.Exists("Afdelingen.xml"))
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load("Afdelingen.xml");
                XmlNodeList nodeGebruikersAfdelingen = xmlDoc.SelectNodes("//Afdeling");
                foreach (XmlNode nodeAfdeling in nodeGebruikersAfdelingen)
                {
                    Afdeling dezeAfdeling = new Afdeling();
                    dezeAfdeling.Naam = nodeAfdeling.ChildNodes[0].InnerText;
                    dezeAfdeling.Guid = Guid.Parse(nodeAfdeling.ChildNodes[1].InnerText);
                    dezeAfdeling.Omschrijving = nodeAfdeling.ChildNodes[2].InnerText;
                    lijstAfdelingen.Add(dezeAfdeling);
                }
            }
            else
            {
                AfdelingenResetten(); //in case van verloren bestand
            }
        }
        private void GebruikersRollenResetten()
        {
            GebruikersRol admin = new GebruikersRol("admin", true, true, true, true, true, true, true, true, true, true, true, true); //doet nietn
            GebruikersRol manager = new GebruikersRol("manager", true, true, true, true, true, true, true, true, true, true, true, true); //checkt alle werknemers
            GebruikersRol stock_managment = new GebruikersRol("stock medewerker", true, true, true, true, true, true, true, true, true, true, true, true); //checkt de stock
            GebruikersRol verkoper = new GebruikersRol("verkoper", true, true, true, true, true, true, true, true, true, true, true, true); //verminderd onze stock, verstuurt mails naar klanten en doet andere dingen
            GebruikersRol boer = new GebruikersRol("boer", true, true, true, true, true, true, true, true, true, true, true, true); //vermeerdigdtdtdt onze stock
            GebruikersRol admin_medewerker = new GebruikersRol("administrative medewerker", true, true, true, true, true, true, true, true, true, true, true, true);
            LijstGebruikersrollen.Add(admin);
            LijstGebruikersrollen.Add(manager);
            LijstGebruikersrollen.Add(stock_managment);
            LijstGebruikersrollen.Add(verkoper);
            LijstGebruikersrollen.Add(boer);
            LijstGebruikersrollen.Add(admin_medewerker);
            RollenSchrijven(); //later verwijderen, nu enkel voor bij de opstart bij lege opstart
        }
        private void AfdelingenResetten()
        {
            Afdeling afdeling1 = new Afdeling("Verkoop", "Het verkopen van producten.");
            Afdeling afdeling2 = new Afdeling("Boer", "Bewerkt het land en onze machines.");
            Afdeling afdeling3 = new Afdeling("Stock-managment", "Het in de gaten houden van onze stock.");
            Afdeling afdeling4 = new Afdeling("Administratie", "Deze doet al onze papieren.");
            Afdeling afdeling5 = new Afdeling("Admin", "Zij die overal alles mogen");
            LijstAfdelingen.Add(afdeling1);
            LijstAfdelingen.Add(afdeling2);
            LijstAfdelingen.Add(afdeling3);
            LijstAfdelingen.Add(afdeling4);
            LijstAfdelingen.Add(afdeling5);
            AfdelingenSchrijven();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }//button 2 is sluiten op de FrmSuper-Admin

        private void btnRenewKey_Click(object sender, EventArgs e)
        {
            {
                Random random = new Random();
                int randomNumber;
                char[] sleutelSymbolen = "' !\"#$%&()*+,-.\\/0123456789:<=>@?ABCDEFGHIJKLMNOPQRSTUVWXYZ[]^_`abcdefghijklmnopqrstuvwxyz{|}~;éèêëûüôöîïâäà\r\n".ToCharArray();
                for (int i = 0; i < sleutelSymbolen.Length; i++)
                {
                    do
                    {
                        randomNumber = random.Next(0, sleutelSymbolen.Length);
                    } while (sleutelSymbolen[randomNumber] == 'µ');

                    sleutel[i] = sleutelSymbolen[randomNumber];
                    sleutelSymbolen[randomNumber] = 'µ';                                   // omdat we spatie ook encrypteren , gebruiken we hier een character dat we nooit gaan typen ipv spatie (kan mss ook anders?)
                }
                SaveFileDialog saveFileDialog1 = new SaveFileDialog()
                {
                    InitialDirectory = @"C:\", //Todo: Proberen rechtstreeks in sleutels te openen (eventueel)
                    Title = "Kies bestandslocatie",

                    CheckFileExists = false,
                    CheckPathExists = true,

                    DefaultExt = "",
                    Filter = "TXT files (*.txt)|*.txt|XML files (*.xml)|*.xml|JSON files (*.json)|*.json|All files (*.*)|*.*",
                    AddExtension = true,
                    FilterIndex = 4,
                    RestoreDirectory = false,
                };

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    pad = saveFileDialog1.FileName;
                    saveFileDialog1.RestoreDirectory = true;
                    if (pad.Contains(".txt"))
                    {
                        saveFileDialog1.DefaultExt = ".txt";
                        SleutelSchrijven();
                    }
                    else
                    {
                        MessageBox.Show("Onze sleutels zijn in txt :)");
                    }
                }
            }
        }

        private void btnDisplayKeys_Click(object sender, EventArgs e)
        {
            bestandinhoud = "";
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Bestand kiezen",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "",
                Filter = "TXT files (*.txt)|*.txt|XML files (*.xml)|*.xml|JSON files (*.json)|*.json|All files (*.*)|*.*",
                AddExtension = true,
                FilterIndex = 4,
                RestoreDirectory = false,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pad = openFileDialog1.FileName;
                if (pad.Contains(".txt"))
                {
                    openFileDialog1.DefaultExt = ".txt";
                    TXTSInlezen();
                    txtPad.Text = pad;
                }
            }
        }
        public void TXTSInlezen()
        {
            using (StreamReader reader = new StreamReader(pad))
            {
                while (!reader.EndOfStream)
                {
                    bestandinhoud += reader.ReadLine() + Environment.NewLine;
                }
                txtSleutel.Text = bestandinhoud.ToString();
            }
        }
        public void SleutelSchrijven()
        {
            using (StreamWriter writer = new StreamWriter(pad))
            {

                writer.WriteLine(sleutel);
            }
        }

        private void btnUitloggen_Click(object sender, EventArgs e)
        {
            if (ingelogdeGebruikerSuperAdmin.GebruikersRol == null)
            {
                Form1 form1 = new Form1();
                form1.Uitloggen();
            }
            else if (ingelogdeGebruikerSuperAdmin.GebruikersRol.Naam == "admin")
            {
                this.Close();
            }
        }
    }
}
