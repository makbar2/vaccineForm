using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace blazorVaccine.Models;
public class PatientMedicalHistory
{
    public int id {get; set;}
    [Required]
    public bool? FeelingUnwell { get; set; }
    [Required]
    public bool? Immunisations { get; set; }
    [Required]
    public string? MedicalHistory { get; set; } = "";
    [Required]
    public string? CurrentMedicines { get; set; } = "";
    [Required]
    public bool? Allergies { get; set; }
    [Required]
    public bool? SeriousReaction { get; set; }
    [Required]
    public bool? Hypersensitive { get; set; }
    [Required]
    public bool? Epilepsy { get; set; }
    [Required]
    public bool? BlackWaterFever { get; set; }
    [Required]
    public bool? LiverFunction { get; set; }
    [Required]
    public bool? BloodDisorders { get; set; }
    [Required]
    public bool? MedicalTreatment { get; set; }
    [Required]
    public bool? HistoryAnxiety { get; set; }
    public string? Notes { get; set; }

    [ForeignKey("Patient")]
    public int PatientId;

    public Patient Patient;

    public void SetPatient(Patient patient)
    {
        this.Patient = patient;
    }
}