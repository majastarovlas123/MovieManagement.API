using Microsoft.EntityFrameworkCore;
using MovieManagement.Infrastructure.DbModels;

namespace MovieManagement.Infrastructure.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Actor> Actors { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<MovieType> MovieTypes { get; set; }
    }
}
