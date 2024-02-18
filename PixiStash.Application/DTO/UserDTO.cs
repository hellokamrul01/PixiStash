using PixiStash.Core.Enums;
using PixiStash.Core.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PixiStash.Application.DTO
{
    public class UserDTO
    {
        public Guid? Id { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string? LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? PhoneNumber { get; set; }
        public bool IsActive { get; set; }
        public Guid BranchId { get; set; }
        public Guid? CompanyId { get; set; }
       

    }
}
