using System.ComponentModel.DataAnnotations;

namespace PixiStash.Core.Models
{
    public class SalesType
    {
        public Guid SalesTypeId { get; set; }
        [Required]
        public string SalesTypeName { get; set; }
        public string Description { get; set; }

        public Guid CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
