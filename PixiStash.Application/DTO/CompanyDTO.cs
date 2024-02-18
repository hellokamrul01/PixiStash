using PixiStash.Core.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PixiStash.Application.DTO

{
    public class CompanyDTO
    {
        public Guid? Id { get; set; }
        public string Name { get; set; }
        public string? Email { get; set; }


        public string? LegalName { get; set; }

        public string? RegistrationNumber { get; set; }

        public string? Industry { get; set; }

        public string? Type { get; set; }

        public string? Description { get; set; }

        public string? Website { get; set; }


        public string? Phone { get; set; }

        public string? Fax { get; set; }

        public string? Address { get; set; }

        public string? City { get; set; }

        public string? State { get; set; }

        public string? ZipCode { get; set; }

        public string? Country { get; set; }

        public DateTime? FoundedDate { get; set; }
        public UserDTO? user { get; set; }   
    }
}
