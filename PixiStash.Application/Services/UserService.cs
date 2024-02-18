using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PixiStash.Application.DTO;
using PixiStash.Application.Services.IServices;
using PixiStash.Core.Models;
using PixiStash.DataAccess;

namespace PixiStash.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UserService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public void CreateUser(UserDTO userDTO)
        {
           var user = _mapper.Map<User>(userDTO);
            _unitOfWork.Users.Add(user);
            _unitOfWork.save();

        }

        public void DeleteUser(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<UserDTO> GetAssignees(Guid ProjectId)
        {
            throw new NotImplementedException();
        }

        public Guid GetComid(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<UserDTO> GetTaskAssignees(Guid TaskId)
        {
            throw new NotImplementedException();
        }

        public UserDTO GetUser(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<UserDTO> GetUsers(Guid ComId)
        {
            throw new NotImplementedException();
        }

        public void UpdateUser(UserDTO userDTO)
        {
            throw new NotImplementedException();
        }
    }
}
