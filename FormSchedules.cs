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
        }

        private void FormSchedules_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'medOrdinacijaDataSet.Termini' table. You can move, or remove it, as needed.
            this.terminiTableAdapter.Fill(this.medOrdinacijaDataSet.Termini);

        }
    }
}
