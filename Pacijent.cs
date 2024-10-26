namespace MedicinskaOrdinacija
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Pacijenti")]
    public partial class Pacijent
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pacijent()
        {
            Kartoni = new HashSet<Karton>();
            Termini = new HashSet<Termin>();
        }

        [Key]
        public int PacijentID { get; set; }

        [StringLength(50)]
        public string Ime { get; set; }

        [StringLength(50)]
        public string Prezime { get; set; }

        public DateTime? DatumRodjenja { get; set; }

        [StringLength(50)]
        public string Adresa { get; set; }

        [StringLength(10)]
        public string Telefon { get; set; }

        public string PovijestBolesti { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Karton> Kartoni { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Termin> Termini { get; set; }
    }
}
