using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MedicinskaOrdinacija {
    public partial class FormPatients : Form {
        public FormPatients() {
            InitializeComponent();
            OrdinacijaDB context = new OrdinacijaDB();

        }

        private void FormPatients_Load(object sender, EventArgs e) {
            this.pacijentiTableAdapter.Fill(this.medOrdinacijaDataSet.Pacijenti);

        }

        private void btnSave_Click(object sender, EventArgs e) {
            try {

                var newPacijent = new Pacijent {
                    Ime = tbName.Text,
                    Prezime = tbSurname.Text,
                    DatumRodjenja = dtp.Value,
                    Adresa = tbAdress.Text,
                    Telefon = tbPhone.Text,
                    PovijestBolesti = rtbHistory.Text
                };

                using (var context = new OrdinacijaDB()) {
                    context.Pacijenti.Add(newPacijent);
                    context.SaveChanges();
                }

                LoadPatients();
                ClearInputs();

                MessageBox.Show("Novi pacijent uspješno spremljen!", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) {
                MessageBox.Show($"Nije se pacijent uspješno spremio: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadPatients() {
            using (var context = new OrdinacijaDB()) {
                dgvPatients.DataSource = context.Pacijenti.ToList();
            }
        }

        private void ClearInputs() {
            tbName.Text = string.Empty;
            tbSurname.Text = string.Empty;
            dtp.Value = DateTime.Now;
            tbAdress.Text = string.Empty;
            tbPhone.Text = string.Empty;
            rtbHistory.Text = string.Empty;
        }

        private void btnUpdate_Click(object sender, EventArgs e) {
            try {
                if (dgvPatients.SelectedRows.Count > 0) {

                    int selectedPatientID = Convert.ToInt32(dgvPatients.SelectedRows[0].Cells["pacijentIDDataGridViewTextBoxColumn"].Value);

                    using (var context = new OrdinacijaDB()) {
                        var patientToUpdate = context.Pacijenti.Find(selectedPatientID);
                        if (patientToUpdate != null) {
                            bool isUpdated = false;

                            if (!string.IsNullOrEmpty(tbName.Text) && patientToUpdate.Ime != tbName.Text) {
                                patientToUpdate.Ime = tbName.Text;
                                isUpdated = true;
                            }
                            if (!string.IsNullOrEmpty(tbSurname.Text) && patientToUpdate.Prezime != tbSurname.Text) {
                                patientToUpdate.Prezime = tbSurname.Text;
                                isUpdated = true;
                            }
                            if (dtp.Value != patientToUpdate.DatumRodjenja) {
                                patientToUpdate.DatumRodjenja = dtp.Value;
                                isUpdated = true;
                            }
                            if (!string.IsNullOrEmpty(tbAdress.Text) && patientToUpdate.Adresa != tbAdress.Text) {
                                patientToUpdate.Adresa = tbAdress.Text;
                                isUpdated = true;
                            }
                            if (!string.IsNullOrEmpty(tbPhone.Text) && patientToUpdate.Telefon != tbPhone.Text) {
                                patientToUpdate.Telefon = tbPhone.Text;
                                isUpdated = true;
                            }
                            if (!string.IsNullOrEmpty(rtbHistory.Text) && patientToUpdate.PovijestBolesti != rtbHistory.Text) {
                                patientToUpdate.PovijestBolesti = rtbHistory.Text;
                                isUpdated = true;
                            }

                            if (isUpdated) {
                                context.SaveChanges();
                                MessageBox.Show("Pacijent uspješno ažuriran!", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else {
                                MessageBox.Show("Nema promjena za ažuriranje.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else {
                            MessageBox.Show("Nije pronađen pacijent za ažuriranje.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    LoadPatients();
                    ClearInputs();
                }
                else {
                    MessageBox.Show("Molim odaberite pacijenta kojeg želite ažurirati.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex) {
                MessageBox.Show($"Pacijent se nije uspješno ažurirao: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            try {
                if (dgvPatients.SelectedRows.Count > 0) {

                    int selectedPatientID = Convert.ToInt32(dgvPatients.SelectedRows[0].Cells["pacijentIDDataGridViewTextBoxColumn"].Value);

                    using (var context = new OrdinacijaDB()) {

                        var patientToDelete = context.Pacijenti.Find(selectedPatientID);
                        if (patientToDelete != null) {
                            context.Pacijenti.Remove(patientToDelete);
                            context.SaveChanges();
                        }
                    }

                    LoadPatients();
                    ClearInputs();

                    MessageBox.Show("Pacijent uspješno izbrisan iz baze!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else {
                    MessageBox.Show("Molim odaberite pacijenta kojeg želite izbrisati iz baze.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex) {
                MessageBox.Show($"Pacijent nije uspješno izbrisan iz baze: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
