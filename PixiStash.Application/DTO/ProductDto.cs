using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixiStash.Application.DTO
{
    public class ProductDto
    {
        public Guid? ProductId { get; set; }
        public DateTime? ServiceDate { get; set; }  
        [Required]
        public string ProductName { get; set; }
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
        public Guid? CompanyId { get; set; }
    }
}
