using System.Media;

namespace Harvest_Moon_0._2
{
    public partial class WerkVeld : Form
    {
        public WerkVeld()
        {
            InitializeComponent();
        }
        private List<Zaad> zaadLijst = new List<Zaad>();
        internal List<Zaad> ZaadLijst
        {
            get { return zaadLijst; }
            set { zaadLijst = value; }
        }
        Zaad[,] werkveld = new Zaad[9, 10];
        Zaad Aardappel = new Zaad("Aardappel", 50, 0, 4, 6, 9, 3, 5, 2, "Een plantje waar we eigenlijk enkel de knollen van willen.");
        Zaad Kruiden = new Zaad("Kruiden", 10, 0, 1, 3, 5, 2, 2, 0.5, "Een verzameling van wilde planten, we weten zelf niet wat er allemaal in zit");
        Zaad SuikerBiet = new Zaad("Suikerbiet", 50, 0, 4, 6, 9, 8, 1, 2, "We kunnen hier suikerklontjes van maken en varkens voederen.");
        Zaad Mais = new Zaad("Mais", 30, 0, 8, 12, 16, 3, 4, 1, "Voor mensen die graai kleine klontjes goud hebben. Of popcorn.");
        Zaad Fruit = new Zaad("Fruit", 15, 0, 2, 4, 6, 5, 2, 2, "Natuurlijke zoete en sappige producten.");
        Zaad Vanille = new Zaad("Vanille", 10, 0, 10, 13, 18, 2, 5, 3, "Een heel gevraagde smaakmaker, voor verschillende dingen.");
        Zaad Chocola = new Zaad("Chocola", 100, 0, 4, 6, 9, 6, 2, 0.5, "Een legal verslaving, helpt als je droevig bent, ook als je blij bent.");
        Zaad Gist = new Zaad("Gist", 50, 0, 4, 6, 9, 3, 5, 2, "Ja, gist groeit op deze manier in een veld, hoe anders?");
        Zaad Water = new Zaad("Water", 25, 0, 2, 3, 4, 1, 0.5, 0.2, "Je had zeker verwacht dat ik water ging laten groeien?");
        int rij = 0;
        int kolom = 0;
        string geselecteerd;
        private void WerkVeld_Load(object sender, EventArgs e)
        {
            ZaadLijstOpvullen();
            VeldSchrijven();
            VeldInlezen();
            for (int i = 0; i < werkveld.GetLength(0); i++)
            {
                for (int j = 0; j < werkveld.GetLength(1); j++)
                {
                    Zaad huidigPlantje = werkveld[i, j];
                    Image huidigeAfbeelding = LaadAfbeelding(huidigPlantje);
                    if (huidigeAfbeelding != null)
                    {
                        // Bereken de design naam van de picturebox op basis van de indexen
                        string designNaam = "pb" + (i * 10 + j + 1).ToString();
                        PictureBox pb = (PictureBox)this.Controls[designNaam];
                        pb.Image = huidigeAfbeelding;
                    }
                }
            }
        }
        private void ZaadLijstOpvullen()
        {

            ZaadLijst.Add(Aardappel);
            ZaadLijst.Add(Kruiden);
            ZaadLijst.Add(SuikerBiet);
            ZaadLijst.Add(Mais);
            ZaadLijst.Add(Fruit);
            ZaadLijst.Add(Vanille);
            ZaadLijst.Add(Chocola);
            ZaadLijst.Add(Gist);
            ZaadLijst.Add(Water);
        }
        private void VeldSchrijven()
        {
            using (var sw = new StreamWriter("VeldOpgeslagenText.txt"))
            {
                for (int i = 0; i < werkveld.GetLength(0); i++)
                {
                    for (int j = 0; j < werkveld.GetLength(1); j++)
                    {
                        sw.WriteLine(werkveld[i, j]);
                    }
                }
                sw.Flush();
                sw.Close();
            }
        }
        private void VeldInlezen()
        {

            string[] mijnArray;
            string ingelezen = "";
            using (var sr = new StreamReader("VeldOpgeslagenText.txt"))
            {
                for (int i = 0; i < werkveld.GetLength(0); i++)
                {
                    for (int j = 0; j < werkveld.GetLength(1); j++)
                    {
                        Zaad huidigPlantje = new Zaad();
                        ingelezen = sr.ReadLine();
                        mijnArray = ingelezen.Split(';');
                        huidigPlantje.Naam = mijnArray[0];
                        werkveld[0, 0] = huidigPlantje;
                    }
                }
            }
        }
        public Image LaadAfbeelding(Zaad plantje)
        {
            if (plantje == null)
            {
                return Image.FromFile("Sprite-Base.jpg");
            }
            switch (plantje.Naam)
            {
                case "Aardappelen":
                    if (plantje.Leeftijd < plantje.ZaadTijd) //zaadjes
                    {
                        Image aardappelZaad = Image.FromFile("Zaadjes.jpg");
                        return aardappelZaad;
                    }
                    else if (plantje.Leeftijd >= plantje.ZaadTijd && plantje.Leeftijd < plantje.HalfGroeiTijd) //small plantje
                    {
                        Image aardappelSmall = Image.FromFile("AardappelenSmall.jpg");
                        return aardappelSmall;
                    }
                    else if (plantje.Leeftijd >= plantje.HalfGroeiTijd && plantje.Leeftijd < plantje.GroeiTijd) //medium plantje
                    {
                        Image aardappelMedium = Image.FromFile("AardappelenMedium.jpg");
                        return aardappelMedium;
                    }
                    else if (plantje.Leeftijd >= plantje.GroeiTijd) //klaar voor oogsten
                    {
                        Image aardappelGroot = Image.FromFile("AardappelenGroot.jpg");
                        return aardappelGroot;
                    }
                    break;
                case "Kruiden":

                    if (plantje.Leeftijd < plantje.ZaadTijd) //zaadjes
                    {
                        Image kruidenZaad = Image.FromFile("Zaadjes.jpg");
                        return kruidenZaad;
                    }
                    else if (plantje.Leeftijd >= plantje.ZaadTijd && plantje.Leeftijd < plantje.HalfGroeiTijd) //small plantje
                    {
                        Image kruidenSmall = Image.FromFile("KruidenSmall.jpg");
                        return kruidenSmall;
                    }
                    else if (plantje.Leeftijd >= plantje.HalfGroeiTijd && plantje.Leeftijd < plantje.GroeiTijd) //medium plantje
                    {
                        Image kruidenMedium = Image.FromFile("KruidenMedium.jpg");
                        return kruidenMedium;
                    }
                    else if (plantje.Leeftijd >= plantje.GroeiTijd) //klaar voor oogsten
                    {
                        Image kruidenGroot = Image.FromFile("KruidenGroot.jpg");
                        return kruidenGroot;
                    }
                    break;
                case "Suikerbiet":
                    if (plantje.Leeftijd < plantje.ZaadTijd) //zaadjes
                    {
                        Image suikerbietZaad = Image.FromFile("Zaadjes.jpg");
                        return suikerbietZaad;
                    }
                    else if (plantje.Leeftijd >= plantje.ZaadTijd && plantje.Leeftijd < plantje.HalfGroeiTijd) //small plantje
                    {
                        Image suikerbietSmall = Image.FromFile("SuikerbietSmall.jpg");
                        return suikerbietSmall;
                    }
                    else if (plantje.Leeftijd >= plantje.HalfGroeiTijd && plantje.Leeftijd < plantje.GroeiTijd) //medium plantje
                    {
                        Image suikerbietMedium = Image.FromFile("SuikerbietMedium.jpg");
                        return suikerbietMedium;
                    }
                    else if (plantje.Leeftijd >= plantje.GroeiTijd) //klaar voor oogsten
                    {
                        Image suikerbietGroot = Image.FromFile("SuikerbietGroot.jpg");
                        return suikerbietGroot;
                    }
                    break;
                case "Mais":
                    if (plantje.Leeftijd < plantje.ZaadTijd) //zaadjes
                    {
                        Image maisZaad = Image.FromFile("Zaadjes.jpg");
                        return maisZaad;
                    }
                    else if (plantje.Leeftijd >= plantje.ZaadTijd && plantje.Leeftijd < plantje.HalfGroeiTijd) //small plantje
                    {
                        Image maisSmall = Image.FromFile("MaisSmall.jpg");
                        return maisSmall;
                    }
                    else if (plantje.Leeftijd >= plantje.HalfGroeiTijd && plantje.Leeftijd < plantje.GroeiTijd) //medium plantje
                    {
                        Image maisMedium = Image.FromFile("MaisMedium.jpg");
                        return maisMedium;
                    }
                    else if (plantje.Leeftijd >= plantje.GroeiTijd) //klaar voor oogsten
                    {
                        Image maisGroot = Image.FromFile("MaisGroot.jpg");
                        return maisGroot;
                    }
                    break;
                case "Fruit":
                    if (plantje.Leeftijd < plantje.ZaadTijd) //zaadjes
                    {
                        Image fruitZaad = Image.FromFile("Zaadjes.jpg");
                        return fruitZaad;
                    }
                    else if (plantje.Leeftijd >= plantje.ZaadTijd && plantje.Leeftijd < plantje.HalfGroeiTijd) //small plantje
                    {
                        Image fruitSmall = Image.FromFile("FruitSmall.jpg");
                        return fruitSmall;
                    }
                    else if (plantje.Leeftijd >= plantje.HalfGroeiTijd && plantje.Leeftijd < plantje.GroeiTijd) //medium plantje
                    {
                        Image fruitMedium = Image.FromFile("FruitMedium.jpg");
                        return fruitMedium;
                    }
                    else if (plantje.Leeftijd >= plantje.GroeiTijd) //klaar voor oogsten
                    {
                        Image fruitGroot = Image.FromFile("FruitGroot.jpg");
                        return fruitGroot;
                    }
                    break;
                case "Vanille":
                    if (plantje.Leeftijd < plantje.ZaadTijd) //zaadjes
                    {
                        Image vanilleZaad = Image.FromFile("Zaadjes.jpg");
                        return vanilleZaad;
                    }
                    else if (plantje.Leeftijd >= plantje.ZaadTijd && plantje.Leeftijd < plantje.HalfGroeiTijd) //small plantje
                    {
                        Image vanilleSmall = Image.FromFile("VanilleSmall.jpg");
                        return vanilleSmall;
                    }
                    else if (plantje.Leeftijd >= plantje.HalfGroeiTijd && plantje.Leeftijd < plantje.GroeiTijd) //medium plantje
                    {
                        Image vanilleMedium = Image.FromFile("VanilleMedium.jpg");
                        return vanilleMedium;
                    }
                    else if (plantje.Leeftijd >= plantje.GroeiTijd) //klaar voor oogsten
                    {
                        Image vanilleGroot = Image.FromFile("VanilleGroot.jpg");
                        return vanilleGroot;
                    }
                    break;
                case "Gist":
                    if (plantje.Leeftijd < plantje.ZaadTijd) //zaadjes
                    {
                        Image gistZaad = Image.FromFile("Zaadjes.jpg");
                        return gistZaad;
                    }
                    else if (plantje.Leeftijd >= plantje.ZaadTijd && plantje.Leeftijd < plantje.HalfGroeiTijd) //small plantje
                    {
                        Image gistSmall = Image.FromFile("GistSmall.jpg");
                        return gistSmall;
                    }
                    else if (plantje.Leeftijd >= plantje.HalfGroeiTijd && plantje.Leeftijd < plantje.GroeiTijd) //medium plantje
                    {
                        Image gistMedium = Image.FromFile("GistMedium.jpg");
                        return gistMedium;
                    }
                    else if (plantje.Leeftijd >= plantje.GroeiTijd) //klaar voor oogsten
                    {
                        Image gistGroot = Image.FromFile("GistGroot.jpg");
                        return gistGroot;
                    }
                    break;
                case "Water":
                    if (plantje.Leeftijd < plantje.ZaadTijd) //zaadjes
                    {
                        Image waterZaad = Image.FromFile("Zaadjes.jpg");
                        return waterZaad;
                    }
                    else if (plantje.Leeftijd >= plantje.ZaadTijd && plantje.Leeftijd < plantje.HalfGroeiTijd) //small plantje
                    {
                        Image waterSmall = Image.FromFile("WaterSmall.jpg");
                        return waterSmall;
                    }
                    else if (plantje.Leeftijd >= plantje.HalfGroeiTijd && plantje.Leeftijd < plantje.GroeiTijd) //medium plantje
                    {
                        Image waterMedium = Image.FromFile("WaterMedium.jpg");
                        return waterMedium;
                    }
                    else if (plantje.Leeftijd >= plantje.GroeiTijd) //klaar voor oogsten
                    {
                        Image waterGroot = Image.FromFile("WaterGroot.jpg");
                        return waterGroot;
                    }
                    break;
                case "Chocola":
                    if (plantje.Leeftijd < plantje.ZaadTijd) //zaadjes
                    {
                        Image chocolaZaad = Image.FromFile("Zaadjes.jpg");
                        return chocolaZaad;
                    }
                    else if (plantje.Leeftijd >= plantje.ZaadTijd && plantje.Leeftijd < plantje.HalfGroeiTijd) //small plantje
                    {
                        Image chocolaSmall = Image.FromFile("ChocolaSmall.jpg");
                        return chocolaSmall;
                    }
                    else if (plantje.Leeftijd >= plantje.HalfGroeiTijd && plantje.Leeftijd < plantje.GroeiTijd) //medium plantje
                    {
                        Image chocolaMedium = Image.FromFile("ChocolaMedium.jpg");
                        return chocolaMedium;
                    }
                    else if (plantje.Leeftijd >= plantje.GroeiTijd) //klaar voor oogsten
                    {
                        Image chocolaGroot = Image.FromFile("ChocolaGroot.jpg");
                        return chocolaGroot;
                    }
                    break;
                default:
                    return Image.FromFile("Sprite-Base.jpg");
            }
            return Image.FromFile("Sprite-Base.jpg");
        }

