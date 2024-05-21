using blazorVaccine.Components.Pages;
using blazorVaccine.Models;
using Microsoft.EntityFrameworkCore;
namespace blazorVaccine.Data;

public class BlazorVaccineContext : DbContext
{
    public DbSet<Patient> Patients { get; set; }
    public DbSet <PatientDetails> PatientDetails{ get; set; }
}