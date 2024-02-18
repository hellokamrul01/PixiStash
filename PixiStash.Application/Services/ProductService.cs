using AutoMapper;
using PixiStash.Application.DTO;
using PixiStash.Application.Services.IServices;
using PixiStash.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixiStash.Application.Services
{
    internal class ProductService : IProductService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ProductService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public void CreateProduct(ProductDto model)
        {
            var data = _mapper.Map<PixiStash.Core.Models.Product>(model);
            _unitOfWork.Products.Add(data);
            _unitOfWork.save(); 
        }

        public void DeleteProduct(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductDto> GetProductList(Guid ComId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ProductDto>> GetProducts(Guid ComId)
        {
            var productsFromDatabase = await _unitOfWork.Products
                .Where(p => p.CompanyId == ComId);

            var productDtos = _mapper.Map<List<ProductDto>>(productsFromDatabase);

            return productDtos;
        }


        //public async IEnumerable<ProductDto> GetProducts(Guid ComId)
        //{

        //    var productsFromDatabase = await _unitOfWork.Products
        //   .Where(p => p.CompanyId == ComId);

        //    var productDtos = _mapper.Map<List<ProductDto>>(productsFromDatabase);

        //    return productDtos;
        //}

        public ProductDto GetProject(Guid id)
        {
            throw new NotImplementedException();
        }

        public void UpdateProduct(ProductDto model)
        {
            throw new NotImplementedException();
        }

        //Task<IEnumerable<ProductDto>> IProductService.GetProducts(Guid ComId)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
