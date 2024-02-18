using System.ComponentModel.DataAnnotations;

namespace PixiStash.Core.Models
{
    public class PaymentType
    {
        public Guid PaymentTypeId { get; set; }
        [Required]
        public string PaymentTypeName { get; set; }
        public string Description { get; set; }

        public Guid CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
