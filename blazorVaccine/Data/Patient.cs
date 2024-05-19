public class Patient
{
    public string? FirstName {get; set;}
    public string? Surname {get; set;}
    public DateOnly? Dob {get; set;}
    public string? Address {get; set;}
    public string? PhoneNumber {get; set;}
    public string? GPAddress {get; set;}
    public string? Email {get; set;}
    public PatientMedicalHistory? MedicalHistory;
    
    public int Gender;

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