        private void btnAardappel_Click(object sender, EventArgs e)
        {
            GeluidAfspelen();
            BackgroundReset();
            btnAardappel.BackgroundImage = Image.FromFile("ZaadAardappelenSelected.jpg");
            geselecteerd = "Aardappel";
            txtBeschrijving.Text = null;
            txtBeschrijving.ForeColor = Color.White;
            txtBeschrijving.Text = Aardappel.Beschrijving.ToString();
        }

        private void btnPlanten_Click(object sender, EventArgs e)
        {
            SoundPlayer soundPlayer = new SoundPlayer(@"plant.wav");
            soundPlayer.Play();
            if (geselecteerd == "Aardappel")
            {
                Zaad Aardappel = new Zaad("Aardappelen", 50, 0, 4, 6, 9, 3, 5, 2, "Een plantje waar we eigenlijk enkel de knollen van willen.");
                TextArrayRelation(Aardappel, txtVeld);
                VeldPictureBoxRelation();


            }
            else if (geselecteerd == "Fruit")
            {
                Zaad Fruit = new Zaad("Fruit", 15, 0, 2, 4, 6, 5, 2, 2, "Natuurlijke zoete en sappige producten.");
                TextArrayRelation(Fruit, txtVeld);
                VeldPictureBoxRelation();


            }
            else if (geselecteerd == "Gist")
            {
                Zaad Gist = new Zaad("Gist", 50, 0, 4, 6, 9, 3, 5, 2, "Ja, gist groeit op deze manier in een veld, hoe anders?");
                TextArrayRelation(Gist, txtVeld);
                VeldPictureBoxRelation();

            }
            else if (geselecteerd == "Mais")
            {
                Zaad Mais = new Zaad("Mais", 30, 0, 8, 12, 16, 3, 4, 1, "Voor mensen die graai kleine klontjes goud hebben. Of popcorn.");
                TextArrayRelation(Mais, txtVeld);
                VeldPictureBoxRelation();

            }
            else if (geselecteerd == "Suikerbiet")
            {
                Zaad SuikerBiet = new Zaad("Suikerbiet", 50, 0, 4, 6, 9, 8, 1, 2, "We kunnen hier suikerklontjes van maken en varkens voederen.");
                TextArrayRelation(SuikerBiet, txtVeld);
                VeldPictureBoxRelation();

            }
            else if (geselecteerd == "Vanille")
            {
                Zaad Vanille = new Zaad("Vanille", 10, 0, 10, 13, 18, 2, 5, 3, "Een heel gevraagde smaakmaker, voor verschillende dingen.");
                TextArrayRelation(Vanille, txtVeld);
                VeldPictureBoxRelation();

            }
            else if (geselecteerd == "Water")
            {
                Zaad Water = new Zaad("Water", 25, 0, 2, 3, 4, 1, 0.5, 0.2, "Je had zeker verwacht dat ik water ging laten groeien?");
                TextArrayRelation(Water, txtVeld);
                VeldPictureBoxRelation();

            }
            else if (geselecteerd == "Chocola")
            {
                Zaad Chocola = new Zaad("Chocola", 100, 0, 4, 6, 9, 6, 2, 0.5, "Een legal verslaving, helpt als je droevig bent, ook als je blij bent.");
                TextArrayRelation(Chocola, txtVeld);
                VeldPictureBoxRelation();

            }
            else if (geselecteerd == "Kruiden")
            {
                Zaad Kruiden = new Zaad("Kruiden", 10, 0, 1, 3, 5, 2, 2, 0.5, "Een verzameling van wilde planten, we weten zelf niet wat er allemaal in zit");
                TextArrayRelation(Kruiden, txtVeld);
                VeldPictureBoxRelation();


            }
            kolom = 0;
            rij = 0;


        }

