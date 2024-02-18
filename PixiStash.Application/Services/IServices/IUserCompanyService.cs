using PixiStash.Application.DTO.Auth;

namespace PixelPath.LoRe.Service.IService
{
    public interface IUserCompanyService
    {
        void CreateUser(UserDto userDTO);
        void Create(EmployeeDTO userDTO);
        void DeleteUser(Guid id);
        UserDto GetUser(Guid id);
        List<UserDto> GetGetUsers();
        List<UserDto> GetUserByComId(Guid UserId);
        void UpdateUser(UserDto userDTO);
    }
}
