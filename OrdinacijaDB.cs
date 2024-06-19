using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace MedicinskaOrdinacija {
    public partial class OrdinacijaDB : DbContext {
        public OrdinacijaDB()
            : base("name=OrdinacijaDB") {
        }

        public virtual DbSet<Doktor> Doktori { get; set; }
        public virtual DbSet<Karton> Kartoni { get; set; }
        public virtual DbSet<Pacijent> Pacijenti { get; set; }
        public virtual DbSet<Termin> Termini { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            modelBuilder.Entity<Doktor>()
                .Property(e => e.Ime)
                .IsUnicode(false);

            modelBuilder.Entity<Doktor>()
                .Property(e => e.Prezime)
                .IsUnicode(false);

            modelBuilder.Entity<Doktor>()
                .Property(e => e.Specijalizacija)
                .IsUnicode(false);

            modelBuilder.Entity<Doktor>()
                .Property(e => e.Telefon)
                .IsFixedLength();

            modelBuilder.Entity<Doktor>()
                .Property(e => e.Email)
                .IsFixedLength();

            modelBuilder.Entity<Doktor>()
                .HasMany(e => e.Termini)
                .WithRequired(e => e.Doktori)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Karton>()
                .Property(e => e.Dijagnoza)
                .IsUnicode(false);

            modelBuilder.Entity<Pacijent>()
                .Property(e => e.Ime)
                .IsUnicode(false);

            modelBuilder.Entity<Pacijent>()
                .Property(e => e.Prezime)
                .IsUnicode(false);

            modelBuilder.Entity<Pacijent>()
                .Property(e => e.Adresa)
                .IsUnicode(false);

            modelBuilder.Entity<Pacijent>()
                .Property(e => e.Telefon)
                .IsFixedLength();

            modelBuilder.Entity<Pacijent>()
                .Property(e => e.PovijestBolesti)
                .IsUnicode(false);

            modelBuilder.Entity<Pacijent>()
                .HasMany(e => e.Kartoni)
                .WithRequired(e => e.Pacijenti)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Pacijent>()
                .HasMany(e => e.Termini)
                .WithRequired(e => e.Pacijenti)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Termin>()
                .Property(e => e.Napomena)
                .IsUnicode(false);
        }
    }
}
