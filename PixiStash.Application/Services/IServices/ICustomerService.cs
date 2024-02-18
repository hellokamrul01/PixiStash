using PixiStash.Application.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixiStash.Application.Services.IServices
{
    public interface ICustomerService
    {
        void CreateCustomer(CustomerDTO model);
        void DeleteCustomer(Guid id);
        CustomerDTO GetCustomer(Guid id);
        Task<IEnumerable<CustomerDTO>> GetCustomers(Guid companyId);
        IEnumerable<CustomerDTO> GetCustomerList(Guid ComId);
        void UpdateProduct(CustomerDTO model);
    }
}
