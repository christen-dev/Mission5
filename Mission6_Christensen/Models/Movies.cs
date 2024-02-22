using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission6_Christensen.Models
{
    public class Movies
    {
        [Key] // Primary Key attribute
        [Required]
        public int MovieId { get; set; }
        public int CategoryID { get; set; }
        [ForeignKey("CategoryID")]
        public Categories Category { get; set; } // Navigation property
        [Required]
        public string Title { get; set; }
        [Required]
        [Range(1888, int.MaxValue, ErrorMessage = "The Year field must be greater than or equal to 1888.")]
        public int Year { get; set; }
        public string? Director { get; set; }
        public string? Rating { get; set; }
        [Required]
        public int Edited { get; set; }
        public string? LentTo { get; set; }
        [Required]
        public int CopiedToPlex { get; set; }
        [Length(0, 25)]
        public string? Notes { get; set; }
    }
}
