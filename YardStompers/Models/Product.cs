using System.ComponentModel.DataAnnotations;

namespace YardStompers.Models
{
    public class Product
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Discription { get; set; }
        [Required]
        public double Price { get; set}
    }
}
