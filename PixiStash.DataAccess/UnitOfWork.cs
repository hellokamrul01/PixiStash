using Microsoft.EntityFrameworkCore;
using PixiStash.DataAccess;
using PixiStash.DataAccess.IRepositories;
using PixiStash.DataAccess.Persistence;

namespace OKR.DataAccess
{
    public class UnitOfWork : IUnitOfWork
    {
        protected readonly DbContext _DbContext;

        #region Repositories
       
        public ICompanyRepository Companies { get; private set; }
        public IUserRepository Users { get; private set; }

        public IBranchRepository Branches { get; private set; }
        public IProductShelfRepository ProductShelf { get; private set; }
        public IProductRepository Products { get; private set; }    
        public ISalesRepository Sales { get; private set; }
        public ICustomerRepository Customers { get; private set; }

        //public IUserRepository Users => throw new NotImplementedException();




        #region Kamrul


        //public IUserRepository Users { get; private set; }

        //public IUserCompany UserComapany { get; private set; }      



        #endregion Kamrul

        #endregion

        public UnitOfWork(IAppDbContext context, 
            
            ICompanyRepository companyRepository,
            IBranchRepository branchRepository,
            IProductShelfRepository productShelfRepository,
            IProductRepository productRepository,
            ISalesRepository salesRepository,
            IUserRepository userRepository,
            ICustomerRepository customerRepository

            

        #region Kamrul
          
           // IUserCompany userCompany,
            

        #endregion Kamrul


            )
        {
            _DbContext = (DbContext)context;

           
            Companies = companyRepository;
            Branches = branchRepository;
           
            ProductShelf = productShelfRepository;  
            Products = productRepository;   
            Sales = salesRepository;    
            Users = userRepository; 
            Customers = customerRepository; 

            #region Kamrul

           // Users = UserRepository;
           
           // UserComapany = userCompany;
              

            #endregion Kamrul
        }
        public virtual void Dispose() => _DbContext?.Dispose();

        public virtual void save() => _DbContext?.SaveChanges();

    }
}
