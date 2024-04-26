using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InformationsMVC.Models
{
    public class Customer
    {
        [Key]
        [StringLength(50)]
        public int CustomerId { get; set; }
        [Required]
        [StringLength(50)]
        public string? CustomerName { get; set; }
        [Required]
        [StringLength(50)]
        public string? CustomerPhone { get; set;}
        [Required]
        [StringLength(50)]
        public string? CustomerEmail { get; set;}
        [Required]
        [StringLength(50)]
        public string? CustomerImage { get; set; }
        [ForeignKey("CategoryId")]
        public Category? Category { get; set; }

        [ForeignKey("BrandId")]
        public Brand? Brand { get; set; }
    }
}
