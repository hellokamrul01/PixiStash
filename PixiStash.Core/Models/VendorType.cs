using System.ComponentModel.DataAnnotations;

namespace PixiStash.Core.Models
{
    public class VendorType
    {
        public Guid VendorTypeId { get; set; }
        [Required]
        public string VendorTypeName { get; set; }
        public string Description { get; set; }

        public Guid CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
