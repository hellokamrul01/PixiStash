using AutoMapper;
using PixiStash.Application.DTO;
using PixiStash.Application.Services.IServices;
using PixiStash.Core.Models;
using PixiStash.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixiStash.Application.Services
{
    internal class CustomerService : ICustomerService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CustomerService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public void CreateCustomer(CustomerDTO model)
        {
          
            try
            {
                var data = _mapper.Map<Customer>(model);
                _unitOfWork.Customers.Add(data);
                _unitOfWork.save();
            }
            catch (Exception ex) 
            {
                //return ex.Message("kjkk");
            }
        }

        public void DeleteCustomer(Guid id)
        {
            throw new NotImplementedException();
        }

        public CustomerDTO GetCustomer(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CustomerDTO> GetCustomerList(Guid ComId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<CustomerDTO>> GetCustomers(Guid companyId)
        {
            var productsFromDatabase = await _unitOfWork.Customers
                .Where(p => p.CompanyId == companyId);

            var productDtos = _mapper.Map<List<CustomerDTO>>(productsFromDatabase);

            return productDtos;
        }

        public void UpdateProduct(CustomerDTO model)
        {
            throw new NotImplementedException();
        }

        #region Comments Code
        //public void CreateProduct(ProductDto model)
        //{
        //    var data = _mapper.Map<PixiStash.Core.Models.Product>(model);
        //    _unitOfWork.Products.Add(data);
        //    _unitOfWork.save();
        //}

        //public void DeleteCustomer(Guid id)
        //{
        //    throw new NotImplementedException();
        //}

        //public void DeleteProduct(Guid id)
        //{
        //    throw new NotImplementedException();
        //}

        //public CustomerDTO GetCustomer(Guid id)
        //{
        //    throw new NotImplementedException();
        //}

        //public IEnumerable<CustomerDTO> GetCustomerList(Guid ComId)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<IEnumerable<CustomerDTO>> GetCustomers(Guid companyId)
        //{
        //    throw new NotImplementedException();
        //}

        //public IEnumerable<ProductDto> GetProductList(Guid ComId)
        //{
        //    throw new NotImplementedException();
        //}

        //public async Task<IEnumerable<ProductDto>> GetProducts(Guid ComId)
        //{
        //    var productsFromDatabase = await _unitOfWork.Products
        //        .Where(p => p.CompanyId == ComId);

        //    var productDtos = _mapper.Map<List<ProductDto>>(productsFromDatabase);

        //    return productDtos;
        //}


        //public async IEnumerable<ProductDto> GetProducts(Guid ComId)
        //{

        //    var productsFromDatabase = await _unitOfWork.Products
        //   .Where(p => p.CompanyId == ComId);

        //    var productDtos = _mapper.Map<List<ProductDto>>(productsFromDatabase);

        //    return productDtos;
        //}

        //public ProductDto GetProject(Guid id)
        //{
        //    throw new NotImplementedException();
        //}

        //public void UpdateProduct(ProductDto model)
        //{
        //    throw new NotImplementedException();
        //}

        //public void UpdateProduct(CustomerDTO model)
        //{
        //    throw new NotImplementedException();
        //}

        //Task<IEnumerable<ProductDto>> IProductService.GetProducts(Guid ComId)
        //{
        //    throw new NotImplementedException();
        //}
        #endregion
    }
}
