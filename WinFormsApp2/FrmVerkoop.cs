using System.Text.Json;
using System.Xml;
using WinFormsApp2;

namespace Groep_project_2
{
    public partial class FrmVerkoop : Form
    {
        public FrmVerkoop()
        {
            InitializeComponent();
        }
        public Gebruiker ingelogdeGebruikerVerkoop = new Gebruiker();

        List<Grondstof> listVraag = new List<Grondstof>();
        List<Grondstof> listAanbod = new List<Grondstof>();
        List<Leveringsbon> listLeveringsbons = new List<Leveringsbon>();
        string pad = "";
        string bestandinhoud = "";
        private void FrmVerkoop_Load(object sender, EventArgs e)
        {
            StockInlezen();
        }
        private void btnLeesBestelling_Click(object sender, EventArgs e)
        {
            {
                txtBestandInhoud.Text = "";
                OpenFileDialog openFileDialog1 = new OpenFileDialog
                {
                    InitialDirectory = @"C:\",
                    Title = "Browse Text Files",

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
                    }
                    else if (pad.Contains(".xml"))
                    {
                        openFileDialog1.DefaultExt = ".xml";
                        XMLInlezen();
                    }
                    else if (pad.Contains(".json"))
                    {
                        openFileDialog1.DefaultExt = ".json";
                        JSONInlezen();
                    }
                    txtPad.Text = pad;
                }
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Methodes
        public void TXTSInlezen()
        {
            using (StreamReader reader = new StreamReader(pad))
            {
                while (!reader.EndOfStream)
                {
                    bestandinhoud += reader.ReadLine() + Environment.NewLine;
                }

                txtBestandInhoud.Text = bestandinhoud;
            }
        }
        public void TXTSWegschrijven()
        {
            using (StreamWriter writer = new StreamWriter(pad))
            {
                bestandinhoud += txtBestandInhoud.Text;
                writer.WriteLine(bestandinhoud);
            }
        }

        public void XMLInlezen()
        {
            listVraag.Clear();
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(pad);
            XmlNodeList nodesGrondstoffen = xmlDocument.SelectNodes("//Grondstof");
            txtBestandInhoud.Text = "<Grondstoffen>" + Environment.NewLine;
            foreach (XmlNode nodeGrondstof in nodesGrondstoffen)
            {
                Grondstof dezeGrondstof = new Grondstof();
                txtBestandInhoud.Text += " <Grondstof>" + Environment.NewLine;
                txtBestandInhoud.Text += "   <Naam> ";
                txtBestandInhoud.Text += nodeGrondstof.ChildNodes[0].InnerText;
                txtBestandInhoud.Text += "  </Naam>" + Environment.NewLine;
                dezeGrondstof.Naam = nodeGrondstof.ChildNodes[0].InnerText;
                txtBestandInhoud.Text += "   <Aantal> ";
                txtBestandInhoud.Text += nodeGrondstof.ChildNodes[1].InnerText;
                txtBestandInhoud.Text += "  </Aantal>" + Environment.NewLine;
                dezeGrondstof.Aantal = Convert.ToInt32(nodeGrondstof.ChildNodes[1].InnerText);
                txtBestandInhoud.Text += " </Grondstof>" + Environment.NewLine;
                listVraag.Add(dezeGrondstof);
            }
            txtBestandInhoud.Text += "</Grondstoffen>";
        }
        public void XMLAanmakenEnWegschrijven()
        {
            XmlDocument xmlDocument = new XmlDocument();
            XmlElement mainRoot = xmlDocument.CreateElement("Grondstoffen");
            xmlDocument.AppendChild(mainRoot);
            foreach (Grondstof dezeGrondstof in listVraag)
            {
                XmlElement root = xmlDocument.CreateElement("Grondstof");
                mainRoot.AppendChild(root);

                XmlElement grondstofNaam = xmlDocument.CreateElement("Naam");
                grondstofNaam.InnerText = dezeGrondstof.Naam.ToString();
                root.AppendChild(grondstofNaam);

                XmlElement grondstofAantal = xmlDocument.CreateElement("Aantal");
                grondstofAantal.InnerText = dezeGrondstof.Aantal.ToString();
                root.AppendChild(grondstofAantal);
            }
            xmlDocument.Save(pad);
            XMLInlezen();
        }
        public void JSONInlezen()
        {
            using (StreamReader r = new StreamReader(pad))
            {
                listVraag.Clear();
                string json = r.ReadToEnd();
                listVraag = JsonSerializer.Deserialize<List<Grondstof>>(json);
                txtBestandInhoud.Text = json;

            }
        }
        public void JSONWegschrijven()
        {
            JsonSerializerOptions options = new JsonSerializerOptions();
            options.WriteIndented = true;

            string json = JsonSerializer.Serialize(listVraag, options);
            File.WriteAllText(pad, json);
            JSONInlezen();

        }

        private void btnLeveren_Click(object sender, EventArgs e)
        {
            LeveringsBonsInlezen();
            LeveringsbonMaken();
            LeveringsBonsOpslagen();
            StockOpslagen();

            SaveFileDialog saveFileDialog1 = new SaveFileDialog()
            {
                InitialDirectory = @"C:\",
                Title = "Kies bestandslocatie",

                DefaultExt = "",
                Filter = "TXT files (*.txt)|*.txt|XML files (*.xml)|*.xml|JSON files (*.json)|*.json|All files (*.*)|*.*",
                AddExtension = true,
                FilterIndex = 4,
                RestoreDirectory = false,
            };

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pad = saveFileDialog1.FileName;
                if (pad.Contains(".txt"))
                {
                    saveFileDialog1.DefaultExt = ".txt";
                    TXTSWegschrijven();
                }
                else if (pad.Contains(".xml"))
                {
                    saveFileDialog1.DefaultExt = ".xml";
                    XMLAanmakenEnWegschrijven();
                }
                else if (pad.Contains(".json"))
                {

                    saveFileDialog1.DefaultExt = ".json";
                    JsonSerializerOptions options = new JsonSerializerOptions();
                    options.WriteIndented = true;
                    string json = JsonSerializer.Serialize(listLeveringsbons, options);
                    File.WriteAllText(pad, json);
                    JSONInlezen();
                }
                txtPad.Text = pad;
            }
        }


