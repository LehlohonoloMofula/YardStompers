using System.ComponentModel.DataAnnotations;
using YardStompers.Models;
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
        public double Price { get; set;}
        [Required]
        public string image { get; set;}
        
        public virtual Category Category {get; set;}
        public DateTime CreatedAt { get; set;}
        public DateTime? ModifiedAt { get; set;}

    }
}
