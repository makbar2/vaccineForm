using System.ComponentModel.DataAnnotations.Schema;

public class VaccineApplied
{
    public int Id { get; set; }

    public DateOnly DateApplied { get; set; }

    public string Location { get; set; }

    [ForeignKey("Patient")]
    public int PatientId { get; set; }
    
    [ForeignKey("Vaccinator")]
    public int VaccinatorId { get; set; }   
    
}