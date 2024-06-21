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

        private void btnShow_Click(object sender, EventArgs e) {
            using (var context = new OrdinacijaDB()) {
                List<Osoba> osobe = new List<Osoba>();

                var pacijenti = context.Pacijenti.Select(p => new {
                    PacijentID = p.PacijentID,
                    Ime = p.Ime,
                    Prezime = p.Prezime,
                    Telefon = p.Telefon,
                    Adresa = p.Adresa,
                }).ToList().Select(p => new Pacijent {
                    PacijentID = p.PacijentID,
                    Ime = p.Ime,
                    Prezime = p.Prezime,
                    Telefon = p.Telefon,
                    Adresa = p.Adresa
                }).ToList();
                osobe.AddRange(pacijenti);

                var doktori = context.Doktori.Select(d => new{
                    DoktorID = d.DoktorID,
                    Ime = d.Ime,
                    Prezime = d.Prezime,
                    Telefon = d.Telefon,
                    Specijalizacija = d.Specijalizacija,
                }).ToList().Select(d => new Doktor {
                    DoktorID = d.DoktorID,
                    Ime = d.Ime,
                    Prezime = d.Prezime,
                    Telefon = d.Telefon,
                    Specijalizacija = d.Specijalizacija
                }).ToList();
                osobe.AddRange(doktori);

                FormPeople formPeople = new FormPeople();
                formPeople.PrikaziSveOsobe(osobe);
                formPeople.ShowDialog();
            }
        }
    }
}
