using System.ComponentModel.DataAnnotations;

namespace YardStompers.Models
{
    public class Category
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        public Guid DisplayOrder { get; set; }
        public DateTime CreatedAt { get; set}
        public DateTime? ModifiedAt { get; set}
    }
}
