using Groep_project_2;
using System.Xml;

namespace WinFormsApp2
{
    public partial class FrmLoginPage : Form
    {
        public FrmLoginPage()
        {
            InitializeComponent();
        }
        static string superAdminNaam = "Hans";
        static string superAdminPaswoord = "123";
        public List<Gebruiker> lijstWerknemersInloggen = new List<Gebruiker>();
        public Gebruiker ingelogdeGebruikerLogin = new Gebruiker();
        private void LoginPage_Load(object sender, EventArgs e)
        {
            timer1.Start();
            GebruikersInlezen();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(String.IsNullOrEmpty(txtWachtwoord.Text) || String.IsNullOrEmpty(txtNaam.Text)))
                {
                    bool check = true;
                    if (txtNaam.Text == superAdminNaam && txtWachtwoord.Text == superAdminPaswoord)
                    {
                        Super_Admin_Screen frmSuperAdmin = new Super_Admin_Screen(); //inloggen als super admin
                        check = false;
                        frmSuperAdmin.ShowDialog();
                        //DialogResult = DialogResult.OK;
                    }
                    foreach (Gebruiker x in lijstWerknemersInloggen)
                    {
                        if (txtNaam.Text == x.GebruikersVoornaam && txtWachtwoord.Text == x.Paswoord)
                        {
                            ingelogdeGebruikerLogin = x;
                            DialogResult = DialogResult.OK;
                            check = false;
                            break;
                        }
                    }
                    if (check)
                    {
                        throw new wrongInputException("Je gebruikersnaam en wachtwoord zijn niet gekend in het systeem.");
                    }
                }
                else
                {
                    throw new wrongInputException("Je dient een geldige gebruikersnaam en wachtwoord in te geven.");
                }
            }
            catch (wrongInputException wie)
            {
                MessageBox.Show(wie.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAfsluiten_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void GebruikersInlezen()
        {
            if (System.IO.File.Exists("Gebruikers.xml"))
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

                        XmlNodeList nodesAfdelingen = nodeGebruiker.SelectNodes(".//Afdelingen/Afdeling"); //HIER ZIT DE FOUT, ZET ER EEN PUNT BIJ VOOR UW BACKSLASH
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
                        lijstWerknemersInloggen.Add(dezeGebruiker);
                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDatum.Text = DateTime.Now.ToLongDateString();
            lblTijd.Text = DateTime.Now.ToLongTimeString();
        }
    }
}

