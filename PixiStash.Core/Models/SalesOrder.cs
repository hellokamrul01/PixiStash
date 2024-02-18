using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PixiStash.Core.Models
{
    public class SalesOrder
    {
        [Key]
        public int Id { get; set; } 

        [Display(Name = "Order Number")]
        public string OrderNumber { get; set; }
        [Display(Name = "Customer")]
        public Guid? CustomerId { get; set; }
        public string ProductName { get; set; }
        public double ProductRate { get; set; } 
        public DateTimeOffset SelesDate { get; set; }
        public DateTimeOffset? DeliveryDate { get; set; }

        [Display(Name = "Customer Ref. Number")]
        public string? CustomerRefNumber { get; set; }
        [Display(Name = "Sales Type")]
        public string? Remarks { get; set; }
        public double? Amount { get; set; }
        public double? SubTotal { get; set; }
        public double? Discount { get; set; }
        public double? Tax { get; set; }
        public double? Freight { get; set; }
        public double? TotalAmount { get; set; }

        public Guid? CompanyId { get; set; }
        public Guid ProductId { get; set; } 
        public Product Product { get; set; }    
        public Guid UserId { get; set; }    
        public Company Company { get; set; }
        public Guid? BranchId { get; set; }
        public Branch Branch { get; set; }
    }
}
