using System.ComponentModel.DataAnnotations;

namespace POS_web.Models
{
    public class Customer
    {
        public Guid CustomerId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
    }
}
