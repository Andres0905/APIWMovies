using APIWMovies.DAL.Models.Dtos;

namespace APIWMovies.Services.Iservices
{
    public interface IMovieService
    {

        Task<IEnumerable<MovieDto>> GetMoviesAsync(); // Get all movies
        Task<MovieDto?> GetMovieAsync(int id); // Get a movie by ID
        Task<MovieDto> CreateMovieAsync(MovieCreateUpdateDto dto); // Create a new movie
        Task<MovieDto?> UpdateMovieAsync(int id, MovieCreateUpdateDto dto); // Update an existing movie
        Task<bool> DeleteMovieAsync(int id); // Delete a movie by ID

    }
}
