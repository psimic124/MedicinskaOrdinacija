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
    public partial class FormSchedules : Form {
        public FormSchedules() {
            InitializeComponent();
            LoadPatients();
            LoadDoctors();
            LoadSchedules();

        }

        private void FormSchedules_Load(object sender, EventArgs e) {
            this.terminiTableAdapter.Fill(this.medOrdinacijaDataSet.Termini);

        }

        private void btnSave_Click(object sender, EventArgs e) {
            try {
                var newTermin = new Termin {
                    PacijentID = (int)cbPatients.SelectedValue,
                    DatumVrijeme = dtp.Value,
                    DoktorID = (int)cbDoctors.SelectedValue,
                    Napomena = rtbNote.Text
                };

                using (var context = new OrdinacijaDB()) {
                    context.Termini.Add(newTermin);
                    context.SaveChanges();
                }

                LoadSchedules();
                ClearInputs();

                MessageBox.Show("Novi termin uspješno spremljen!", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SaveException ex) {
                MessageBox.Show($"Termin se nije uspješno spremio: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex) {
                var terminEx = new SaveException($"Termin se nije uspješno spremio: {ex.Message}", ex);
                MessageBox.Show(terminEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void LoadSchedules() {
            using (var context = new OrdinacijaDB()) {
                dgvSchedules.DataSource = context.Termini.ToList();
            }
        }

        private void LoadDoctors() {
            using (var context = new OrdinacijaDB()) {
                cbDoctors.DataSource = context.Doktori.ToList();
                cbDoctors.DisplayMember = "Ime";
                cbDoctors.ValueMember = "DoktorID";
                cbDoctors.SelectedIndex = 0;
            }
        }

        private void ClearInputs() {
            cbPatients.SelectedIndex = 0;
            dtp.Value = DateTime.Now;
            cbDoctors.SelectedIndex = 0;
            rtbNote.Text = "";
        }

        private void cbPatients_SelectedIndexChanged(object sender, EventArgs e) {
            if (cbPatients.SelectedItem != null) {
                var selectedPatient = (Pacijent)cbPatients.SelectedItem;
                int selectedPatientID = selectedPatient.PacijentID;

                using (var context = new OrdinacijaDB()) {
                    var patientSchedules = context.Termini.Where(k => k.PacijentID == selectedPatientID).ToList();
                    dgvSchedules.DataSource = patientSchedules;
                }
            }
        }

        private void cbDoctors_SelectedIndexChanged(object sender, EventArgs e) {
            if(cbDoctors.SelectedItem != null) {
                var selectedDoctor = (Doktor)cbDoctors.SelectedItem;
                int selectedDoctorID = selectedDoctor.DoktorID;

                using (var context = new OrdinacijaDB()) {
                    var doctorSchedules = context.Termini.Where(k => k.DoktorID == selectedDoctorID).ToList();
                    dgvSchedules.DataSource = doctorSchedules;
                }
            }
        }

        private void btnShow_Click(object sender, EventArgs e) {
            LoadSchedules();
        }

        private void btnUpdate_Click(object sender, EventArgs e) {
            try {
                if (dgvSchedules.SelectedRows.Count > 0) {
                    int selectedTerminID = Convert.ToInt32(dgvSchedules.SelectedRows[0].Cells["terminIDDataGridViewTextBoxColumn"].Value);

                    using (var context = new OrdinacijaDB()) {
                        var terminToUpdate = context.Termini.Find(selectedTerminID);
                        if (terminToUpdate != null) {
                            bool isUpdated = false;

                            terminToUpdate.PacijentID = (int)cbPatients.SelectedValue;
                            terminToUpdate.DoktorID = (int)cbDoctors.SelectedValue;
                            if (!string.IsNullOrEmpty(rtbNote.Text) && terminToUpdate.Napomena != rtbNote.Text) {
                                terminToUpdate.Napomena = rtbNote.Text;
                                isUpdated = true;
                            }
                            if (dtp.Value != terminToUpdate.DatumVrijeme) {
                                terminToUpdate.DatumVrijeme = dtp.Value;
                                isUpdated = true;
                            }

                            if (isUpdated) {
                                context.SaveChanges();
                                MessageBox.Show("Termin uspješno ažuriran!", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else {
                                MessageBox.Show("Nema promjena za ažuriranje.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else {
                            MessageBox.Show("Nije pronađen termin za ažuriranje.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    LoadSchedules();
                    ClearInputs();
                }
                else {
                    throw new UpdateException("Molim odaberite termin kojeg želite ažurirati.");
                }
            }
            catch (UpdateException ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex) {
                var updateEx = new UpdateException($"Termin se nije uspješno ažurirao: {ex.Message}", ex);
                MessageBox.Show(updateEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            try {
                if (dgvSchedules.SelectedRows.Count > 0) {
                    int selectedTerminID = Convert.ToInt32(dgvSchedules.SelectedRows[0].Cells["terminIDDataGridViewTextBoxColumn"].Value);

                    using (var context = new OrdinacijaDB()) {
                        var terminToDelete = context.Termini.Find(selectedTerminID);
                        if (terminToDelete != null) {
                            context.Termini.Remove(terminToDelete);
                            context.SaveChanges();
                        }
                    }

                    LoadSchedules();
                    ClearInputs();

                    MessageBox.Show("Termin uspješno obrisan!", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else {
                    throw new DeleteException("Molim odaberite termin kojeg želite izbrisati iz baze.");
                }
            }
            catch (DeleteException ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex) {
                var deleteEx = new DeleteException($"Termin nije uspješno izbrisan iz baze: {ex.Message}", ex);
                MessageBox.Show(deleteEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
