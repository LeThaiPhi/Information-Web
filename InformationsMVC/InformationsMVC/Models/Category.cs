using System.ComponentModel.DataAnnotations;
namespace InformationsMVC.Models
{
    public class Category
    {
        [Key]
        [StringLength(50)]
        public int CategoryId { get; set; }
        [Required]
        [StringLength(50)]
        public string? CategoryName { get; set; }
        [Required]
        [StringLength(50)]
        public string? CategoryDescription { get; set; }
        [Required]
        public int ? CategoryCustomer {  get; set; }
        public ICollection<Customer>? Customers { get; set; }
    }
}
