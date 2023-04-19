using Microsoft.EntityFrameworkCore;
using SoftwareLab.Core.Entities;
using SoftwareLab.Core.Repositories;
using SoftwareLab.Infrastructure.Contexts;

namespace SoftwareLab.Infrastructure.Repositorries
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        private readonly DbSet<User> _users;    

        public UserRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _users = dbContext.Set<User>();
        }

        public async Task<User> GetByEmail(string email)
        {
            return await _users.FirstOrDefaultAsync(u => u.Email == email); // FirstOrDefault düz sorgu yapıyor-SELECT- en ustteki sorguyu getiriyor icindeki ise lambda sorgusu
        }
    }
}
