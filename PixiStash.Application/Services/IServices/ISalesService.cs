using PixiStash.Application.DTO;
using PixiStash.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixiStash.Application.Services.IServices
{
    public interface ISalesService
    {
        void Create(SalesDTO model);
        void Delete(Guid id);
        SalesDTO GetSales(Guid id);
        Task<IEnumerable<Sales>> GetSalesListByBranch(Guid branchId);
        IEnumerable<Sales> GetSalesListByCompany(Guid ComId);
        List<SalesDTO> GetSalesListByUser(Guid UserId);
        void UpdateProduct(SalesDTO model);
    }
}