        private void TextArrayRelation(Zaad inputZaad, TextBox tb)
        {
            int kolomPlanten = 0;
            int rijPlanten = 0;
            for (int i = 1; i < 91; i++)
            {
                if (tb.Text == i.ToString())
                {
                    werkveld[rij, kolom] = inputZaad;
                    break;
                }
                if (kolom == 9)
                {
                    kolom = 0;
                    rij++;
                }
                else if (kolom < 9)
                {
                    kolom++;
                }
            }
            kolomPlanten = 0;
            rijPlanten = 0;
        }

        private void btnGroeien_Click(object sender, EventArgs e)
        {
            GeluidAfspelen();
            int teller = 1;
            foreach (Zaad zaad in werkveld)
            {
                if (zaad == null)
                {
                    continue;
                }
                else
                {
                    zaad.Leeftijd = zaad.Leeftijd + 1;
                }

            }
            foreach (Zaad zaad in werkveld)
            {
                if (zaad == null)
                {
                    teller++;
                    continue;
                }
                else
                {
                    ImageUpdateGroeien(teller);
                }
                teller++;
            }
            teller = 0;
        }
        private void BackgroundReset()
        {
            geselecteerd = "";
            btnAardappel.BackgroundImage = Image.FromFile("ZaadAardappelen.jpg");
            btnChocola.BackgroundImage = Image.FromFile("ZaadChocola.jpg");
            btnFruit.BackgroundImage = Image.FromFile("ZaadFruit.jpg");
            btnGist.BackgroundImage = Image.FromFile("ZaadGist.jpg");
            btnKruiden.BackgroundImage = Image.FromFile("ZaadKruiden.jpg");
            btnMais.BackgroundImage = Image.FromFile("ZaadMais.jpg");
            btnSuikerbiet.BackgroundImage = Image.FromFile("ZaadSuikerbiet.jpg");
            btnVanille.BackgroundImage = Image.FromFile("ZaadVanille.jpg");
            btnWater.BackgroundImage = Image.FromFile("ZaadWater.jpg");
        }
        private void VeldPictureBoxRelation()
        {
            switch (txtVeld.Text)
            {
                case "1":
                    pB1.Image = LaadAfbeelding(werkveld[rij, kolom]);
                    break;
                case "2":
                    pB2.Image = LaadAfbeelding(werkveld[rij, kolom]);
                    break;
                case "3":
                    pB3.Image = LaadAfbeelding(werkveld[rij, kolom]);
                    break;
                case "4":
                    pB4.Image = LaadAfbeelding(werkveld[rij, kolom]);
                    break;
                case "5":
                    pB5.Image = LaadAfbeelding(werkveld[rij, kolom]);
                    break;
                case "6":
                    pB6.Image = LaadAfbeelding(werkveld[rij, kolom]);
                    break;
                case "7":
                    pB7.Image = LaadAfbeelding(werkveld[rij, kolom]);
                    break;
                case "8":
                    pB8.Image = LaadAfbeelding(werkveld[rij, kolom]);
                    break;
                case "9":
                    pB9.Image = LaadAfbeelding(werkveld[rij, kolom]);
                    break;
                case "10":
                    pB10.Image = LaadAfbeelding(werkveld[rij, kolom]);
                    break;
                case "11":
                    pB11.Image = LaadAfbeelding(werkveld[rij, kolom]);
                    break;
                case "12":
                    pB12.Image = LaadAfbeelding(werkveld[rij, kolom]);
                    break;
                case "13":
                    pB13.Image = LaadAfbeelding(werkveld[rij, kolom]);
                    break;
                case "14":
                    pB14.Image = LaadAfbeelding(werkveld[rij, kolom]);
                    break;
                case "15":
                    pB15.Image = LaadAfbeelding(werkveld[rij, kolom]);
                    break;
                case "16":
                    pB16.Image = LaadAfbeelding(werkveld[rij, kolom]);
                    break;
                case "17":
                    pB17.Image = LaadAfbeelding(werkveld[rij, kolom]);
                    break;
                case "18":
                    pB18.Image = LaadAfbeelding(werkveld[rij, kolom]);
                    break;
                case "19":
                    pB19.Image = LaadAfbeelding(werkveld[rij, kolom]);
                    break;
                case "20":
                    pB20.Image = LaadAfbeelding(werkveld[rij, kolom]);
                    break;
                case "21":
                    pB21.Image = LaadAfbeelding(werkveld[rij, kolom]);
                    break;
                case "22":
                    pB22.Image = LaadAfbeelding(werkveld[rij, kolom]);
                    break;
                case "23":
                    pB23.Image = LaadAfbeelding(werkveld[rij, kolom]);
                    break;
                case "24":
                    pB24.Image = LaadAfbeelding(werkveld[rij, kolom]);
                    break;
                case "25":
                    pB25.Image = LaadAfbeelding(werkveld[rij, kolom]);
                    break;
                case "26":
                    pB26.Image = LaadAfbeelding(werkveld[rij, kolom]);
                    break;
                case "27":
                    pB27.Image = LaadAfbeelding(werkveld[rij, kolom]);
                    break;
                case "28":
                    pB28.Image = LaadAfbeelding(werkveld[rij, kolom]);
                    break;
                case "29":
                    pB29.Image = LaadAfbeelding(werkveld[rij, kolom]);
                    break;
                case "30":
                    pB30.Image = LaadAfbeelding(werkveld[rij, kolom]);
                    break;
                case "31":
                    pB31.Image = LaadAfbeelding(werkveld[rij, kolom]);
                    break;
                case "32":
                    pB32.Image = LaadAfbeelding(werkveld[rij, kolom]);
                    break;
                case "33":
                    pB33.Image = LaadAfbeelding(werkveld[rij, kolom]);
                    break;
                case "34":
                    pB34.Image = LaadAfbeelding(werkveld[rij, kolom]);
                    break;
                case "35":
                    pB35.Image = LaadAfbeelding(werkveld[rij, kolom]);
                    break;
                case "36":
                    pB36.Image = LaadAfbeelding(werkveld[rij, kolom]);
                    break;
                case "37":
                    pB37.Image = LaadAfbeelding(werkveld[rij, kolom]);
                    break;
                case "38":
                    pB38.Image = LaadAfbeelding(werkveld[rij, kolom]);
                    break;
                case "39":
                    pB39.Image = LaadAfbeelding(werkveld[rij, kolom]);
                    break;
                case "40":
                    pB40.Image = LaadAfbeelding(werkveld[rij, kolom]);
                    break;
                case "41":
                    pB41.Image = LaadAfbeelding(werkveld[rij, kolom]);
                    break;
                case "42":
                    pB42.Image = LaadAfbeelding(werkveld[rij, kolom]);
                    break;
                case "43":
                    pB43.Image = LaadAfbeelding(werkveld[rij, kolom]);
                    break;
                case "44":
                    pB44.Image = LaadAfbeelding(werkveld[rij, kolom]);
                    break;
                case "45":
                    pB45.Image = LaadAfbeelding(werkveld[rij, kolom]);
                    break;
                case "46":
                    pB46.Image = LaadAfbeelding(werkveld[rij, kolom]);
                    break;
                case "47":
                    pB47.Image = LaadAfbeelding(werkveld[rij, kolom]);
                    break;
                case "48":
                    pB48.Image = LaadAfbeelding(werkveld[rij, kolom]);
                    break;
                case "49":
                    pB49.Image = LaadAfbeelding(werkveld[rij, kolom]);
                    break;
                case "50":
                    pB50.Image = LaadAfbeelding(werkveld[rij, kolom]);
                    break;
                case "51":
                    pB51.Image = LaadAfbeelding(werkveld[rij, kolom]);
                    break;
                case "52":
                    pB52.Image = LaadAfbeelding(werkveld[rij, kolom]);
                    break;
                case "53":
                    pB53.Image = LaadAfbeelding(werkveld[rij, kolom]);
                    break;
                case "54":
                    pB54.Image = LaadAfbeelding(werkveld[rij, kolom]);
                    break;
                case "55":
                    pB55.Image = LaadAfbeelding(werkveld[rij, kolom]);
                    break;
                case "56":
                    pB56.Image = LaadAfbeelding(werkveld[rij, kolom]);
                    break;
                case "57":
                    pB57.Image = LaadAfbeelding(werkveld[rij, kolom]);
                    break;
                case "58":
                    pB58.Image = LaadAfbeelding(werkveld[rij, kolom]);
                    break;
                case "59":
                    pB59.Image = LaadAfbeelding(werkveld[rij, kolom]);
                    break;
                case "60":
                    pB60.Image = LaadAfbeelding(werkveld[rij, kolom]);
                    break;
                case "61":
                    pB61.Image = LaadAfbeelding(werkveld[rij, kolom]);
                    break;
                case "62":
                    pB62.Image = LaadAfbeelding(werkveld[rij, kolom]);
                    break;
                case "63":
                    pB63.Image = LaadAfbeelding(werkveld[rij, kolom]);
                    break;
                case "64":
                    pB64.Image = LaadAfbeelding(werkveld[rij, kolom]);
                    break;
                case "65":
                    pB65.Image = LaadAfbeelding(werkveld[rij, kolom]);
                    break;
                case "66":
                    pB66.Image = LaadAfbeelding(werkveld[rij, kolom]);
                    break;
                case "67":
                    pB67.Image = LaadAfbeelding(werkveld[rij, kolom]);
                    break;
                case "68":
                    pB68.Image = LaadAfbeelding(werkveld[rij, kolom]);
                    break;
                case "69":
                    pB69.Image = LaadAfbeelding(werkveld[rij, kolom]);
                    break;
                case "70":
                    pB70.Image = LaadAfbeelding(werkveld[rij, kolom]);
                    break;
                case "71":
                    pB71.Image = LaadAfbeelding(werkveld[rij, kolom]);
                    break;
                case "72":
                    pB72.Image = LaadAfbeelding(werkveld[rij, kolom]);
                    break;
                case "73":
                    pB73.Image = LaadAfbeelding(werkveld[rij, kolom]);
                    break;
                case "74":
                    pB74.Image = LaadAfbeelding(werkveld[rij, kolom]);
                    break;
                case "75":
                    pB75.Image = LaadAfbeelding(werkveld[rij, kolom]);
                    break;
                case "76":
                    pB76.Image = LaadAfbeelding(werkveld[rij, kolom]);
                    break;
                case "77":
                    pB77.Image = LaadAfbeelding(werkveld[rij, kolom]);
                    break;
                case "78":
                    pB78.Image = LaadAfbeelding(werkveld[rij, kolom]);
                    break;
                case "79":
                    pB79.Image = LaadAfbeelding(werkveld[rij, kolom]);
                    break;
                case "80":
                    pB80.Image = LaadAfbeelding(werkveld[rij, kolom]);
                    break;
                case "81":
                    pB81.Image = LaadAfbeelding(werkveld[rij, kolom]);
                    break;
                case "82":
                    pB82.Image = LaadAfbeelding(werkveld[rij, kolom]);
                    break;
                case "83":
                    pB83.Image = LaadAfbeelding(werkveld[rij, kolom]);
                    break;
                case "84":
                    pB84.Image = LaadAfbeelding(werkveld[rij, kolom]);
                    break;
                case "85":
                    pB85.Image = LaadAfbeelding(werkveld[rij, kolom]);
                    break;
                case "86":
                    pB86.Image = LaadAfbeelding(werkveld[rij, kolom]);
                    break;
                case "87":
                    pB87.Image = LaadAfbeelding(werkveld[rij, kolom]);
                    break;
                case "88":
                    pB88.Image = LaadAfbeelding(werkveld[rij, kolom]);
                    break;
                case "89":
                    pB89.Image = LaadAfbeelding(werkveld[rij, kolom]);
                    break;
                case "90":
                    pB90.Image = LaadAfbeelding(werkveld[rij, kolom]);
                    break;

            }
        }

