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
    internal class ProductShelfRepository : BaseRepository<ProductShelf, Guid>, IProductShelfRepository
    {
        private readonly IAppDbContext _context;
        public ProductShelfRepository(IAppDbContext context) : base((DbContext)context)
        {
            _context = context;
        }

    }
}
