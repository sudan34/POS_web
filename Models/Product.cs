using System.ComponentModel.DataAnnotations;

namespace POS_web.Models
{
    public class Product
    {
        public Guid ProductId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        public decimal PriceSell { get; set; }
        [Required]
        public decimal PricePurchase { get; set; }
    }
}
