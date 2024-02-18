using System.ComponentModel.DataAnnotations;

namespace PixiStash.Core.Models
{
    public class PurchaseType
    {
        public Guid PurchaseTypeId { get; set; }
        [Required]
        public string PurchaseTypeName { get; set; }
        public string Description { get; set; }

        public Guid CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
