using PixiStash.Core.Models;

namespace PixiStash.DataAccess.IRepositories
{
    public interface ICompanyRepository : IRepository<Company, Guid>
    {
        List<Company> GetByUserId(Guid UserId);
        Company GetByUserIdRole(Guid UserId);
    }
}
