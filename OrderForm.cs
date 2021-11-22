using System.ComponentModel.DataAnnotations;
using System;
public class OrderForm
{   
        [Required]
        public string Accessory { get; set; }
        [Required]
        public DateTime Add_date { get; set; }
        [Required]
        public string Brand { get; set; }
        [Required]
        public string Client { get; set; }
        [Required]
        public string Comments { get; set; }
        [Required]
        public string Employee { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public string Product { get; set; }
        [Required]
        public string Service { get; set; }
        [Required]
        public string Status { get; set; }
}