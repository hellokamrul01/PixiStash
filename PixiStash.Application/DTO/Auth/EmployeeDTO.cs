using System.ComponentModel.DataAnnotations.Schema;

namespace PixiStash.Application.DTO.Auth
{
    public class EmployeeDTO
    {
        public Guid EmployeeId { get; set; }
        public string? EmpName { get; set; }
        //public string? UserName { get; set; }
        public string? Email { get; set; }
        public Guid CompanyId { get; set; }      
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public string? Role { get; set; }

    }
}