        private void btnChocola_Click(object sender, EventArgs e)
        {
            GeluidAfspelen();
            BackgroundReset();
            btnChocola.BackgroundImage = Image.FromFile("ZaadChocolaSelected.jpg");
            geselecteerd = "Chocola";
            txtBeschrijving.Text = null;
            txtBeschrijving.ForeColor = Color.White;
            txtBeschrijving.Text = Chocola.Beschrijving.ToString();
        }
        private void ImageUpdateGroeien(int teller)
        {
            switch (teller.ToString())
            {
                case "1":
                    pB1.Image = LaadAfbeelding(werkveld[0, 0]);
                    break;
                case "2":
                    pB2.Image = LaadAfbeelding(werkveld[0, 1]);
                    break;
                case "3":
                    pB3.Image = LaadAfbeelding(werkveld[0, 2]);
                    break;
                case "4":
                    pB4.Image = LaadAfbeelding(werkveld[0, 3]);
                    break;
                case "5":
                    pB5.Image = LaadAfbeelding(werkveld[0, 4]);
                    break;
                case "6":
                    pB6.Image = LaadAfbeelding(werkveld[0, 5]);
                    break;
                case "7":
                    pB7.Image = LaadAfbeelding(werkveld[0, 6]);
                    break;
                case "8":
                    pB8.Image = LaadAfbeelding(werkveld[0, 7]);
                    break;
                case "9":
                    pB9.Image = LaadAfbeelding(werkveld[0, 8]);
                    break;
                case "10":
                    pB10.Image = LaadAfbeelding(werkveld[0, 9]);
                    break;
                case "11":
                    pB11.Image = LaadAfbeelding(werkveld[1, 0]);
                    break;
                case "12":
                    pB12.Image = LaadAfbeelding(werkveld[1, 1]);
                    break;
                case "13":
                    pB13.Image = LaadAfbeelding(werkveld[1, 2]);
                    break;
                case "14":
                    pB14.Image = LaadAfbeelding(werkveld[1, 3]);
                    break;
                case "15":
                    pB15.Image = LaadAfbeelding(werkveld[1, 4]);
                    break;
                case "16":
                    pB16.Image = LaadAfbeelding(werkveld[1, 5]);
                    break;
                case "17":
                    pB17.Image = LaadAfbeelding(werkveld[1, 6]);
                    break;
                case "18":
                    pB18.Image = LaadAfbeelding(werkveld[1, 7]);
                    break;
                case "19":
                    pB19.Image = LaadAfbeelding(werkveld[1, 8]);
                    break;
                case "20":
                    pB20.Image = LaadAfbeelding(werkveld[1, 9]);
                    break;
                case "21":
                    pB21.Image = LaadAfbeelding(werkveld[2, 0]);
                    break;
                case "22":
                    pB22.Image = LaadAfbeelding(werkveld[2, 1]);
                    break;
                case "23":
                    pB23.Image = LaadAfbeelding(werkveld[2, 2]);
                    break;
                case "24":
                    pB24.Image = LaadAfbeelding(werkveld[2, 3]);
                    break;
                case "25":
                    pB25.Image = LaadAfbeelding(werkveld[2, 4]);
                    break;
                case "26":
                    pB26.Image = LaadAfbeelding(werkveld[2, 5]);
                    break;
                case "27":
                    pB27.Image = LaadAfbeelding(werkveld[2, 6]);
                    break;
                case "28":
                    pB28.Image = LaadAfbeelding(werkveld[2, 7]);
                    break;
                case "29":
                    pB29.Image = LaadAfbeelding(werkveld[2, 8]);
                    break;
                case "30":
                    pB30.Image = LaadAfbeelding(werkveld[2, 9]);
                    break;
                case "31":
                    pB31.Image = LaadAfbeelding(werkveld[3, 0]);
                    break;
                case "32":
                    pB32.Image = LaadAfbeelding(werkveld[3, 1]);
                    break;
                case "33":
                    pB33.Image = LaadAfbeelding(werkveld[3, 2]);
                    break;
                case "34":
                    pB34.Image = LaadAfbeelding(werkveld[3, 3]);
                    break;
                case "35":
                    pB35.Image = LaadAfbeelding(werkveld[3, 4]);
                    break;
                case "36":
                    pB36.Image = LaadAfbeelding(werkveld[3, 5]);
                    break;
                case "37":
                    pB37.Image = LaadAfbeelding(werkveld[3, 6]);
                    break;
                case "38":
                    pB38.Image = LaadAfbeelding(werkveld[3, 7]);
                    break;
                case "39":
                    pB39.Image = LaadAfbeelding(werkveld[3, 8]);
                    break;
                case "40":
                    pB40.Image = LaadAfbeelding(werkveld[3, 9]);
                    break;
                case "41":
                    pB41.Image = LaadAfbeelding(werkveld[4, 0]);
                    break;
                case "42":
                    pB42.Image = LaadAfbeelding(werkveld[4, 1]);
                    break;
                case "43":
                    pB43.Image = LaadAfbeelding(werkveld[4, 2]);
                    break;
                case "44":
                    pB44.Image = LaadAfbeelding(werkveld[4, 3]);
                    break;
                case "45":
                    pB45.Image = LaadAfbeelding(werkveld[4, 4]);
                    break;
                case "46":
                    pB46.Image = LaadAfbeelding(werkveld[4, 5]);
                    break;
                case "47":
                    pB47.Image = LaadAfbeelding(werkveld[4, 6]);
                    break;
                case "48":
                    pB48.Image = LaadAfbeelding(werkveld[4, 7]);
                    break;
                case "49":
                    pB49.Image = LaadAfbeelding(werkveld[4, 8]);
                    break;
                case "50":
                    pB50.Image = LaadAfbeelding(werkveld[4, 9]);
                    break;
                case "51":
                    pB51.Image = LaadAfbeelding(werkveld[5, 0]);
                    break;
                case "52":
                    pB52.Image = LaadAfbeelding(werkveld[5, 1]);
                    break;
                case "53":
                    pB53.Image = LaadAfbeelding(werkveld[5, 2]);
                    break;
                case "54":
                    pB54.Image = LaadAfbeelding(werkveld[5, 3]);
                    break;
                case "55":
                    pB55.Image = LaadAfbeelding(werkveld[5, 4]);
                    break;
                case "56":
                    pB56.Image = LaadAfbeelding(werkveld[5, 5]);
                    break;
                case "57":
                    pB57.Image = LaadAfbeelding(werkveld[5, 6]);
                    break;
                case "58":
                    pB58.Image = LaadAfbeelding(werkveld[5, 7]);
                    break;
                case "59":
                    pB59.Image = LaadAfbeelding(werkveld[5, 8]);
                    break;
                case "60":
                    pB60.Image = LaadAfbeelding(werkveld[5, 9]);
                    break;
                case "61":
                    pB61.Image = LaadAfbeelding(werkveld[6, 0]);
                    break;
                case "62":
                    pB62.Image = LaadAfbeelding(werkveld[6, 1]);
                    break;
                case "63":
                    pB63.Image = LaadAfbeelding(werkveld[6, 2]);
                    break;
                case "64":
                    pB64.Image = LaadAfbeelding(werkveld[6, 3]);
                    break;
                case "65":
                    pB65.Image = LaadAfbeelding(werkveld[6, 4]);
                    break;
                case "66":
                    pB66.Image = LaadAfbeelding(werkveld[6, 5]);
                    break;
                case "67":
                    pB67.Image = LaadAfbeelding(werkveld[6, 6]);
                    break;
                case "68":
                    pB68.Image = LaadAfbeelding(werkveld[6, 7]);
                    break;
                case "69":
                    pB69.Image = LaadAfbeelding(werkveld[6, 8]);
                    break;
                case "70":
                    pB70.Image = LaadAfbeelding(werkveld[6, 9]);
                    break;
                case "71":
                    pB71.Image = LaadAfbeelding(werkveld[7, 0]);
                    break;
                case "72":
                    pB72.Image = LaadAfbeelding(werkveld[7, 1]);
                    break;
                case "73":
                    pB73.Image = LaadAfbeelding(werkveld[7, 2]);
                    break;
                case "74":
                    pB74.Image = LaadAfbeelding(werkveld[7, 3]);
                    break;
                case "75":
                    pB75.Image = LaadAfbeelding(werkveld[7, 4]);
                    break;
                case "76":
                    pB76.Image = LaadAfbeelding(werkveld[7, 5]);
                    break;
                case "77":
                    pB77.Image = LaadAfbeelding(werkveld[7, 6]);
                    break;
                case "78":
                    pB78.Image = LaadAfbeelding(werkveld[7, 7]);
                    break;
                case "79":
                    pB79.Image = LaadAfbeelding(werkveld[7, 8]);
                    break;
                case "80":
                    pB80.Image = LaadAfbeelding(werkveld[7, 9]);
                    break;
                case "81":
                    pB81.Image = LaadAfbeelding(werkveld[8, 0]);
                    break;
                case "82":
                    pB82.Image = LaadAfbeelding(werkveld[8, 1]);
                    break;
                case "83":
                    pB83.Image = LaadAfbeelding(werkveld[8, 2]);
                    break;
                case "84":
                    pB84.Image = LaadAfbeelding(werkveld[8, 3]);
                    break;
                case "85":
                    pB85.Image = LaadAfbeelding(werkveld[8, 4]);
                    break;
                case "86":
                    pB86.Image = LaadAfbeelding(werkveld[8, 5]);
                    break;
                case "87":
                    pB87.Image = LaadAfbeelding(werkveld[8, 6]);
                    break;
                case "88":
                    pB88.Image = LaadAfbeelding(werkveld[8, 7]);
                    break;
                case "89":
                    pB89.Image = LaadAfbeelding(werkveld[8, 8]);
                    break;
                case "90":
                    pB90.Image = LaadAfbeelding(werkveld[8, 9]);
                    break;

            }
        }

