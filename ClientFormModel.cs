using System.ComponentModel.DataAnnotations;
public class ClientFormModel
{
    [Required] 
    public string Address { get; set; }
    [Required]
    public string Email { get; set; }

    [Required]
    public string Phone_Number { get; set; }
    [Required]
    public string Postal_code { get; set; }
    [Required]
    public string Username { get; set; }
}

