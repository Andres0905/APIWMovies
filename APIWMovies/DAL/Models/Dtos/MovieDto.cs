namespace APIWMovies.DAL.Models.Dtos
{
    public class MovieDto
    {

        public int Id { get; set; } // Movie identifier
        public string Name { get; set; } // Movie name
        public int Duration { get; set; } // Duration in minutes
        public string? Description { get; set; } // Optional description
        public string Clasification { get; set; } // Movie classification
        public DateTime CreatedDate { get; set; } // Creation date
        public DateTime? ModifiedDate { get; set; } // Last update date

    }
}
