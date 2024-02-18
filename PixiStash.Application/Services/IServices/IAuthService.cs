using PixiStash.Application.DTO.Auth;
using PixiStash.Application.DTO.Auth.RegistrationRequestDto;

namespace PixiStash.Application.Service.IService
{
    public interface IAuthService
    {
        Task<string> Register(RegistrationRequestDto registrationRequestDto);
        Task<LoginResponseDto> Login(LoginRequestDto loginRequestDto);
        Task<bool> AssignRole(string email, string roleName);
    }
}
