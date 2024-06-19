namespace MedicinskaOrdinacija
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Termini")]
    public partial class Termin
    {
        [Key]
        public int TerminID { get; set; }

        public int PacijentID { get; set; }

        public DateTime? DatumVrijeme { get; set; }

        public int DoktorID { get; set; }

        [StringLength(50)]
        public string Napomena { get; set; }

        public virtual Doktor Doktori { get; set; }

        public virtual Pacijent Pacijenti { get; set; }
    }
}
