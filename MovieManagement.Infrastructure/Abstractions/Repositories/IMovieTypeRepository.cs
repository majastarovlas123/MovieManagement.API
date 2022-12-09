using MovieManagement.Infrastructure.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManagement.Infrastructure.Abstractions.Repositories
{
    public interface IMovieTypeRepository : IGenericRepository<MovieTypeDbModel, Guid>
    {
    }
}
