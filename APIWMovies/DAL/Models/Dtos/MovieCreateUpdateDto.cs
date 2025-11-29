using System.ComponentModel.DataAnnotations;

namespace APIWMovies.DAL.Models.Dtos
{
    public class MovieCreateUpdateDto
    {

        [Required] // indicates that the field is required
        [StringLength(100)] // Maximum length of 100 characters
        public string Name { get; set; } // Movie name

        [Required]
        public int Duration { get; set; } // Duration in minutes

        public string? Description { get; set; } // Optional description

        [Required]
        [StringLength(10)]
        public string Clasification { get; set; } // Movie classification

    }
}
