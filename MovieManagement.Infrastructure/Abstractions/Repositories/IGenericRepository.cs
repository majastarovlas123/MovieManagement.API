using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManagement.Infrastructure.Abstractions.Repositories
{
    public interface IGenericRepository<TEntity, TKey>
        where TEntity : class
        where TKey : unmanaged
    {
        IQueryable<TEntity> GetAll();
        Task<TEntity> GetByIdAsync(TKey id);
        Task<TEntity> AddAsync(TEntity entity);
        Task<TEntity> UpdateAsync(TEntity entity);
        Task DeleteAsync(TKey id);
    }
}
