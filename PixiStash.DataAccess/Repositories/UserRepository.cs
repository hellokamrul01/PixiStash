using Microsoft.EntityFrameworkCore;
using PixiStash.Core.Models;
using PixiStash.DataAccess.IRepositories;
using PixiStash.DataAccess.Persistence;

namespace PixiStash.DataAccess.Repositories
{
    public class UserRepository : BaseRepository<User, Guid>, IUserRepository
    {
        private readonly IAppDbContext _context;

        public UserRepository(IAppDbContext context) : base((DbContext)context)
        {
            _context = context;
        }

        public List<User> GetByCom(Guid ComId)
        {
            throw new NotImplementedException();
        }

        public User IncludeComapny(string Email)
        {
            throw new NotImplementedException();
        }



        //public virtual User IncludeComapny(string Email)
        //{
        //    User query = _context.Users.Include(x => x.).Where(x => x.Email == Email).FirstOrDefault();
        //    return query;
        //}

        //public virtual List<User> GetByCom(Guid ComId)
        //{
        //    var query = _context.Users.Include(x => x.Companies)
        //        .Where(x => x.Companies.Any(y => y.ComId == ComId)).ToList();
        //    return query;
        //}
    }

}
