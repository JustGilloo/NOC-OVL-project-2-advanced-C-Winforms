using System.Text.Json;

namespace WinFormsApp2
{
    public partial class FrmBestandLezen : Form
    {
        public FrmBestandLezen()
        {
            InitializeComponent();
        }
        private void FrmBestandLezen_Load(object sender, EventArgs e)
        {
            txtPad.Enabled = false;
            symbolen = "' !\"#$%&()*+,-.\\/0123456789:<=>@?ABCDEFGHIJKLMNOPQRSTUVWXYZ[]^_`abcdefghijklmnopqrstuvwxyz{|}~;éèêëûüôöîïâäà\r\n".ToCharArray();
        }
        List<Grondstof> listGrondstoffen = new List<Grondstof>();
        string bestandinhoud;
        string pad = "";
        char[] symbolen;
        char[] sleutel;

        private void btnBestandKiezen_Click(object sender, EventArgs e)
        {
            txtBestandInhoud.Clear();
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
                }
                else if (pad.Contains(".xml"))
                {
                    openFileDialog1.DefaultExt = ".xml";
                    bestandinhoud = System.IO.File.ReadAllText(pad);
                    txtBestandInhoud.Text = bestandinhoud;
                }
                else if (pad.Contains(".json"))
                {
                    openFileDialog1.DefaultExt = ".json";
                    JSONInlezen();
                }
                txtPad.Text = pad;
            }
        }

        private void btnBestandOpslaan_Click(object sender, EventArgs e)
        {
            bestandinhoud = "";
            SaveFileDialog saveFileDialog1 = new SaveFileDialog()
            {
                InitialDirectory = @"C:\",
                Title = "Kies bestandslocatie",

                CheckFileExists = false,
                CheckPathExists = false,

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
                    BestandenWegschrijven();
                }
                else if (pad.Contains(".xml"))
                {
                    saveFileDialog1.DefaultExt = ".xml";
                    BestandenWegschrijven();
                }
                else if (pad.Contains(".json"))
                {
                    saveFileDialog1.DefaultExt = ".json";
                    BestandenWegschrijven();
                }
                txtPad.Text = pad;
            }
        }

        private void btnAnnuleer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            char[] input;
            string output = "";
            int index;
            VindSleutel();
            input = txtBestandInhoud.Text.ToCharArray(); //Dit zou text file moeten zijn, ipv een txt veld, maar ik doe dit voor te testen
            if (sleutel != null)
            {
                foreach (char c in input)
                {
                    index = Array.IndexOf(symbolen, c);
                    output += sleutel[index];
                }
                txtBestandInhoud.Text = output;
            }
            else
            {
                MessageBox.Show("Onze sleutels zijn in txt formaat :) Selecteer een nieuwe sleutel!");
                VindSleutel();
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            char[] input;
            string output = "";
            int index;
            VindSleutel();
            input = txtBestandInhoud.Text.ToCharArray(); //Dit zou text file moeten zijn, ipv een txt veld, maar ik doe dit voor te testen
            foreach (char c in input)
            {
                index = Array.IndexOf(sleutel, c);
                output += symbolen[index];
            }
            txtBestandInhoud.Text = output;
        }
        //eigen methodes - nieuwste update voor readability en reusability

        public void TXTSInlezen()
        {
            using (StreamReader reader = new StreamReader(pad))
            {
                while (!reader.EndOfStream)
                {
                    if (bestandinhoud == "")
                    {
                        bestandinhoud += reader.ReadLine();
                    }
                    else
                    {
                        bestandinhoud += Environment.NewLine + reader.ReadLine();
                    }
                }
                txtBestandInhoud.Text = bestandinhoud;
            }
        }
        public void BestandenWegschrijven()
        {
            using (StreamWriter writer = new StreamWriter(pad))
            {
                bestandinhoud = txtBestandInhoud.Text;
                writer.Write(bestandinhoud);
            }
        }

        public void JSONInlezen()
        {
            string json;
            using (StreamReader r = new StreamReader(pad))
            {
                json = r.ReadToEnd();
            }
            txtBestandInhoud.Text = json;
        }
        public void JSONWegschrijven()
        {
            JsonSerializerOptions options = new JsonSerializerOptions();
            options.WriteIndented = true;
            string json = JsonSerializer.Serialize(listGrondstoffen, options);
            File.WriteAllText(pad, json);
            JSONInlezen();
        }
        private void VindSleutel()
        {
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
                    using (StreamReader sr = new StreamReader(pad))
                    {
                        sleutel = sr.ReadToEnd().ToCharArray();
                    }
                }
                else if (pad.Contains(".xml"))
                {
                    MessageBox.Show("Onze sleutels zijn in txt formaat :)"); //TODO: Ik wil dat de verkenner niet sluit

                }
                else if (pad.Contains(".json"))
                {
                    MessageBox.Show("Onze sleutels zijn in txt formaat :)");

                }
            }
        }

    }
}
