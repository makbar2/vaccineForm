using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace blazorVaccine.Models;
public class PatientMedicalHistory
{
    public int id {get; set;}
    [NotNullValidation(ErrorMessage = "user hasnt selected anything for Question 1  ")]
    public string? FeelingUnwell { get; set; } = null;
    [NotNullValidation(ErrorMessage = "user hasnt selected anything for Question 2  ")]
    public string? Immunisations { get; set; } = null;
    [NotNullValidation(ErrorMessage = "user hasnt selected anything for Question 3  ")]
    public string? MedicalHistory { get; set; } = null;
    [NotNullValidation(ErrorMessage = "user hasnt selected anything for Question 4  ")]
    public string? CurrentMedicines { get; set; } = null;
    [NotNullValidation(ErrorMessage = "user hasnt selected anything for Question 5  ")]
    public string? Allergies { get; set; } = null;
    [NotNullValidation(ErrorMessage = "user hasnt selected anything for Question 6  ")]
    public string? SeriousReaction { get; set; } = null;
    [NotNullValidation(ErrorMessage = "user hasnt selected anything for Question 7  ")]
    public string? Hypersensitive { get; set; } = null;
    [NotNullValidation(ErrorMessage = "user hasnt selected anything for Question 8  ")]
    public string? Epilepsy { get; set; } = null;
    [NotNullValidation(ErrorMessage = "user hasnt selected anything for Question 9  ")]
    public string? BlackWaterFever { get; set; } = null;
    [NotNullValidation(ErrorMessage = "user hasnt selected anything for Question 10  ")]
    public string? LiverFunction { get; set; } = null;
    [NotNullValidation(ErrorMessage = "user hasnt selected anything for Question 11 ")]
    public string? BloodDisorders { get; set; } = null;
    [NotNullValidation(ErrorMessage = "user hasnt selected anything for Question 12  ")]
    public string? MedicalTreatment { get; set; } = null;
    [NotNullValidation(ErrorMessage = "user hasnt selected anything for Question 13  ")]
    public string? HistoryAnxiety { get; set; } = null;
    public string? Notes { get; set; } = "";

    [ForeignKey("Patient")]
    public int PatientId;

    public Patient? Patient;

    public void SetPatient(Patient patient)
    {
        this.Patient = patient;
    }
}