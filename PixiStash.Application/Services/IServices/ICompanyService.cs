using PixiStash.Application.DTO;
using PixiStash.Application.DTO.CreateCompanyDTO;

namespace PixiStash.Application.IServices
{
    public interface ICompanyService
    {
        void CreateCompany(CompanyDTO companyDTO);
        void Create(CreateCompanyDTO companyDTO);
        void DeleteCompany(Guid id);
        CompanyDTO GetCompany(Guid id);
        List<CompanyDTO> GetCompanies();
        List<CompanyDTO> GetByUserId(Guid UserId);
        void UpdateCompany(CompanyDTO companyDTO);
        CompanyDTO GetCompanyByUserId(Guid Uid);

    }
}