        private void btnFruit_Click(object sender, EventArgs e)
        {
            GeluidAfspelen();
            BackgroundReset();
            btnFruit.BackgroundImage = Image.FromFile("ZaadFruitSelected.jpg");
            geselecteerd = "Fruit";
            txtBeschrijving.Text = null;
            txtBeschrijving.ForeColor = Color.White;
            txtBeschrijving.Text = Fruit.Beschrijving.ToString();
        }

        private void btnGist_Click(object sender, EventArgs e)
        {
            GeluidAfspelen();
            BackgroundReset();
            btnGist.BackgroundImage = Image.FromFile("ZaadGistSelected.jpg");
            geselecteerd = "Gist";
            txtBeschrijving.Text = null;
            txtBeschrijving.ForeColor = Color.White;
            txtBeschrijving.Text = Gist.Beschrijving.ToString();
        }

        private void btnKruiden_Click(object sender, EventArgs e)
        {
            GeluidAfspelen();
            BackgroundReset();
            btnKruiden.BackgroundImage = Image.FromFile("ZaadKruidenSelected.jpg");
            geselecteerd = "Kruiden";
            txtBeschrijving.Text = null;
            txtBeschrijving.ForeColor = Color.White;
            txtBeschrijving.Text = Kruiden.Beschrijving.ToString();
        }

