using System.ComponentModel.DataAnnotations;

namespace PixiStash.Core.Models
{
    public class Vendor
    {
        public Guid VendorId { get; set; }
        [Required]
        public string VendorName { get; set; }
       // [Display(Name = "Vendor Type")]
       // public Guid VendorTypeId { get; set; }
        [Display(Name = "Street Address")]
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        [Display(Name = "Zip Code")]
        public string? ZipCode { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        [Display(Name = "Contact Person")]
        public string? ContactPerson { get; set; }

        public Guid CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
