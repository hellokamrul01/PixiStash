using System.ComponentModel.DataAnnotations;

namespace PixiStash.Core.Models
{
    public class ProductType
    {
        public Guid ProductTypeId { get; set; }
        [Required]
        public string ProductTypeName { get; set; }
        public string? Description { get; set; }

        public Guid CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
