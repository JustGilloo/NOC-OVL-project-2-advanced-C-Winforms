using Groep_project_2;

namespace WinFormsApp2
{
    public partial class Admin_Screen : Form
    {
        public Admin_Screen()
        {
            InitializeComponent();
        }
        char[] symbolen;
        char[] sleutel;
        string inhoud;
        public Gebruiker ingelogdeGebruikerAdmin = new Gebruiker();
        private void Admin_Screen_Load(object sender, EventArgs e)
        {
            symbolen = "' !\"#$%&'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[]^_`abcdefghijklmnopqrstuvwxyz{|}~';éèêëûüôöîïâäà@\r\n".ToCharArray();
            sleutel = new char[symbolen.Length];
            inhoud = string.Join("", symbolen);
            lblWelkomAdmin.Text = "Welkom " + ingelogdeGebruikerAdmin.GebruikersVoornaam.ToString() + "!";
        }
        private void lezenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBestandLezen frmBestandLezen = new FrmBestandLezen();
            frmBestandLezen.Text = "Bestand lezen";
            frmBestandLezen.txtBestandInhoud.Enabled = false;
            frmBestandLezen.btnBestandOpslaan.Enabled = false;
            frmBestandLezen.btnBestandOpslaan.Visible = false;

            frmBestandLezen.ShowDialog();
        }

        private void bewerkenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmBestandLezen frmBestandLezen = new FrmBestandLezen();
            frmBestandLezen.Text = "Bestand bewerken";
            frmBestandLezen.ShowDialog();
        }

        private void verwijderenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmBestandVerwijderen frmBestandVerwijderen = new FrmBestandVerwijderen();
            frmBestandVerwijderen.ShowDialog();
        }

        private void vernieuwenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                Random random = new Random();
                int randomNumber;
                char[] sleutelSymbolen = "' !\"#$%&'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[]^_`abcdefghijklmnopqrstuvwxyz{|}~';éèêëûüôöîïâäà@\r\n".ToCharArray();
                for (int i = 0; i < sleutelSymbolen.Length; i++)
                {
                    do
                    {
                        randomNumber = random.Next(0, sleutelSymbolen.Length);
                    } while (sleutelSymbolen[randomNumber] == 'µ');

                    sleutel[i] = sleutelSymbolen[randomNumber];
                    sleutelSymbolen[randomNumber] = 'µ';                                   // omdat we spatie ook encrypteren , gebruiken we hier een character dat we nooit gaan typen ipv spatie (kan mss ook anders?)
                }
                SchrijfStringWeg(string.Join("", sleutel), "sleutel.txt");

            }
        }
        private static void SchrijfStringWeg(string mijnStringParameter, string bronTxt)// TODO : Cleaning > als sleutel bestaat , oude sleutel in een lijst/aparte file opslagen?
        {
            string inhoud = "";
            if (System.IO.File.Exists(bronTxt))
            {
                StreamReader mijnReader = new StreamReader(bronTxt);
                inhoud = mijnReader.ReadToEnd();
                mijnReader.Close();
            }

            using (StreamWriter mijnWriter = new StreamWriter(bronTxt))
            {
                {
                    mijnWriter.WriteLine(mijnStringParameter);
                }
            }
        }

        private void SuperAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Super_Admin_Screen frmSuperAdmin = new Super_Admin_Screen(); //inloggen als super admin
            frmSuperAdmin.ingelogdeGebruikerSuperAdmin = ingelogdeGebruikerAdmin;
            frmSuperAdmin.btnUitloggen.Text = "Terugkeren";
            frmSuperAdmin.ShowDialog();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Uitloggen();
        }

        private void aanmakenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmWerknemerAanmaken frmWerknemerAanmaken = new FrmWerknemerAanmaken();
            frmWerknemerAanmaken.cmbWerknemer.Enabled = false;
            frmWerknemerAanmaken.cmbWerknemer.Visible = false;
            frmWerknemerAanmaken.lblWerknemer.Enabled = false;
            frmWerknemerAanmaken.lblWerknemer.Visible = false;
            frmWerknemerAanmaken.ingelogdeGebruikerWerknemerMaken = ingelogdeGebruikerAdmin;
            frmWerknemerAanmaken.ShowDialog();
        }
        private void bewerkenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmWerknemerAanmaken frmWerknemerAanmaken = new FrmWerknemerAanmaken();
            frmWerknemerAanmaken.ingelogdeGebruikerWerknemerMaken = ingelogdeGebruikerAdmin;
            frmWerknemerAanmaken.ShowDialog();
        }
        private void verwijderenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmWerknemerVerwijderen frmWerknemerVerwijderen = new FrmWerknemerVerwijderen();
            frmWerknemerVerwijderen.ShowDialog();
        }

        private void afsluitenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTijd.Text = DateTime.Now.ToLongTimeString();
        }
    }
}

