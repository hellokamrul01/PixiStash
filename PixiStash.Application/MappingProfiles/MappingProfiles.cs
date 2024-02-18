using AutoMapper;
using PixiStash.Application.DTO;
using PixiStash.Application.DTO.BranchDTO;
using PixiStash.Application.DTO.CreateCompanyDTO;
using PixiStash.Application.DTO.ProductShelfDTO;
using PixiStash.Core.Models;




namespace OKR.Application.MappingProfiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
           

            CreateMap<CompanyDTO, Company>().ReverseMap();
            CreateMap<CustomerDTO, Customer>().ReverseMap();
            CreateMap<Customer, CustomerDTO>().ReverseMap();
            //CreateMap<Company, CompanyDTO>();
         

             #region Kamrul
           
            CreateMap<UserDTO, User>().ReverseMap(); 
            CreateMap<User, UserDTO>().ReverseMap(); 
            CreateMap<ProductDto, PixiStash.Core.Models.Product>().ReverseMap(); 

            CreateMap<BranchDto, Branch>().ReverseMap();
            CreateMap<Branch, BranchDto>().ReverseMap();
            CreateMap<ProductShelf, ProductShelfDto>().ReverseMap();
            CreateMap<ProductShelfDto, ProductShelf>().ReverseMap();
            CreateMap<SalesDTO, Sales>().ReverseMap();

            CreateMap<UserDTO, User>();
            CreateMap<User, UserDTO>();


            CreateMap<User, User>();
           
            CreateMap<CreateCompanyDTO, Company>().ReverseMap();


















































            #endregion Kamrul


        }
    }
}
