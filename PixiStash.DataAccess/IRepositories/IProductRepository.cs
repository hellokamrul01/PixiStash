﻿using PixiStash.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixiStash.DataAccess.IRepositories
{
    public interface IProductRepository : IRepository<Product, Guid>
    {
    }
}
