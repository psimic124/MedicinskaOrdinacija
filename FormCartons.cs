using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using Newtonsoft.Json;

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
            try {
                if (dgvCartons.SelectedRows.Count > 0) {
                    int selectedKartonID = Convert.ToInt32(dgvCartons.SelectedRows[0].Cells["kartonIDDataGridViewTextBoxColumn"].Value);

                    using (var context = new OrdinacijaDB()) {
                        var kartonToUpdate = context.Kartoni.Find(selectedKartonID);
                        if (kartonToUpdate != null) {
                            kartonToUpdate.PacijentID = (int)cbPatients.SelectedValue;
                            kartonToUpdate.Dijagnoza = rtbDiagnosis.Text;
                            kartonToUpdate.Terapija = rtbTherapy.Text;
                            kartonToUpdate.DatumKartona = dtp.Value;

                            context.SaveChanges();
                        }
                    }

                    LoadCartons();
                    ClearInputs();

                    MessageBox.Show("Karton uspješno ažuriran!", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else {
                    MessageBox.Show("Molimo odaberite karton za ažuriranje.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex) {
                MessageBox.Show($"Greška pri ažuriranju kartona: {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnShow_Click(object sender, EventArgs e) {
            LoadCartons();
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            try {
                if (dgvCartons.SelectedRows.Count > 0) {
                    int selectedKartonID = Convert.ToInt32(dgvCartons.SelectedRows[0].Cells["kartonIDDataGridViewTextBoxColumn"].Value);

                    using (var context = new OrdinacijaDB()) {
                        var kartonToDelete = context.Kartoni.Find(selectedKartonID);
                        if (kartonToDelete != null) {
                            context.Kartoni.Remove(kartonToDelete);
                            context.SaveChanges();
                        }
                    }

                    LoadCartons();
                    ClearInputs();

                    MessageBox.Show("Karton uspješno obrisan!", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else {
                    MessageBox.Show("Molimo odaberite karton za brisanje.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex) {
                MessageBox.Show($"Greška pri brisanju kartona: {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExport_Click(object sender, EventArgs e) {
            try {
                if (dgvCartons.SelectedRows.Count > 0) {
                    int selectedKartonID = Convert.ToInt32(dgvCartons.SelectedRows[0].Cells["kartonIDDataGridViewTextBoxColumn"].Value);

                    using (var context = new OrdinacijaDB()) {
                        var kartonToExport = context.Kartoni.Find(selectedKartonID);
                        if (kartonToExport != null) {
                            string json = JsonConvert.SerializeObject(kartonToExport, new JsonSerializerSettings {
                                Formatting = Newtonsoft.Json.Formatting.Indented,
                                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                            });

                            SaveFileDialog saveFileDialog = new SaveFileDialog();
                            saveFileDialog.Filter = "JSON files (*.json)|*.json";
                            saveFileDialog.FileName = $"Karton_{selectedKartonID}.json";

                            if (saveFileDialog.ShowDialog() == DialogResult.OK) {
                                File.WriteAllText(saveFileDialog.FileName, json);
                                MessageBox.Show("Karton uspješno eksportiran!", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else {
                            MessageBox.Show("Nije pronađen odabrani karton.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else {
                    MessageBox.Show("Molimo odaberite karton za eksport.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex) {
                MessageBox.Show($"Greška pri eksportiranju kartona: {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
