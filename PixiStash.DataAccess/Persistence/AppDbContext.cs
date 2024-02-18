using Microsoft.EntityFrameworkCore;
using PixiStash.Core.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using PixiStash.Core.Models.ApplicationUser;

namespace PixiStash.DataAccess.Persistence
{
  //  public class AppDbContext : IdentityDbContext<IdentityUser>, IAppDbContext
   public class AppDbContext : IdentityDbContext<ApplicationUser>, IAppDbContext
    {

        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
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

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<ProductShelf>()
        //         .HasKey(p => p.Id);

        //    modelBuilder.Entity<ProductShelf>()
        //        .HasOne(p => p.Branch)
        //        .WithMany(b => b.ProductShelves)
        //        .HasForeignKey(p => p.BranchId)
        //        .OnDelete(DeleteBehavior.Cascade);

        //    modelBuilder.Entity<ProductShelf>()
        //        .HasOne(p => p.Company)
        //        .WithMany(c => c.ProductShelves)
        //        .HasForeignKey(p => p.CompanyId)
        //        .OnDelete(DeleteBehavior.Cascade);

        //    // Configure other entities and their relationships if needed

        //    base.OnModelCreating(modelBuilder);

        //}


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Branch>()
            //.HasOne(b => b.Company)
            //.WithMany(c => c.Branches)
            //.HasForeignKey(b => b.ComapnyId)
            //.IsRequired();


            modelBuilder.Entity<ProductShelf>()
         .HasKey(p => p.Id);

            modelBuilder.Entity<ProductShelf>()
                .HasOne(p => p.Branch)
                .WithMany(b => b.ProductShelves)
                .HasForeignKey(p => p.BranchId);

            //modelBuilder.Entity<ProductShelf>()
            //    .HasOne(p => p.Company)
            //    .WithMany(c => c.ProductShelves)
            //    .HasForeignKey(p => p.CompanyId);

            // Configure other entities and their relationships if needed

            base.OnModelCreating(modelBuilder);
        }


    }
}
