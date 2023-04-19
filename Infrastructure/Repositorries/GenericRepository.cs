using Microsoft.EntityFrameworkCore;
using SoftwareLab.Core.Repositories;
using SoftwareLab.Infrastructure.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareLab.Infrastructure.Repositorries
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {

        private readonly ApplicationDbContext _dbContext;

        public GenericRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<T> AddAsync(T entitiy)
        {
            _dbContext.Set<T>().Add(entitiy);
            await _dbContext.SaveChangesAsync();
            return entitiy;
        }

        public Task DeleteAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public async Task<IReadOnlyList<T>> GetAllAsync()
        {
            return await _dbContext.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _dbContext.Set<T>().FindAsync(id);

        }

        public Task<IReadOnlyList<T>> GetPageResponseAsync(int pageNumber, int pageSize)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(T entitiy)
        {
            throw new NotImplementedException();
        }
    }
}
