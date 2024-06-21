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
        public FormPeople() {
            InitializeComponent();
        }
        public void PrikaziSveOsobe(List<Osoba> osobe) {
            dgvPeople.Rows.Clear();
            foreach (var osoba in osobe) {
                int rowIndex = dgvPeople.Rows.Add();
                var row = dgvPeople.Rows[rowIndex];

                row.Cells["IDPeople"].Value = osoba.ID;
                row.Cells["PeopleName"].Value = osoba.Ime;
                row.Cells["PeopleSurname"].Value = osoba.Prezime;

                if (osoba is Pacijent pacijent) {
                    row.Cells["PeopleName"].Value = pacijent.Ime;
                    row.Cells["PeopleSurname"].Value = pacijent.Prezime;
                    row.Cells["IDPeople"].Value = pacijent.PacijentID;
                    row.Cells["PeopleType"].Value = "Pacijent";
                    row.Cells["PeoplePhone"].Value = pacijent.Telefon; 
                    row.Cells["PeopleAdditional"].Value = pacijent.Adresa;
                }
                else if (osoba is Doktor doktor) {
                    row.Cells["PeopleName"].Value = doktor.Ime;
                    row.Cells["PeopleSurname"].Value = doktor.Prezime;
                    row.Cells["IDPeople"].Value = doktor.DoktorID;
                    row.Cells["PeopleType"].Value = "Doktor";
                    row.Cells["PeoplePhone"].Value = doktor.Telefon; 
                    row.Cells["PeopleAdditional"].Value = doktor.Specijalizacija;
                }
            }
        }
    }
}
