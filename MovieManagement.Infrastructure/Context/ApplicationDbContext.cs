using Microsoft.EntityFrameworkCore;
using MovieManagement.Infrastructure.DbModels;

namespace MovieManagement.Infrastructure.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<ActorDbModel> Actors { get; set; }
        public DbSet<RoleDbModel> Roles { get; set; }
        public DbSet<MovieDbModel> Movies { get; set; }
        public DbSet<MovieTypeDbModel> MovieTypes { get; set; }
    }
}
