using AutoMapper;
using PixiStash.Application.DTO.ProductShelfDTO;
using PixiStash.Application.Services.IServices;
using PixiStash.Core.Models;
using PixiStash.DataAccess;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixiStash.Application.Services
{
    internal class ProductShelfService : IProductShelfService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public ProductShelfService(IMapper mapper, IUnitOfWork unitOfWork) 
        { 
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }    
        public void CreateShelf(ProductShelfDto dto)
        {
          var data =  _mapper.Map<ProductShelf>(dto); 
            _unitOfWork.ProductShelf.Add(data);
            _unitOfWork.save();
        }

        public void DeleteShelf(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ProductShelfDto>> GetByBranchId(Guid bid)
        {
            var data = await _unitOfWork.Branches
                .Where(x => x.BranchId == bid);

            var model = _mapper.Map<IEnumerable<ProductShelfDto>>(data);
            return model;
        }


        //public async IEnumerable<ProductShelfDto> GetByBranchId(Guid bid)
        //{
        //    var data = await _unitOfWork.Branches
        //       .Where(x => x.BranchId == bid); // Assuming _unitOfWork.Branches is an IQueryable, you may need to use ToListAsync() to execute the query asynchronously.

        //    var model = _mapper.Map<IEnumerable<ProductShelfDto>>(data);
        //    return model;
        //}

        //public async Task<IEnumerable<ProductShelfDto>> GetByBranchId(Guid bid)
        //{
        //    var data = await _unitOfWork.Branches
        //        .Where(x => x.BranchId == bid)
        //        .ToListAsync(); // Assuming _unitOfWork.Branches is an IQueryable, you may need to use ToListAsync() to execute the query asynchronously.

        //    var model = _mapper.Map<IEnumerable<ProductShelfDto>>(data);
        //    return model;
        //}

        public Task<ProductShelf> GetByProductId(Guid pid)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductShelfDto> GetShelfs()
        {
            var data = _unitOfWork.ProductShelf.GetAll();
            var list = _mapper.Map<IList<ProductShelfDto>>(data);
            return list;
            
        }

        public async Task<ProductShelfDto> GetShelf(Guid id)
        {
          var data = await  _unitOfWork.ProductShelf.GetByIdAsync(id);
           var dto = _mapper.Map<ProductShelfDto>(data);
            return dto; 
        }

        public ProductShelfDto GetShelfs(Guid id)
        {
            throw new NotImplementedException();
        }

        public void UpdateShelf(ProductShelfDto model)
        {
            throw new NotImplementedException();
        }
    }
}
