using PixiStash.Core.Models;

namespace PixiStash.DataAccess.IRepositories
{
    public interface ICustomerRepository : IRepository<Customer, Guid>
    {
        //List<Company> GetByUserId(Guid UserId);
        //Company GetByUserIdRole(Guid UserId);
    }
}
