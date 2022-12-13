using Microsoft.EntityFrameworkCore;
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
    public class RoleRepository : GenericRepository<RoleDbModel, Guid>, IRoleRepository
    {
        public RoleRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public IQueryable<RoleDbModel> GetAllWithIncludes()
        {
            var result = _dbSet.Include(x => x.Actor).Include(x => x.Movie);
            return result;
        }
    }
}
