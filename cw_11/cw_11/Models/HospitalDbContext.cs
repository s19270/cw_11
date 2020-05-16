﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cw_11.Models
{
    public class HospitalDbContext : DbContext
    {
        public DbSet<Doctor> Doctor { get; set; }
        public DbSet<Medicament> Medicament { get; set; }
        public DbSet<Patient> Patient { get; set; }
        public DbSet<Prescription> Prescription { get; set; }
        public DbSet<Prescription_Medicament> Prescription_Medicament { get; set; }
        public HospitalDbContext() { }
        public HospitalDbContext(DbContextOptions options) :base(options){ }
    }
}
