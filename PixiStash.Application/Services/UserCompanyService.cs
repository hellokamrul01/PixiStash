using Microsoft.AspNetCore.Identity;
using PixelPath.LoRe.Service.IService;
using PixiStash.Application.DTO.Auth;
using PixiStash.Application.DTO.Auth.RegistrationRequestDto;
using PixiStash.Application.Service.IService;
using PixiStash.Core.Models.ApplicationUser;
using PixiStash.DataAccess;
using PixiStash.DataAccess.Persistence;

namespace PixelPath.LoRe.Service
{
    public class UserCompanyService : IUserCompanyService
    {
        private readonly AppDbContext _db;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        //private readonly IJwtTokenGenerator _jwtTokenGenerator;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAuthService _authService;
        public UserCompanyService(AppDbContext db,
            UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager,
            IUnitOfWork unitOfWork,
            IAuthService authService


            )
        {

            _db = db;
           // _jwtTokenGenerator = jwtTokenGenerator;
            _userManager = userManager;
            _roleManager = roleManager;
            _unitOfWork = unitOfWork;   
            _authService = authService; 

        }

        

        public  async void Create(EmployeeDTO userDTO)
        {
            RegistrationRequestDto registrationRequestDto = new RegistrationRequestDto()
            { 
                Email = userDTO.Email,
                PhoneNumber = userDTO.PhoneNumber,  
                Name = userDTO.EmpName,    
                Password = userDTO.Password,
                Role = userDTO.Role   

            
            };
            string data = await _authService.Register(registrationRequestDto);
            //if(data == "Successed")
            //{
            //    var userToReturn = _db.ApplicationUsers.First(u => u.UserName == registrationRequestDto.Email);
            //    Employee register = new Employee
            //    {
            //        EmployeeId = Guid.Parse(userToReturn.Id),
            //        CompanyId = userDTO.CompanyId,
            //        EmpName = userDTO.EmpName,
            //        Email = userDTO.Email,

            //    };
            //    _unitOfWork.Employees.Add(register);
            //    _unitOfWork.save();
            //}

           
            
        }

        public void CreateUser(UserDto userDTO)
        {
            throw new NotImplementedException();
        }

        public void DeleteUser(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<UserDto> GetGetUsers()
        {
            throw new NotImplementedException();
        }

        public UserDto GetUser(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<UserDto> GetUserByComId(Guid UserId)
        {
            throw new NotImplementedException();
        }

        public void UpdateUser(UserDto userDTO)
        {
            throw new NotImplementedException();
        }
    }
}
