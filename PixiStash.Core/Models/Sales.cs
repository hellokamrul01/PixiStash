using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PixiStash.Core.Models
{
    public class Sales
    {
        public Guid Id { get; set; }
        [Display(Name = "sales Number")]
        public string SalesNumber { get; set; }

        [Display(Name = "Customer")]
        public Guid? CustomerId { get; set; }
        public DateTimeOffset SalesDate { get; set; }

        [Display(Name = "Customer Ref. Number")]
        public string? CustomerRefNumber { get; set; }
        public int Qty { get; set; }
        public string? Remarks { get; set; }
        public double Rate { get; set; }
        public double? Discount { get; set; }
        [Display(Name = "Disc %")]
        public double? DiscountPercentage { get; set; }
        public double? DiscountAmount { get; set; }
        public double? SubTotal { get; set; }
        [Display(Name = "Tax %")]
        public double? TaxPercentage { get; set; }
        public double? TaxAmount { get; set; }
        public double? TotalAmount { get; set; }
        public bool? IsPaid { get; set; }
        public bool? IsDelete { get; set; }

        public Guid ProductId { get; set; }
        public Product Product { get; set; }
        public Guid CompanyId { get; set; }
        public Company Company { get; set; }
        public Guid BranchId { get; set; }
        public Branch Branch { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
    }
}
