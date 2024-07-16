using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace blazorVaccine.Models;
public class Patient
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Please enter the patients firstname")]
    public string? FirstName {get; set;}
    [Required]
    public string? Surname {get; set;}
    [Required]
    public DateOnly? Dob {get; set;}
    [Required]
    public string? Address {get; set;}
    [Required]
    public string? PhoneNumber {get; set;}
    [Required]
    public string? GPAddress {get; set;}
    [Required]
    public string? Email {get; set;}
    [Required]
    public PatientMedicalHistory? MedicalHistory;
    [Required]
    public int Gender;

    public List<VaccineApplied> VaccinesApplied { get; set; }

    public void setGender(string gender)
    {
        if(gender.ToLower() == "m")
        {
            this.Gender = 0;
        }else{
            this.Gender = 1;
        }
    }

    public string getGender()
    {
        if(this.Gender == 1)
        {
            return "f";
        }else{
            return "m";
        }
    }

    public void SetMedicalHistory(PatientMedicalHistory medicalHistory)
    {
        this.MedicalHistory = medicalHistory;
        this.MedicalHistory.SetPatient(this);
    }

    public PatientMedicalHistory GetMedicalHistory()
    {
        if(this.MedicalHistory == null)
        {
            throw new Exception("This patient doesn't have a medical history");
        }
        return this.MedicalHistory;
    }
}