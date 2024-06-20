using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MedicinskaOrdinacija {
    public partial class FormCartons : Form {
        public FormCartons() {
            InitializeComponent();
            LoadPatients();
            LoadCartons();
            cbPatients.SelectedIndexChanged += cbPatients_SelectedIndexChanged;
        }

        private void FormCartons_Load(object sender, EventArgs e) {
            this.kartoniTableAdapter.Fill(this.medOrdinacijaDataSet.Kartoni);
        }

        private void btnSave_Click(object sender, EventArgs e) {
            try {
                var newKarton = new Karton {
                    PacijentID = (int)cbPatients.SelectedValue,
                    Dijagnoza = rtbDiagnosis.Text,
                    Terapija = rtbTherapy.Text,
                    DatumKartona = dtp.Value
                };

                using (var context = new OrdinacijaDB()) {
                    context.Kartoni.Add(newKarton);
                    context.SaveChanges();
                }

                LoadCartons();
                ClearInputs();

                MessageBox.Show("Novi karton uspješno spremljen!", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) {
                MessageBox.Show($"Nije se karton uspješno spremio: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadPatients() {
            using (var context = new OrdinacijaDB()) {
                cbPatients.DataSource = context.Pacijenti.ToList();
                cbPatients.DisplayMember = "Ime";
                cbPatients.ValueMember = "PacijentID";
                cbPatients.SelectedIndex = 0;
            }
        }

        private void LoadCartons() {
            using (var context = new OrdinacijaDB()) {
                dgvCartons.DataSource = context.Kartoni.ToList();
            }
        }

        private void ClearInputs() {
            rtbDiagnosis.Text = string.Empty;
            rtbTherapy.Text = string.Empty;
            dtp.Value = DateTime.Now;
        }

        private void cbPatients_SelectedIndexChanged(object sender, EventArgs e) {
            if (cbPatients.SelectedItem != null) {
                var selectedPatient = (Pacijent)cbPatients.SelectedItem;
                int selectedPatientID = selectedPatient.PacijentID;

                using (var context = new OrdinacijaDB()) {
                    var patientCartons = context.Kartoni.Where(k => k.PacijentID == selectedPatientID).ToList();
                    dgvCartons.DataSource = patientCartons;
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e) {

        }

        private void btnShow_Click(object sender, EventArgs e) {
            LoadCartons();
        }
    }
}
