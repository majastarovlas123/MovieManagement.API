using MovieManagement.Infrastructure.Abstractions.Repositories;
using MovieManagement.Infrastructure.Context;
using MovieManagement.Infrastructure.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManagement.Infrastructure.Repositories
{
    public class MovieRepository : GenericRepository<Movie, Guid>, IMovieRepository
    {
        public MovieRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
