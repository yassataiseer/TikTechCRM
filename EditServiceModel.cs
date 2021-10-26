using System.ComponentModel.DataAnnotations;

public class EditServiceModel
{
    [Required]        
    public double Service_cost { get; set; }
    [Required]
    public string Service_purpose { get; set; }
}
