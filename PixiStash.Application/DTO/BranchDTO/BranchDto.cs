using PixiStash.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixiStash.Application.DTO.BranchDTO
{
    public class BranchDto
    {
        public Guid? BranchId { get; set; }
        [Required]
        public string BranchName { get; set; }
        public string Description { get; set; }
        public int CurrencyId { get; set; } = 0;    

        [Display(Name = "Street Address")]
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        [Display(Name = "Zip Code")]
        public string ZipCode { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        [Display(Name = "Contact Person")]
        public string ContactPerson { get; set; }
      //  public Guid ComapnyId { get; set; }
        public Guid CompanyId { get; set; }

    }
}