        private void btnMais_Click(object sender, EventArgs e)
        {
            GeluidAfspelen();
            BackgroundReset();
            btnMais.BackgroundImage = Image.FromFile("ZaadMaisSelected.jpg");
            geselecteerd = "Mais";
            txtBeschrijving.Text = null;
            txtBeschrijving.ForeColor = Color.White;
            txtBeschrijving.Text = Mais.Beschrijving.ToString();
        }

        private void btnSuikerbiet_Click(object sender, EventArgs e)
        {
            GeluidAfspelen();
            BackgroundReset();
            btnSuikerbiet.BackgroundImage = Image.FromFile("ZaadSuikerbietSelected.jpg");
            geselecteerd = "Suikerbiet";
            txtBeschrijving.Text = null;
            txtBeschrijving.ForeColor = Color.White;
            txtBeschrijving.Text = SuikerBiet.Beschrijving.ToString();
        }

        private void btnVanille_Click(object sender, EventArgs e)
        {
            GeluidAfspelen();
            BackgroundReset();
            btnVanille.BackgroundImage = Image.FromFile("ZaadVanilleSelected.jpg");
            geselecteerd = "Vanille";
            txtBeschrijving.Text = null;
            txtBeschrijving.ForeColor = Color.White;
            txtBeschrijving.Text = Vanille.Beschrijving.ToString();
        }

