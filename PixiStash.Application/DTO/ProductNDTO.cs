using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixiStash.Application.DTO
{
    public class ProductNDTO
    {
        public Guid? Id { get; set; }
        public DateTime? ServiceDate { get; set; }
        [Required]
        public string Name { get; set; }
        public string? ProductCode { get; set; }
        public string? Description { get; set; }
        public string? ProductImageUrl { get; set; }
        public byte[]? ProductImage { get; set; }
        public double? DefaultBuyingPrice { get; set; } = 0.0;
        public int? Amount { get; set; }
        public int? Tax { get; set; }
        public double DefaultSellingPrice { get; set; } = 0.0;
        public Guid? BranchId { get; set; }
        public int Quantity { get; set; }
        public int? Qty { get; set; }
        public int? Rate { get; set; }
        public Guid? CompanyId { get; set; }     
    }
}
