using Microsoft.EntityFrameworkCore;
using PixiStash.Core.Models;
using PixiStash.DataAccess;
using PixiStash.DataAccess.IRepositories;
using PixiStash.DataAccess.Persistence;

namespace PixiStash.DataAccess.Repositories
{
    public class CompanyRepository : BaseRepository<Company, Guid>, ICompanyRepository
    {
        private readonly IAppDbContext _context;
        public CompanyRepository(IAppDbContext context) : base((DbContext)context)
        {
            _context = context;
        }

        public virtual List<Company> GetByUserId(Guid UserId)
        {
            var companies = _context.Companies
            .Where(c => c.Users.Any(u => u.Id == UserId))
            .ToList();

            return companies;
        }

        public virtual Company GetByUserIdRole(Guid UserId)
        {
            //var company = _context.Companies
            //.Where(c => c.Users.Any(u => u.UserId == UserId
            // && u.Role == CompanyRole.SuperAdmin || u.Role == CompanyRole.Admin))
            //.FirstOrDefault();

            //return company
            //
            Company company = null;
            return company;
        }
    }
}
