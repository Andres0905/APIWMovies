using APIWMovies.DAL.Models;
using APIWMovies.DAL.Models.Dtos;
using APIWMovies.Repository.IRepository;
using APIWMovies.Services.Iservices;
using AutoMapper;

namespace APIWMovies.Services
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _movieRepository;
        private readonly IMapper _mapper;

        public MovieService(IMovieRepository movieRepository, IMapper mapper)
        {
            _movieRepository = movieRepository;
            _mapper = mapper;
        }

        // Get all movies
        public async Task<IEnumerable<MovieDto>> GetMoviesAsync()
        {

            var movies = await _movieRepository.GetMoviesAsync();
            return _mapper.Map<ICollection<MovieDto>>(movies);

        }

        // Get a movie by id
        public async Task<MovieDto?> GetMovieAsync(int id)
        {

            var movie = await _movieRepository.GetMovieAsync(id);
            return movie is null ? null : _mapper.Map<MovieDto>(movie);

        }

        // Create a new movie
        public async Task<MovieDto> CreateMovieAsync(MovieCreateUpdateDto dto) 
        {

            var entity = _mapper.Map<Movie>(dto);

            var created = await _movieRepository.CreateMovieAsync(entity);
            if (!created)
            {
                throw new Exception("An error occurred while creating the movie.");
            }

            return _mapper.Map<MovieDto>(entity);

        }

        // Update an existing movie
        public async Task<MovieDto?> UpdateMovieAsync(int id, MovieCreateUpdateDto dto)
        {

            var entity = await _movieRepository.GetMovieAsync(id);
            if (entity is null)
            {
                return null; // No existe la película
            }

            _mapper.Map(dto, entity);

            var updated = await _movieRepository.UpdateMovieAsync(entity);
            if (!updated)
            {
                throw new Exception("An error occurred while updating the movie.");
            }

            return _mapper.Map<MovieDto>(entity);

        }


        // Delete a movie by id
        public async Task<bool> DeleteMovieAsync(int id)
        {

            var entity = await _movieRepository.GetMovieAsync(id);
            if (entity is null)
            {
                throw new InvalidOperationException($"The movie with ID was not found:'{id}'.");
            }

            var deleted = await _movieRepository.DeleteMovieAsync(id);
            if (!deleted)
            {
                throw new Exception("An error occurred while deleting the movie.");
            }

            return deleted;
        }
    }
}
