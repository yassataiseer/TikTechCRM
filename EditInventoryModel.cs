using System.ComponentModel.DataAnnotations;

public class EditInventoryModel
{
    [Required]
    public string Barcode { get; set; }

    [Required]
    public double Price { get; set; }
    [Required]
    public int Quantity { get; set; }
    [Required]
    public string Status { get; set; }
}

