using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixiStash.Core.Models
{
    public class Branch
    {
        public Guid BranchId { get; set; }
        [Required]
        public string BranchName { get; set; }
        public string? Description { get; set; }
        //[Display(Name = "Currency")]
        //public int CurrencyId { get; set; }
       // [Display(Name = "Street Address")]
        public string Address { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        [Display(Name = "Zip Code")]
        public string? ZipCode { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        [Display(Name = "Contact Person")]
        public string? ContactPerson { get; set; }

        [ForeignKey("Company")] // Specify the foreign key relationship
        public Guid CompanyId { get; set; }

        public Company Company { get; set; }

        public List<Product> Products { get; set; } 
        public List<SalesOrder> SalesOrders { get; set; } 
        public List<PurchaseOrder> PurchaseOrders { get; set; }
        public List<User> Users { get; set; }
        public List<ProductShelf> ProductShelves { get; set; } 

    }
}

