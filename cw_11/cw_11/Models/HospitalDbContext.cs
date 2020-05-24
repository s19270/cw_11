using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cw_11.Models
{
    //PM> add-migration ... - stworzenie migracji
    //PM> update-database - zaaktualizowanie bazy danych
    //PM> script-migration - wyswietlenie skryptu SQL
    public class HospitalDbContext : DbContext
    {
        public DbSet<Doctor> Doctor { get; set; }
        public DbSet<Medicament> Medicament { get; set; }
        public DbSet<Patient> Patient { get; set; }
        public DbSet<Prescription> Prescription { get; set; }
        public DbSet<Prescription_Medicament> Prescription_Medicament { get; set; }
        public HospitalDbContext() { }
        public HospitalDbContext(DbContextOptions options) :base(options){ }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Prescription_Medicament>().HasKey(e => new { e.IdMedicament, e.IdPrescription });
        }
    }
}
