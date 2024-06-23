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
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
        }

        private void btnPatients_Click(object sender, EventArgs e) {
            FormPatients formPatients = new FormPatients();
            formPatients.ShowDialog();
        }

        private void btnDoctors_Click(object sender, EventArgs e) {
            FormDoctors formDoctors = new FormDoctors();
            formDoctors.ShowDialog();
        }

        private void btnCartons_Click(object sender, EventArgs e) {
            FormCartons formCartons = new FormCartons();
            formCartons.ShowDialog();
        }

        private void btnSchedules_Click(object sender, EventArgs e) {
            FormSchedules formSchedules = new FormSchedules();
            formSchedules.ShowDialog();
        }

        private void btnPeople_Click(object sender, EventArgs e) {
            FormPeople formPeople = new FormPeople();
            formPeople.ShowDialog();
        }
    }
}
