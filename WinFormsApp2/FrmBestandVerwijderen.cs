namespace WinFormsApp2
{
    public partial class FrmBestandVerwijderen : Form
    {
        public FrmBestandVerwijderen()
        {
            InitializeComponent();
        }
        private void FrmBestandVerwijderen_Load(object sender, EventArgs e)
        {
            txtPad.Enabled = false;
        }
        string pad = "";
        private void btnBestandKiezen_Click(object sender, EventArgs e)
        {
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
                    openFileDialog1.DefaultExt = "txt";
                }
                else if (pad.Contains(".xml"))
                {
                    openFileDialog1.DefaultExt = "xml";
                }
                else if (pad.Contains(".json"))
                {
                    openFileDialog1.DefaultExt = "json";
                }
                txtPad.Text = pad;
            }
        }
        private void btnBestandVerwijderen_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtPad.Text))
            {
                DialogResult result = MessageBox.Show($"Bent u zeker dat het bestand {pad} wilt verwijderen?", "Bestand verwijderen", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    File.Delete(pad);
                    txtPad.Text = "";
                    MessageBox.Show($"Bestand {pad} succesvol verwijderd!", "Bestand verwijderd", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Het bestand {pad} werd niet verwijderd.", "Bestand verwijderen geannuleerd", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("U heeft geen bestand geselecteerd om te verwijderen.", "Selectiefout", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAnnuleer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
