using Microsoft.EntityFrameworkCore;
using PixiStash.Core.Models;

namespace PixiStash.DataAccess.Persistence
{
    public interface IAppDbContext
    {
        // public DbSet<User> Users { get; set; }

        //public DbSet<Company> Companies { get; set; }

        //public DbSet<UserCompany> UserCompanies { get; set; }

        public DbSet<Product> Products { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Vendor> Vendors { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        //public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<ProductShelf> ProductShelves { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<SalesOrder> SalesOrders { get; set; }
        public DbSet<Sales> Sales { get; set; }
        public DbSet<PurchaseOrder> PurchaseOrders { get; set; }
    }
}
