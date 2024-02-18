using AutoMapper;
using PixiStash.Application.DTO;
using PixiStash.Application.DTO.CreateCompanyDTO;
using PixiStash.Application.IServices;
using PixiStash.Core.Models;
using PixiStash.DataAccess;

namespace PixiStash.Application.Services
{
    public class CompanyService : ICompanyService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CompanyService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public void CreateCompany(CompanyDTO companyDTO)
        {
            //Guid UserId = Guid.NewGuid();
            var company = _mapper.Map<Company>(companyDTO);
            //List<UserCompany> userCompanies = new List<UserCompany>();
            //UserCompany userCompany = new UserCompany();

           // userCompany.User = _mapper.Map<User>(companyDTO.User);
            //userCompany.User.Id = UserId;
            // userCompany.Role = CompanyRole.SuperAdmin;
            //userCompany.UserId = UserId;

        //    userCompanies.Add(userCompany);

            //company.Users = userCompanies;

            _unitOfWork.Companies.Add(company);
            _unitOfWork.save();
        }



        public void Create(CreateCompanyDTO data)
        {

            var company = _mapper.Map<Company>(data);

            _unitOfWork.Companies.Add(company);
            _unitOfWork.save();
        }


        public void DeleteCompany(Guid id)
        {
            _unitOfWork.Companies.Remove(id);
            _unitOfWork.save();
        }

        public List<CompanyDTO> GetCompanies()
        {
            var companies = _unitOfWork.Companies.GetAll();

            var companiesDTO = _mapper.Map<List<CompanyDTO>>(companies);

            return companiesDTO;
        }
        public List<CompanyDTO> GetByUserId(Guid UserId)
        {
            var userCompanies = _unitOfWork.Companies.GetByUserId(UserId);

            var companiesDTO = _mapper.Map<List<CompanyDTO>>(userCompanies);

            return companiesDTO;
        }

        public CompanyDTO GetCompany(Guid id)
        {
            var company = _unitOfWork.Companies.GetById(id);
            var companyDTO = _mapper.Map<CompanyDTO>(company);
            return companyDTO;
        }

        public void UpdateCompany(CompanyDTO companyDTO)
        {
            var company = _mapper.Map<Company>(companyDTO);

            _unitOfWork.Companies.Edit(company);
            _unitOfWork.save();
        }

        public CompanyDTO GetCompanyByUserId(Guid Uid)
        {
            //var user =  _unitOfWork.Users.GetDynamicAsync(filter: u => u.Id == Uid, isTrackingOff: true);

            //if (user != null)
            //{
            //    var company =  _unitOfWork.Companies.GetDynamicAsync(filter: c => c.Id == user.CompanyId);

            //    return company != null ? _mapper.Map<CompanyDTO>(company.FirstOrDefault()) : null;
            //}

            //return null;

            //var user = _unitOfWork.Users.FindWhere(s => s.Id == Uid);

            //if (user != null)
            //{
            //    var company = _unitOfWork.Companies.FindWhere(x => x.Id == user.CompanyId);

            //    if (company != null)
            //    {

            //        return _mapper.Map<CompanyDTO>(company);
            //    }
            //}

            //return null;


            var user = _unitOfWork.Users.FindWhere(s => s.Id == Uid);
            var company = user?.CompanyId != null
                ? _unitOfWork.Companies.FindWhere(x => x.Id == user.CompanyId)
                : null;
            UserDTO user1 = _mapper.Map<UserDTO>(user);
            //company.Users = user1;
            CompanyDTO data = _mapper.Map<CompanyDTO>(company);
            data.user = user1;
            return data ?? null;
        }
    }
}
