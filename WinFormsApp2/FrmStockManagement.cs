using System.Text.Json;
using WinFormsApp2;

namespace Groep_project_2
{
    public partial class FrmStockManagement : Form
    {
        public FrmStockManagement()
        {
            InitializeComponent();
        }
        public Gebruiker ingelogdeGebruikerStock = new Gebruiker();
        List<Grondstof> listAanbod = new List<Grondstof>();
        private void FrmStockManagement_Load(object sender, EventArgs e)
        {
            StockInlezen();
            GrondstofToevoegenOfVerwijderenDisplay();
        }
        private void btnGrondStofToevoegen_Click(object sender, EventArgs e)
        {
            bool grondstofBestaat = false;
            string prijs;
            try
            {
                int.TryParse(txtAantalToevoegen.Text, out int resultAantal);
                prijs = txtPrijsToevoegen.Text.Replace('.', ',');
                txtPrijsToevoegen.Text = prijs;
                double.TryParse(txtPrijsToevoegen.Text, out double resultPrijs);
                if (!String.IsNullOrEmpty(txtNaamToevoegen.Text) || (!String.IsNullOrEmpty(txtAantalToevoegen.Text)) || (!String.IsNullOrEmpty(txtPrijsToevoegen.Text))) //Velden invullen
                {
                    Grondstof equalsGrondstofNakijken = new Grondstof();
                    equalsGrondstofNakijken.Naam = txtNaamToevoegen.Text;
                    foreach (Grondstof stockGrondstof in listAanbod)
                    {
                        if (equalsGrondstofNakijken.Equals(stockGrondstof))
                        {
                            grondstofBestaat = true;
                        }
                    }
                    if (grondstofBestaat)
                    {
                        MessageBox.Show("Het item " + txtNaamToevoegen.Text + " bestaat al.", "Bestaat al", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        Grondstof grondstof = new Grondstof();
                        grondstof.Naam = txtNaamToevoegen.Text;
                        grondstof.Aantal = Convert.ToInt32(txtAantalToevoegen.Text);
                        grondstof.Prijs = Convert.ToDouble(txtPrijsToevoegen.Text);
                        listAanbod.Add(grondstof);
                        StockOpslagen();
                        StockInlezen();
                    }
                }
                else
                {
                    throw new wrongInputException("U gaf niet de juiste waarde in, vul de juiste grondstof in,een gepast geheel getal voor het aantal, en een geheel of kommagetal voor de prijs (Geen euro tekens.).");
                }
            }
            catch (wrongInputException wie)
            {
                MessageBox.Show(wie.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                MessageBox.Show("U gaf niet de juiste waarde in, vul de juiste grondstof in,een gepast geheel getal voor het aantal, en een geheel of kommagetal voor de prijs (Geen euro tekens.).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }
        private void afsluitenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void grondstofToevoegenverwijderenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GrondstofToevoegenOfVerwijderenDisplay();
        }
        private void grondstofBewerkenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GrondstofBewerkenDisplay();
        }
        private void GrondstofToevoegenOfVerwijderenDisplay()
        {
            grpBoxToevoegen.Visible = true;
            grpBoxToevoegen.Enabled = true;
            txtAantalToevoegen.Enabled = true;
            txtAantalToevoegen.Visible = true;
            txtNaamToevoegen.Enabled = true;
            txtNaamToevoegen.Visible = true;
            txtPrijsToevoegen.Enabled = true;
            txtPrijsToevoegen.Visible = true;
            lblNaamToevoegenVerwijderen.Enabled = true;
            lblNaamToevoegenVerwijderen.Visible = true;
            btnGrondStofToevoegen.Enabled = true;
            btnGrondStofToevoegen.Visible = true;
            btnVerwijderen.Visible = true;
            btnVerwijderen.Enabled = true;
            grpBoxBewerken.Visible = false;
            grpBoxBewerken.Enabled = false;
            txtAantalBewerken.Enabled = false;
            txtAantalBewerken.Visible = false;
            txtNaamBewerken.Enabled = false;
            txtNaamBewerken.Visible = false;
            lblAantalBewerken.Visible = false;
            lblAantalBewerken.Enabled = false;
            lblNaamBewerken.Visible = false;
            lblNaamBewerken.Enabled = false;
            txtAantalBewerken.Visible = false;
            txtAantalBewerken.Enabled = false;
        }
        private void GrondstofBewerkenDisplay()
        {
            grpBoxBewerken.Visible = true;
            grpBoxBewerken.Enabled = true;
            txtAantalBewerken.Enabled = true;
            txtAantalBewerken.Visible = true;
            txtNaamBewerken.Enabled = true;
            txtNaamBewerken.Visible = true;
            lblAantalBewerken.Visible = true;
            lblAantalBewerken.Enabled = true;
            lblNaamBewerken.Visible = true;
            lblNaamBewerken.Enabled = true;
            txtAantalBewerken.Visible = true;
            txtAantalBewerken.Enabled = true;
            grpBoxToevoegen.Visible = false;
            grpBoxToevoegen.Enabled = false;
            txtAantalToevoegen.Enabled = false;
            txtAantalToevoegen.Visible = false;
            txtNaamToevoegen.Enabled = false;
            txtNaamToevoegen.Visible = false;
            txtPrijsToevoegen.Enabled = false;
            txtPrijsToevoegen.Visible = false;
            lblNaamToevoegenVerwijderen.Enabled = false;
            lblNaamToevoegenVerwijderen.Visible = false;
            btnGrondStofToevoegen.Enabled = false;
            btnGrondStofToevoegen.Visible = false;
            btnVerwijderen.Visible = false;
            btnVerwijderen.Enabled = false;
        }
        private void btnVerwijderen_Click(object sender, EventArgs e)
        {
            bool gevonden = false;
            try
            {
                if (!String.IsNullOrEmpty(txtNaamToevoegen.Text))
                {
                    {
                        foreach (Grondstof stockGrondstof in listAanbod)
                        {
                            if (stockGrondstof.Naam == txtNaamToevoegen.Text)
                            {
                                listAanbod.Remove(stockGrondstof);
                                gevonden = true;
                                break;
                            }
                        }
                    }
                    if (gevonden)
                    {
                        MessageBox.Show("Het item " + txtNaamToevoegen.Text + " werd verwijderd.", "Item verwijderd", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        StockOpslagen();
                        StockInlezen();
                    }
                    else
                    {
                        MessageBox.Show("Het item " + txtNaamToevoegen.Text + " werd niet gevonden.", "Niet gevonden", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                else
                {
                    throw new wrongInputException("Vul het veld Naam in aub. Dit mag niet leeg zijn.");
                }
            }
            catch (wrongInputException wie)
            {
                MessageBox.Show(wie.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnVermeerder_Click(object sender, EventArgs e)
        {
            try
            {
                int.TryParse(txtAantalBewerken.Text, out int result);
                if (!String.IsNullOrEmpty(txtNaamBewerken.Text) || (!String.IsNullOrEmpty(txtAantalBewerken.Text)))
                {
                    foreach (Grondstof stockGrondstof in listAanbod)
                    {
                        if (stockGrondstof.Naam == txtNaamBewerken.Text)
                        {
                            stockGrondstof.AanvullenStock(Convert.ToInt32(txtAantalBewerken.Text));
                            StockOpslagen();
                            StockInlezen();
                        }
                    }
                }
                else
                {
                    throw new wrongInputException("U gaf niet de juiste waarde in, vul de juiste grondstof in en een gepast geheel getal.");
                }

            }
            catch (wrongInputException wie)
            {
                MessageBox.Show(wie.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                MessageBox.Show("U gaf niet de juiste waarde in, vul de juiste grondstof in en een gepast geheel getal.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void btnVerminder_Click(object sender, EventArgs e)
        {
            try
            {
                int.TryParse(txtAantalBewerken.Text, out int result);
                if (!String.IsNullOrEmpty(txtNaamBewerken.Text) || (!String.IsNullOrEmpty(txtAantalBewerken.Text)))
                {
                    foreach (Grondstof stockGrondstof in listAanbod)
                    {
                        if (stockGrondstof.Naam == txtNaamBewerken.Text)
                        {
                            stockGrondstof.VerminderenStock(Convert.ToInt32(txtAantalBewerken.Text));
                            StockOpslagen();
                            StockInlezen();
                        }
                    }
                }
                else
                {
                    throw new wrongInputException("U gaf niet de juiste waarde in, vul de juiste grondstof in en een gepast geheel getal.");
                }
            }
            catch (wrongInputException wie)
            {
                MessageBox.Show(wie.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                MessageBox.Show("U gaf niet de juiste waarde in, vul de juiste grondstof in en een gepast geheel getal.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnPrijsBewerken_Click(object sender, EventArgs e)
        {
            try
            { //TODO: minder ghetto maken
                string prijs;
                prijs = txtPrijsbewerken.Text.Replace('.', ',');
                txtPrijsbewerken.Text = prijs;
                double.TryParse(txtPrijsbewerken.Text, out double result);
                if (!String.IsNullOrEmpty(txtNaamBewerken.Text) || (!String.IsNullOrEmpty(txtPrijsbewerken.Text)))
                {
                    foreach (Grondstof stockGrondstof in listAanbod)
                    {
                        if (stockGrondstof.Naam == txtNaamBewerken.Text)
                        {
                            stockGrondstof.Prijs = (Convert.ToDouble(txtPrijsbewerken.Text));
                            StockOpslagen();
                            StockInlezen();
                        }
                    }
                }
                else
                {
                    throw new wrongInputException("U gaf niet de juiste waarde in, vul de juiste grondstof in en een gepast geheel getal.");
                }
            }
            catch (wrongInputException wie)
            {
                MessageBox.Show(wie.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                MessageBox.Show("U gaf niet de juiste waarde in, vul de juiste grondstof in en een gepast geheel getal.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void lbDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbDisplay.SelectedIndex != -1)
            {
                txtNaamBewerken.Text = listAanbod[lbDisplay.SelectedIndex].Naam;
                txtNaamToevoegen.Text = listAanbod[lbDisplay.SelectedIndex].Naam;
            }
        }
        private void StockInlezen()
        {
            if (System.IO.File.Exists("Stock.json"))
            {
                using (StreamReader r = new StreamReader(@"Stock.json"))
                {
                    string json = r.ReadToEnd();
                    listAanbod = JsonSerializer.Deserialize<List<Grondstof>>(json);
                    lbDisplay.DataSource = null;
                    lbDisplay.DataSource = listAanbod;

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
    }
}
