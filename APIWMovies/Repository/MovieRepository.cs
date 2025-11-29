using APIWMovies.DAL;
using APIWMovies.DAL.Models;
using APIWMovies.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace APIWMovies.Repository
{
    public class MovieRepository : IMovieRepository
    {
        private readonly ApplicationDbContext _context;

        public MovieRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        // Get all movies
        public async Task<ICollection<Movie>> GetMoviesAsync() 
        {
            return await _context.Movies
                .AsNoTracking()
                .OrderBy(c => c.Name)
                .ToListAsync();
        }

        //  Get movie by id
        public async Task<Movie?> GetMovieAsync(int id) 
        {
            return await _context.Movies
                .AsNoTracking()
                .FirstOrDefaultAsync(c => c.Id == id);
        }

        // Create a new movie
        public async Task<bool> CreateMovieAsync(Movie movie) 
        {
            movie.CreatedDate = DateTime.UtcNow;
            await _context.Movies.AddAsync(movie);
            return await SaveAsync();

        }

        // Update an existing movie
        public async Task<bool> UpdateMovieAsync(Movie movie) 
        {
            movie.ModifiedDate = DateTime.UtcNow;
            _context.Movies.Update(movie);
            return await SaveAsync();
        }

        // Delete a movie
        public async Task<bool> DeleteMovieAsync(int id) 
        {
            var movie = await GetMovieAsync(id); 

            if (movie == null)
            {
                return false; // return false if the movie does not exist
            }

            _context.Movies.Remove(movie);
            return await SaveAsync();
        }

        // Save changes to the database
        private async Task<bool> SaveAsync() 
        {
            return await _context.SaveChangesAsync() >= 0 ? true : false;
        }

    }
}
