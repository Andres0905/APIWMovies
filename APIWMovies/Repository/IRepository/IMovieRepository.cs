using APIWMovies.DAL.Models;

namespace APIWMovies.Repository.IRepository
{
    public interface IMovieRepository
    {

        Task<ICollection<Movie>> GetMoviesAsync(); // Get all the movies
        Task<Movie?> GetMovieAsync(int id); // Get a movie by its ID
        Task<bool> CreateMovieAsync(Movie movie); // Create a new movie
        Task<bool> UpdateMovieAsync(Movie movie); // Update an existing movie
        Task<bool> DeleteMovieAsync(int id); // Delete a movie by its ID

    }
    }
