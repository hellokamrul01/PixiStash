using System.Reflection;
using Autofac;
using OKR.DataAccess;
using PixiStash.DataAccess.IRepositories;
using PixiStash.DataAccess.Persistence;
using PixiStash.DataAccess.Repositories;

namespace PixiStash.DataAccess
{
    public class DataAccessModule : Autofac.Module
    {
        public DataAccessModule()
        {

        }

        protected override void Load(ContainerBuilder builder)
        {

            //builder.RegisterType<>().As<ICompanyService>().InstancePerLifetimeScope();
            builder.RegisterType<UserRepository>().As<IUserRepository>().InstancePerLifetimeScope();

            builder.RegisterType<AppDbContext>().As<IAppDbContext>().InstancePerLifetimeScope();
            //builder.RegisterType<CompanyRepository>().As<ICompanyRepository>().InstancePerLifetimeScope();

            builder.RegisterType<CompanyRepository>().As<ICompanyRepository>()
                   .InstancePerLifetimeScope();
            builder.RegisterType<ProductShelfRepository>().As<IProductShelfRepository>()
                  .InstancePerLifetimeScope();

            builder.RegisterType<BrachRepository>().As<IBranchRepository>()
               .InstancePerLifetimeScope();

            builder.RegisterType<ProductRepository>().As<IProductRepository>()
              .InstancePerLifetimeScope();
            builder.RegisterType<SalesRepository>().As<ISalesRepository>()
             .InstancePerLifetimeScope();

            builder.RegisterType<CustomerRepository>().As<ICustomerRepository>()
           .InstancePerLifetimeScope();

            //builder.RegisterType<EmployeeRepository>().As<IEmployeeRepository>()
            //      .InstancePerLifetimeScope();

            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>()
                 .InstancePerLifetimeScope();

            base.Load(builder);
        }
    }
}
