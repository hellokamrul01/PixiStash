using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PixiStash.Core.Models
{
    public class Company
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string? LegalName { get; set; }

        [RegularExpression(@"^\d{9}$", ErrorMessage = "Registration number must be exactly 9 digits.")]
        public string? RegistrationNumber { get; set; }

        public string? Industry { get; set; }

        public string? Type { get; set; }

        public string? Description { get; set; }

        [RegularExpression(@"^(http|https)://[a-zA-Z0-9\.-]+\.[a-zA-Z]{2,4}/?$", ErrorMessage = "Invalid website URL.")]
        public string? Website { get; set; }

        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }

        [RegularExpression(@"^\+?[0-9]{1,15}$", ErrorMessage = "Invalid phone number.")]
        public string? Phone { get; set; }

        [RegularExpression(@"^\+?[0-9]{1,15}$", ErrorMessage = "Invalid fax number.")]
        public string? Fax { get; set; }

        public string? Address { get; set; }

        public string? City { get; set; }

        public string? State { get; set; }

        [RegularExpression(@"^\d{5}$", ErrorMessage = "Zip code must be exactly 5 digits.")]
        public string? ZipCode { get; set; }

        public string? Country { get; set; }

        public DateTime? FoundedDate { get; set; }

        public bool IsActive { get; set; } = true;

        public List<Product> Products { get; set; }
        public List<User> Users { get; set; }
        public List<Vendor> Vendors { get; set; }
        public List<ProductType> ProductTypes { get; set; }
        public List<ProductShelf> ProductShelves { get; set; }
        public List<Customer> Customers { get; set; }
        public List<Branch> Branches { get; set; }
        public List<SalesOrder> SalesOrders { get; set; }
        public List<Sales> Sales { get; set; }
        public List<PurchaseOrder> PurchaseOrders { get; set; }

        // public List<Model> Models { get; set; }
    }

}
