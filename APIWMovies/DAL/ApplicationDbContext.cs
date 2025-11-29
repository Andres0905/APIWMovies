using APIWMovies.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace APIWMovies.DAL
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        // Definimos el DbSet para la entidad Category

        public DbSet<Category> Categories { get; set; }


        // Definimos el DbSet para la entidad Movie
        public DbSet<Movie> Movies { get; set; }

    }
}
