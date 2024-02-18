using PixiStash.DataAccess.IRepositories;

namespace PixiStash.DataAccess
{
    public interface IUnitOfWork : IDisposable
    {
      
        ICompanyRepository Companies { get; }
        ICustomerRepository Customers { get; }
       
     
        // ITemplateRepository Template { get; }

        #region Kamrul

        IBranchRepository Branches { get; } 
        
        IUserRepository Users { get; }
        
       // IUserCompany UserComapany { get; }       
       
       IProductShelfRepository ProductShelf { get; }    
       
       IProductRepository Products { get; } 
       ISalesRepository Sales { get; }

        #endregion Kamrul
        void save();
    }
}
