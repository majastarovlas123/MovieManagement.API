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
    public class MovieTypeRepository : GenericRepository<MovieType, Guid>, IMovieTypeRepository
    {
        public MovieTypeRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
