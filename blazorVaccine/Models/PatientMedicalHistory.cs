using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace blazorVaccine.Models;
public class PatientMedicalHistory
{
    public int id {get; set;}
    [Required]
    public string? FeelingUnwell { get; set; } = "";
    [Required]
    public string? Immunisations { get; set; } = "";
    [Required]
    public string? MedicalHistory { get; set; } = "";
    [Required]
    public string? CurrentMedicines { get; set; } = "";
    [Required]
    public string? Allergies { get; set; } = "";
    [Required]
    public string? SeriousReaction { get; set; } = "";
    [Required]
    public string? Hypersensitive { get; set; } = "";
    [Required]
    public string? Epilepsy { get; set; } = "";
    [Required]
    public string? BlackWaterFever { get; set; } = "";
    [Required]
    public string? LiverFunction { get; set; } = "";
    [Required]
    public string? BloodDisorders { get; set; } = "";
    [Required]
    public string? MedicalTreatment { get; set; } = "";
    [Required]
    public string? HistoryAnxiety { get; set; } = "";
    public string? Notes { get; set; } = "";

    [ForeignKey("Patient")]
    public int PatientId;

    public Patient? Patient;

    public void SetPatient(Patient patient)
    {
        this.Patient = patient;
    }
}