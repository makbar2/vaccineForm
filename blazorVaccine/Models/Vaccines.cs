using System.ComponentModel.DataAnnotations;
public class Vaccines
{
    [Key]
    public string BatchNumber { get; set; }
    public DateOnly Expirey { get; set; }
    public string Type { get; set; }
    public string Brand { get; set; }
}