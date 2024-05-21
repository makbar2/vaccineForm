using System.ComponentModel.DataAnnotations.Schema;

namespace blazorVaccine.Models;
public class PatientMedicalHistory
{
    public int? id;
    public bool? FeelingUnwell { get; set; }
    public bool? Immunisations { get; set; }
    public bool? MedicalHistory { get; set; }
    public bool? CurrentMedicines { get; set; }
    public bool? Allergies { get; set; }
    public bool? SeriousReaction { get; set; }
    public bool? Hypersensitive { get; set; }
    public bool? Epilepsy { get; set; }
    public bool? BlackWaterFever { get; set; }
    public bool? LiverFunction { get; set; }
    public bool? BloodDisorders { get; set; }
    public bool? MedicalTreatment { get; set; }
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