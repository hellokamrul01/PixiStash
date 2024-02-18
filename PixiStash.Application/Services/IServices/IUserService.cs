using PixiStash.Application.DTO;

namespace PixiStash.Application.Services.IServices
{
    public interface IUserService
    {
        void CreateUser(UserDTO userDTO);
       // void ChangeID(ChangeID Change);
        void DeleteUser(Guid id);
        UserDTO GetUser(Guid id);
       // CompanyRole GetRole(Guid id);
        List<UserDTO> GetUsers(Guid ComId);
      //  List<PeopleDTO> GetPeople(Guid ComId);
        List<UserDTO> GetAssignees(Guid ProjectId);
        List<UserDTO> GetTaskAssignees(Guid TaskId);
        void UpdateUser(UserDTO userDTO);
        Guid GetComid(Guid id);
    }
}
