using PixiStash.Application.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixiStash.Application.Services.IServices
{
    public interface IProductService
    {
        void CreateProduct(ProductDto model);
        void DeleteProduct(Guid id);
        ProductDto GetProject(Guid id);
        Task<IEnumerable<ProductDto>> GetProducts(Guid companyId);
        IEnumerable<ProductDto> GetProductList(Guid ComId);
        void UpdateProduct(ProductDto model);
    }
}
