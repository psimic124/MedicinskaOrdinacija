namespace MedicinskaOrdinacija
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Kartoni")]
    public partial class Karton
    {
        [Key]
        public int KartonID { get; set; }

        public int PacijentID { get; set; }

        public string Dijagnoza { get; set; }

        public byte[] Terapija { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DatumKartona { get; set; }

        public virtual Pacijent Pacijenti { get; set; }
    }
}
