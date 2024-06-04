using CodeFirstMy.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstMy.Data;

public class ApplicationContext : DbContext
{
    protected ApplicationContext()
    {
    }

    public ApplicationContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Doctor> Doctors { get; set; }
    public DbSet<Patient> Patients { get; set; }
    public DbSet<Medicament> Medicaments { get; set; }
    public DbSet<Prescription> Prescriptions { get; set; }
    public DbSet<PrescriptionMedicament> PrescriptionMedicaments { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        // modelBuilder.Entity<Author>().HasData(new List<Author>()
        // {
        //     new() { Id = 1, FirstName = "John", LastName = "Doe"},
        //     new() { Id = 2, FirstName = "Ann", LastName = "Smith"},
        //     new() { Id = 3, FirstName = "Jack", LastName = "Taylor"}
        // });
    }
}