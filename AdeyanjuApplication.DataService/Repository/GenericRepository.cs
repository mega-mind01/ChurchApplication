using AdeyanjuApplication.DataService.Data;
using AdeyanjuApplication.DataService.Repository.Interface;
using AdeyanjuApplication.Entities.DbSet;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdeyanjuApplication.DataService.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        public readonly AppDbContext _dbContext;
        protected readonly ILogger _logger;
        internal DbSet<T> _dbSet;

        public GenericRepository(AppDbContext dbContext, ILogger logger)
        {
            _dbContext = dbContext;
            _logger = logger;
            _dbSet = dbContext.Set<T>();
        }
        public virtual async Task<bool> Add(T entity)
        {
            await _dbSet.AddAsync(entity);
            return true;
        }

        public virtual async Task<bool> Delete(string Id)
        {
            var result = await _dbSet.FindAsync(Id);
            if (result != null)
            {
                _dbContext.Remove(result);
                return true;
            }
            return false;
        }

        public virtual async Task<T?> FindById(string Id)
        {
            return await _dbSet.FindAsync(Id);
        }

        public virtual async Task<IEnumerable<T>> GetAll()
        {
            return await _dbSet.ToListAsync();
        }

        public virtual async Task<bool> Update(T entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            return true;
        }
    }
}