        private void btnWater_Click(object sender, EventArgs e)
        {
            GeluidAfspelen();
            BackgroundReset();
            btnWater.BackgroundImage = Image.FromFile("ZaadWaterSelected.jpg");
            geselecteerd = "Water";
            txtBeschrijving.Text = null;
            txtBeschrijving.ForeColor = Color.White;
            txtBeschrijving.Text = Water.Beschrijving.ToString();
        }

        private void btnOogsten_Click(object sender, EventArgs e)
        {
            SoundPlayer soundPlayer = new SoundPlayer(@"oogsten.wav");
            soundPlayer.Play();
            int teller = 1;
            for (int i = 0; i < werkveld.GetLength(0); i++)
            {
                for (int j = 0; j < werkveld.GetLength(1); j++)
                {
                    if (werkveld[i, j] == null)
                    {
                        teller++;
                        continue;
                    }
                    if (werkveld[i, j].Leeftijd >= werkveld[i, j].GroeiTijd)
                    {
                        werkveld.SetValue(null, i, j);
                        ImageUpdateGroeien(teller);

                    }
                    teller++;
                }
            }
        }
        private void txtVeld_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void GeluidAfspelen()
        {
            SoundPlayer soundPlayer = new SoundPlayer(@"click.wav");
            soundPlayer.Play();
        }
    }
}