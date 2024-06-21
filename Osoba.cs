using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicinskaOrdinacija {
    public abstract class Osoba {
        public int ID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }

        public abstract void PrikaziInformacije();
    }
}
