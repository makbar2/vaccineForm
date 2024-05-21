using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

public class Vaccinator
{
    [Key]
    public string GPHC { get; set; }
    
    public string FirstName { get; set; }
    public string Surname { get; set; }
}