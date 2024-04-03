using System.Xml;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Gebruiker ingelogdeGebruikerForm = new Gebruiker();
        private List<Gebruiker> lstGebruikers = new List<Gebruiker>();
        private List<GebruikersRol> lstGebruikerRol = new List<GebruikersRol>();
        public void Form1_Load(object sender, EventArgs e)
        {
            FrmLoginPage login = new FrmLoginPage();
            login.ShowDialog();
            if (login.DialogResult != DialogResult.OK)
            {
                Application.Exit();
            }
            else //hier komen we in als we een gebruiker herkennen, en nu kijken wie het is
            {
                RollenInlezen();
                ingelogdeGebruikerForm = login.ingelogdeGebruikerLogin;
                if (ingelogdeGebruikerForm.GebruikersRol.Naam == "admin")
                {
                    Admin_Screen frmAdminScreen = new Admin_Screen();
                    frmAdminScreen.ingelogdeGebruikerAdmin = ingelogdeGebruikerForm;
                    DialogResult result = frmAdminScreen.ShowDialog();
                    if (result == DialogResult.Cancel)
                    {
                        Application.Exit();
                    }
                }
                else if (ingelogdeGebruikerForm.GebruikersRol.Naam == "manager")
                {
                    Manager_Screen frmManager = new Manager_Screen();
                    frmManager.Text = "Manager";
                    frmManager.ingelogdeGebruikerManager = ingelogdeGebruikerForm;
                    DialogResult result = frmManager.ShowDialog();
                    if (result == DialogResult.Cancel)
                    {
                        Application.Exit();
                    }
                }
                else if (ingelogdeGebruikerForm.GebruikersRol.Naam == "verkoper")
                {
                    Manager_Screen frmManager = new Manager_Screen();
                    frmManager.Text = "Verkoper";
                    frmManager.ingelogdeGebruikerManager = ingelogdeGebruikerForm;
                    DialogResult result = frmManager.ShowDialog();
                    if (result == DialogResult.Cancel)
                    {
                        Application.Exit();
                    }
                }
                else if (ingelogdeGebruikerForm.GebruikersRol.Naam == "stock medewerker")
                {
                    Manager_Screen frmManager = new Manager_Screen();
                    frmManager.Text = "Stockmedewerker";
                    frmManager.ingelogdeGebruikerManager = ingelogdeGebruikerForm;
                    DialogResult result = frmManager.ShowDialog();
                    if (result == DialogResult.Cancel)
                    {
                        Application.Exit();
                    }
                }
                else if (ingelogdeGebruikerForm.GebruikersRol.Naam == "boer")
                {
                    Manager_Screen frmManager = new Manager_Screen();
                    frmManager.Text = "Boer";
                    frmManager.ingelogdeGebruikerManager = ingelogdeGebruikerForm;
                    DialogResult result = frmManager.ShowDialog();
                    if (result == DialogResult.Cancel)
                    {
                        Application.Exit();
                    }
                }
                else if (ingelogdeGebruikerForm.GebruikersRol.Naam == "administratieve medewerker")
                {
                    Manager_Screen frmManager = new Manager_Screen();
                    frmManager.Text = "administratieve medewerker";
                    frmManager.ingelogdeGebruikerManager = ingelogdeGebruikerForm;
                    DialogResult result = frmManager.ShowDialog();
                    if (result == DialogResult.Cancel)
                    {
                        Application.Exit();
                    }
                }
                else
                {
                    MessageBox.Show("Uw rol is niet bekend. Gelieve een admin te contacteren.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void GebruikersInlezen()
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
                    XmlNodeList nodesAfdelingen = nodeGebruiker.SelectNodes("//Afdelingen/Afdeling");
                    foreach (XmlNode dezeAfdeling in nodesAfdelingen)
                    {
                        Afdeling afdeling1 = new Afdeling();
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
                    lstGebruikers.Add(dezeGebruiker);
                }
            }
        } //TODO: misschien overbodig
        private void RollenInlezen()
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
                    lstGebruikerRol.Add(dezeRol);
                }
            }
        }
        public void Uitloggen()
        {
            DialogResult result = MessageBox.Show("Weet u zeker dat u wilt uitloggen?", "Uitloggen", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Restart();
                Environment.Exit(0);
            }
        }
    }
}
