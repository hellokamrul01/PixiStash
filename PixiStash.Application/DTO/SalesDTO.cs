using PixiStash.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixiStash.Application.DTO
{
    public class SalesDTO
    {
        public Guid? Id { get; set; }
        [Display(Name = "sales Number")]
        public string SalesNumber { get; set; }

        [Display(Name = "Customer")]
        public Guid? CustomerId { get; set; }
        public DateTimeOffset SalesDate { get; set; }

        [Display(Name = "Customer Ref. Number")]
        public string? CustomerRefNumber { get; set; }
        public int Qty { get; set; }
        public string? Remarks { get; set; }
        public double Amount { get; set; }
        public double SubTotal { get; set; }
        public double? Discount { get; set; }
        public double? Tax { get; set; }
        public double? Total { get; set; }
        public Guid ProductId { get; set; }     
        public Guid CompanyId { get; set; }       
        public Guid BranchId { get; set; }      
        public Guid UserId { get; set; }

    }
}
