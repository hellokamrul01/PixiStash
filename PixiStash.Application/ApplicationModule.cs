using Autofac;
using PixiStash.Application.IServices;
using PixiStash.Application.Service.IService;
using PixiStash.Application.Services;
using PixiStash.Application.Services.IServices;

namespace PixiStash.Application
{
    public class ApplicationModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
           // builder.RegisterType<LoginService>().As<ILoginService>().InstancePerLifetimeScope();

            builder.RegisterType<CompanyService>().As<ICompanyService>().InstancePerLifetimeScope();
            builder.RegisterType<AuthService>().As<IAuthService>().InstancePerLifetimeScope();
            builder.RegisterType<BranchService>().As<IBranchService>().InstancePerLifetimeScope();
            builder.RegisterType<ProductShelfService>().As<IProductShelfService>().InstancePerLifetimeScope();
            builder.RegisterType<ProductService>().As<IProductService>().InstancePerLifetimeScope();
            builder.RegisterType<CustomerService>().As<ICustomerService>().InstancePerLifetimeScope();

           
            #region Kamrul


           builder.RegisterType<UserService>().As<IUserService>().InstancePerLifetimeScope();
         //builder.RegisterType<EmailService>().As<IEmailService>().InstancePerLifetimeScope();
            

           
            #endregion Kamrul




            base.Load(builder);
        }
    }
}
