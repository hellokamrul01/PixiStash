using PixiStash.Application.DTO;
using PixiStash.Application.DTO.ProductShelfDTO;
using PixiStash.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixiStash.Application.Services.IServices
{
    public interface IProductShelfService
    {
        void CreateShelf(ProductShelfDto dto);
        //void Create( companyDTO);
        void DeleteShelf(Guid id);
        Task<ProductShelfDto> GetShelf(Guid id);
        ProductShelfDto GetShelfs(Guid id);
        IEnumerable<ProductShelfDto> GetShelfs();
        Task<IEnumerable<ProductShelfDto>> GetByBranchId(Guid bid);
        Task<ProductShelf> GetByProductId(Guid pid);
        void UpdateShelf(ProductShelfDto model);

    }
}
