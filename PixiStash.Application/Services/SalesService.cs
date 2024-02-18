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
    internal class SalesService : ISalesService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public SalesService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public void Create(SalesDTO model)
        {
            try
            {
                var data = _mapper.Map<Sales>(model);
                _unitOfWork.Sales.Add(data);
                _unitOfWork.save();
            }
            catch 
            { 
                
            }

          
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public SalesDTO GetSales(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Sales>> GetSalesListByBranch(Guid branchId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Sales> GetSalesListByCompany(Guid ComId)
        {
            throw new NotImplementedException();
        }

        public List<SalesDTO> GetSalesListByUser(Guid UserId)
        {
            throw new NotImplementedException();
        }

        public void UpdateProduct(SalesDTO model)
        {
            throw new NotImplementedException();
        }
    }
}
