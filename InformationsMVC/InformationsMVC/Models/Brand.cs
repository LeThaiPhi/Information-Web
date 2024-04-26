using System.ComponentModel.DataAnnotations;

namespace InformationsMVC.Models
{
    public class Brand
    {
        [Key]
        public int BrandId { get; set; }
        [Required]
        [StringLength(50)]
        public string? BrandName { get; set; }
        [Required]
        [StringLength(50)]
        public string? BrandDescription { get; set;}
        [Required]
        public string? BrandCustomer { get; set;}
        public ICollection<Customer>? Customers { get; set; }
    }
}
