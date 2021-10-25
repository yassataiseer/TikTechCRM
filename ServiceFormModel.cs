using System.ComponentModel.DataAnnotations;
public class ServiceFormModel
{
        [Required]        
        public double Service_cost { get; set; }
        [Required]
        public string Service_name { get; set; }
        [Required]
        public string Service_purpose { get; set; }
}