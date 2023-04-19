using SoftwareLab.Core.Entities;

namespace SoftwareLab.Core.Repositories
{
    public interface IUserRepository : IGenericRepository<User> //IUserRepository cagrildiginda artik IGenericRepository'nin icindeki tum metotlara sahip olduk(User tipinde)
    {
        Task<User> GetByEmail(string email);
    }
}
