using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace MedicinskaOrdinacija {
    public partial class FormDoctors : Form {
        public FormDoctors() {
            InitializeComponent();
            OrdinacijaDB context = new OrdinacijaDB();
        }

        private void FormDoctors_Load(object sender, EventArgs e) {
            this.doktoriTableAdapter.Fill(this.medOrdinacijaDataSet.Doktori);

        }

        private void btnSave_Click(object sender, EventArgs e) {
            try {

                var newDoktor = new Doktor {
                    Ime = tbName.Text,
                    Prezime = tbSurname.Text,
                    Specijalizacija = tbSpec.Text,
                    Telefon = tbPhone.Text,
                    Email = tbEmail.Text
                };

                using (var context = new OrdinacijaDB()) {
                    context.Doktori.Add(newDoktor);
                    context.SaveChanges();
                }

                LoadPatients();
                ClearInputs();

                MessageBox.Show("Novi doktor uspješno spremljen!", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) {
                MessageBox.Show($"Nije se doktor uspješno spremio: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadPatients() {
            using (var context = new OrdinacijaDB()) {
                dgvDoctors.DataSource = context.Doktori.ToList();
            }
        }

        private void ClearInputs() {
            tbName.Text = string.Empty;
            tbSurname.Text = string.Empty;
            tbSpec.Text = string.Empty;
            tbPhone.Text = string.Empty;
            tbEmail.Text = string.Empty;
        }

        private void btnUpdate_Click(object sender, EventArgs e) {
            try {
                if (dgvDoctors.SelectedRows.Count > 0) {

                    int selectedDoctorID = Convert.ToInt32(dgvDoctors.SelectedRows[0].Cells["doktorIDDataGridViewTextBoxColumn"].Value);

                    using (var context = new OrdinacijaDB()) {
                        var doctorToUpdate = context.Doktori.Find(selectedDoctorID);
                        if (doctorToUpdate != null) {

                            doctorToUpdate.Ime = tbName.Text;
                            doctorToUpdate.Prezime = tbSurname.Text;
                            doctorToUpdate.Specijalizacija = tbSpec.Text;
                            doctorToUpdate.Telefon = tbPhone.Text;
                            doctorToUpdate.Email = tbEmail.Text;

                            context.SaveChanges();
                        }
                    }

                    LoadPatients();
                    ClearInputs();

                    MessageBox.Show("Doktor uspješno ažuriran!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else {
                    MessageBox.Show("Molim odaberite doktora kojeg želite ažurirati.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex) {
                MessageBox.Show($"Doktor se nije uspješno ažurirao: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            try {
                if (dgvDoctors.SelectedRows.Count > 0) {

                    int selectedDoctorID = Convert.ToInt32(dgvDoctors.SelectedRows[0].Cells["doktorIDDataGridViewTextBoxColumn"].Value);

                    using (var context = new OrdinacijaDB()) {

                        var doctorToDelete = context.Doktori.Find(selectedDoctorID);
                        if (doctorToDelete != null) {
                            context.Doktori.Remove(doctorToDelete);
                            context.SaveChanges();
                        }
                    }

                    LoadPatients();
                    ClearInputs();

                    MessageBox.Show("Doktor uspješno izbrisan iz baze!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else {
                    MessageBox.Show("Molim odaberite doktora kojeg želite izbrisati iz baze.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex) {
                MessageBox.Show($"Doktor nije uspješno izbrisan iz baze: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
