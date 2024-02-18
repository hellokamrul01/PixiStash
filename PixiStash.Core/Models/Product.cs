using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixiStash.Core.Models
{
    public class Product
    {
        public Guid ProductId { get; set; }
        [Required]
        public string ProductName { get; set; }
        public string? ProductCode { get; set; }
        public string? Barcode { get; set; }
        public byte[]? QrCode { get; set; }
        public string? Description { get; set; }
        public string? ProductImageUrl { get; set; }
        public byte[]? ProductImage { get; set; }
        // [Display(Name = "UOM")]
        //public Guid UnitOfMeasureId { get; set; }
        public double DefaultBuyingPrice { get; set; } = 0.0;
        public double DefaultSellingPrice { get; set; } = 0.0;
        [Display(Name = "Branch")]
        public bool? IsOutOfStock { get; set; }
        public bool? status { get; set; }
        public bool? IsDiscontinued { get; set; }
        public bool? IsDelete { get; set; }
        public Guid BranchId { get; set; }
        public Branch Branch { get; set; }
        // [Display(Name = "Currency")]
        // public Guid? CurrencyId { get; set; }
        public int Quantity { get; set; }
        public Guid CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
