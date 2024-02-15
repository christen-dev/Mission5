using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Mission6_Christensen.Models
{
    public class Movie
    {
        [Key] // Primary Key attribute
        [Required]
        public int MovieId { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public int Year { get; set; }
        [Required]
        public string Director { get; set; }
        [Required]
        public string Rating { get; set; }
        public bool Edited { get; set; }
        public string? Lent { get; set; }
        [Length(0, 25)]
        public string? Notes { get; set; }

    }
}