        private void LeveringsbonMaken()
        {

            Leveringsbon mijnLeveringsbon = new Leveringsbon();
            foreach (Grondstof vraag in listVraag)
            {
                foreach (Grondstof stock in listAanbod)
                {
                    if (stock.Naam == vraag.Naam)
                    {
                        stock.VerminderenStock(vraag.Aantal);
                        mijnLeveringsbon.TotaalBedragGrondstof = stock.Berekenprijs(vraag.Aantal);
                        mijnLeveringsbon.Prijs = stock.Prijs;
                        mijnLeveringsbon.Aantal = vraag.Aantal;
                        mijnLeveringsbon.Naam = vraag.Naam;
                    }
                }
                mijnLeveringsbon.Bericht = txtBestellingsbericht.Text;
                listLeveringsbons.Add(mijnLeveringsbon);
                mijnLeveringsbon = new Leveringsbon();
            }

            JsonSerializerOptions options = new JsonSerializerOptions();
            options.WriteIndented = true;
            string fileName = "Leveringsbons.json";
            string json = JsonSerializer.Serialize(listLeveringsbons, options);
            File.WriteAllText(fileName, json);

        }
        private void StockInlezen()
        {
            if (System.IO.File.Exists("Stock.json"))
            {
                using (StreamReader r = new StreamReader(@"Stock.json"))

                {
                    string json = r.ReadToEnd();
                    listAanbod = JsonSerializer.Deserialize<List<Grondstof>>(json);
                }
            }
        }
        private void StockOpslagen()
        {
            JsonSerializerOptions options = new JsonSerializerOptions();
            options.WriteIndented = true;
            string fileName = "Stock.json";
            string json = JsonSerializer.Serialize(listAanbod, options);
            File.WriteAllText(fileName, json);
        }
        private void LeveringsBonsInlezen()
        {
            //De list van leveringsbons oproepen
            if (System.IO.File.Exists("Leveringsbons.json"))
            {
                using (StreamReader r = new StreamReader(@"Leveringsbons.json"))

                {
                    string json = r.ReadToEnd();
                    listLeveringsbons = JsonSerializer.Deserialize<List<Leveringsbon>>(json);
                }
            }
        }
        private void LeveringsBonsOpslagen()
        {
            JsonSerializerOptions options = new JsonSerializerOptions();
            options.WriteIndented = true;
            string fileName = "Leveringsbons.json";
            string json = JsonSerializer.Serialize(listLeveringsbons, options);
            File.WriteAllText(fileName, json);
        }

        //TODO: Leveringen in aandere formaten?
    }
}
