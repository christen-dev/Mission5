using System.ComponentModel.DataAnnotations;

namespace Mission6_Christensen.Models
{
    public class Categories
    {
        [Key] // Primary Key attribute
        [Required]
        public int CategoryId { get; set; }
        [Required]
        public string Category { get; set; }
    }
}
