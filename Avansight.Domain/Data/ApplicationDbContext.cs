using Avansight.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Avansight.Domain.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Study> Studies { get; set; }
        public DbSet<TreatmentGroup> TreatmentGroups { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Write Fluent API configurations here

            //Property Configurations
            modelBuilder.Entity<Study>().Ignore(t => t.Patient);
            modelBuilder.Entity<TreatmentGroup>().Ignore(t => t.Patient);
            modelBuilder.Entity<Study>()
            .HasOne(s => s.Patient)
            .WithOne(i => i.Study)
            .HasForeignKey<Patient>(p => p.StudyId);

            modelBuilder.Entity<TreatmentGroup>()
            .HasOne(s => s.Patient)
            .WithOne(i => i.TreatmentGroup)
            .HasForeignKey<Patient>(p => p.TreatmentCode);
        }
    }

    
}
