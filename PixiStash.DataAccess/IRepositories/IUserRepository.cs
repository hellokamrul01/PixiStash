using PixiStash.Core.Models;

namespace PixiStash.DataAccess.IRepositories
{
    public interface IUserRepository : IRepository<User, Guid>
    {
        User IncludeComapny(string Email);
        List<User> GetByCom(Guid ComId);
    }
}
