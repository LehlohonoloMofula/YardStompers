using System.ComponentModel.DataAnnotations;

namespace YardStompers.Models
{
    public class ApplicationType
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        public DateTime CreatedAt { get; set;}
        public DateTime? ModifiedAt { get; set;}
    }
}
