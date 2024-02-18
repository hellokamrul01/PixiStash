using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixiStash.Core.Models
{
    public class User
    {
        public Guid Id { get; set; }

        public string UserName { get; set; }

        public string FirstName { get; set; }

        public string? LastName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public string? PhoneNumber { get; set; }

        public bool IsActive { get; set; }

        // Navigation property for Company
      //  public Company? Comid { get; set; }
        public Guid BranchId { get; set; }

        //public Branch Branch { get; set; }
        public Guid? CompanyId { get; set; }
       // public List<Sales> Sales { get; set; }  
    }

}
