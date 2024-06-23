using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicinskaOrdinacija {
    public partial class FormPeople : Form {
        private DataFetcher dataFetcher;
        public FormPeople() {
            InitializeComponent();
            dataFetcher = new DataFetcher();
        }

        private async void btnFetchData_Click(object sender, EventArgs e) {
            try {
                var pacijenti = await dataFetcher.FetchPacijentiAsync();
                var doktori = await dataFetcher.FetchDoktoriAsync();

                DisplayData(pacijenti, doktori);
            }
            catch (Exception ex) {
                MessageBox.Show($"Greška prilikom dohvaćanja podataka: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DisplayData(List<Pacijent> pacijenti, List<Doktor> doktori) {
            dgvPeople.Rows.Clear();
            foreach (var pacijent in pacijenti) {
                dgvPeople.Rows.Add(pacijent.PacijentID, pacijent.Ime, pacijent.Prezime, "Pacijent", pacijent.Telefon, pacijent.PovijestBolesti);
            }
            foreach (var doktor in doktori) {
                dgvPeople.Rows.Add(doktor.DoktorID, doktor.Ime, doktor.Prezime, "Doktor", doktor.Telefon, doktor.Specijalizacija);
            }
        }
    }
}
