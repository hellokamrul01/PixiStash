using System.ComponentModel.DataAnnotations;

namespace PixiStash.Core.Models
{
    public class CustomerType
    {
        public int CustomerTypeId { get; set; }
        [Required]
        public string CustomerTypeName { get; set; }
        public string Description { get; set; }

        public Guid CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
