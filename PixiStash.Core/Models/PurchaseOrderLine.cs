using System.ComponentModel.DataAnnotations;

namespace PixiStash.Core.Models
{
    public class PurchaseOrderLine
    {
        public Guid PurchaseOrderLineId { get; set; }
        [Display(Name = "Purchase Order")]
        public Guid PurchaseOrderId { get; set; }
        [Display(Name = "Purchase Order")]
        public PurchaseOrder PurchaseOrder { get; set; }
        [Display(Name = "Product Item")]
        public Guid ProductId { get; set; }
        public string Description { get; set; }
        public double Quantity { get; set; }
        public double Price { get; set; }
        public double Amount { get; set; }
        [Display(Name = "Disc %")]
        public double DiscountPercentage { get; set; }
        public double DiscountAmount { get; set; }
        public double SubTotal { get; set; }
        [Display(Name = "Tax %")]
        public double TaxPercentage { get; set; }
        public double TaxAmount { get; set; }
        public double Total { get; set; }

        public Guid CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
