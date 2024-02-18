using System.ComponentModel.DataAnnotations;

namespace PixiStash.Core.Models
{
    public class ShipmentType
    {
        public Guid ShipmentTypeId { get; set; }
        [Required]
        public string ShipmentTypeName { get; set; }
        public string Description { get; set; }

        public Guid CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
