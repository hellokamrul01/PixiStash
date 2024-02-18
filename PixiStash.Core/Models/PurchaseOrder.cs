using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PixiStash.Core.Models
{
    public class PurchaseOrder
    {
        public Guid PurchaseOrderId { get; set; }
        [Display(Name = "Order Number")]
        public string PurchaseOrderName { get; set; }
        //[Display(Name = "Branch")]
        //public Guid BranchId { get; set; }
        [Display(Name = "Vendor")]
        public Guid VendorId { get; set; }
        public DateTimeOffset OrderDate { get; set; }
        public DateTimeOffset DeliveryDate { get; set; }
        public string ProductName { get; set; } 
        public double Quantity { get; set; }   
        public string? Unit { get; set; }   

        //[Display(Name = "Currency")]
        //public Guid CurrencyId { get; set; }

        //[Display(Name = "Purchase Type")]
        //public Guid? PurchaseTypeId { get; set; }
        public string? Remarks { get; set; }
        public double Amount { get; set; }
        public double SubTotal { get; set; }
        public double Discount { get; set; }
        public double Tax { get; set; }
        public double? Freight { get; set; }
        public double Total { get; set; }
        public string? status { get; set; }  
        public Guid? Comid { get; set; }
        //public Company Company { get; set; }

        public Guid BranchId { get; set; }
        public Branch Branch { get; set; }
       // public List<PurchaseOrderLine> PurchaseOrderLines { get; set; } = new List<PurchaseOrderLine>();


    }
}
