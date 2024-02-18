using Microsoft.EntityFrameworkCore;
using PixiStash.Core.Models;
using PixiStash.DataAccess.IRepositories;
using PixiStash.DataAccess.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixiStash.DataAccess.Repositories
{
    public class BrachRepository : BaseRepository<Branch, Guid>, IBranchRepository
    {
        private readonly IAppDbContext _context;
        public BrachRepository(IAppDbContext context) : base((DbContext)context)
        {
            _context = context;
        }

        public List<Branch> GetByComId(Guid ComId)
        {
            var branches = _context.Branches
                .Where(b => b.CompanyId == ComId)
                .ToList();
            return branches;
        }

        //public List<Branch> GetByComId(Guid ComId)
        //{
        //    var companies = _context.Companies
        //    .Where(c => c.Branches.Any(u => u.BranchId == ComId))
        //    .ToList();

        //    return companies;
        //}

        public Branch GetByUser(Guid UserId)
        {
            throw new NotImplementedException();
        }

       
    }
}
