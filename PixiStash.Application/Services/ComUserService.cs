using AutoMapper;
using PixiStash.Application.DTO;
using PixiStash.Application.Services.IServices;
using PixiStash.DataAccess;

namespace PixiStash.Application.Services
{
    public class ComUserService : IComUserService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ComUserService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public List<CompanyDTO> GetComByUser()
        {
            throw new NotImplementedException();
        }
        //public CompanyDTO GetComByUser(ComUserDTO comUserDTO)
        //{
        //    if(comUserDTO.ComId == null)
        //    {
        //        var companay = _unitOfWork.Companies.GetByUserIdRole(comUserDTO.UserId.Value);
        //        var companyDTO = _mapper.Map<CompanyDTO>(companay);

        //        return companyDTO;
        //    }
        //    else
        //    {

        //    }
        //}



    }
}
