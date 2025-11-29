using System.ComponentModel.DataAnnotations;

namespace APIWMovies.DAL.Models
{
    public class Movie : AuditBase
    {
        [Display(Name = "Movie Title")] // used to show a friendly name in views

        [Required(ErrorMessage = "The movie title is required.")] // indicates that the field is mandatory
        [StringLength(100, ErrorMessage = "The name cannot exceed 100 characters.")] // Maximum length of 100 characters
        public required string Name { get; set; } // Movie name

        [Required(ErrorMessage = "The duration is mandatory.")] // indicates that the field is mandatory
        public int Duration { get; set; } // Duration in minutes
        public string? Description { get; set; } // Optional description


        [Required(ErrorMessage = "Classification is mandatory.")]
        [StringLength(10, ErrorMessage = "The classification cannot exceed 10 characters.")]
        public required string Clasification { get; set; } // Movie classification


    }
}
