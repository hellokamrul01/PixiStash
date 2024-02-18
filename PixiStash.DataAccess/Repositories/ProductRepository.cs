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
    internal class ProductRepository : BaseRepository<Product, Guid>, IProductRepository
    {
        private readonly IAppDbContext _context;
        public ProductRepository(IAppDbContext context) : base((DbContext)context)
        {
            _context = context;
        }

    }
}

