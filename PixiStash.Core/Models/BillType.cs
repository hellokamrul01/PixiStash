using System.ComponentModel.DataAnnotations;

namespace PixiStash.Core.Models
{
    public class BillType
    {
        public Guid BillTypeId { get; set; }
        [Required]
        public string BillTypeName { get; set; }
        public string Description { get; set; }
        public Guid CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
