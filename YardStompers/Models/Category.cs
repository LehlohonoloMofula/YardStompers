using System.ComponentModel.DataAnnotations;

namespace YardStompers.Models
{
    public class Category
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
    }
}
