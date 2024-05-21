using Microsoft.EntityFrameworkCore;
using MySql.EntityFrameworkCore.Extensions;
using blazorVaccine.Models;

namespace blazorVaccine.Data;

public class BlazorVaccineContext : DbContext
{
    public DbSet<Patient> Patient { get; set; }
    public DbSet <PatientMedicalHistory> PatientMedicalHistory{ get; set; }
    public DbSet <Vaccines> Vaccines{ get; set; }
    public DbSet <VaccineApplied> VaccineApplied{ get; set; }
    public DbSet <Vaccinator> Vaccinator{ get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Corrected connection string for MySQL with port specified
        optionsBuilder.UseMySQL("server=127.0.0.1;port=3306;database=blazor;user=root;password=root");
    }

}