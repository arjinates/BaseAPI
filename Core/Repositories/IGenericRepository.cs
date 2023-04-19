using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareLab.Core.Repositories
{
    public interface IGenericRepository<T> where T : class //her entitiy icin tekrar yazmak zorunda kalmadan burdan inheritance ile refereans alacacagiz
    {
        Task<T> GetByIdAsync(int id);
        
        Task<IReadOnlyList<T>> GetAllAsync();
        
        Task<IReadOnlyList<T>> GetPageResponseAsync(int pageNumber, int pageSize);
        
        Task<T> AddAsync(T entitiy);

        Task UpdateAsync(T entitiy);
        
        Task DeleteAsync(T entity);
    }
}
