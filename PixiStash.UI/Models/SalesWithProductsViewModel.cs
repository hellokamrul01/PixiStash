using Newtonsoft.Json;
using PixiStash.Application.DTO;
using System.ComponentModel.DataAnnotations;

namespace PixiStash.UI.Models
{
    public class SalesWithProductsViewModel
    {
        public Guid? SalesId { get; set; }
      
        [JsonProperty("SalesNumber")]
        public string? SalesNumber { get; set; }

        public Guid? CustomerId { get; set; }

        [JsonProperty("Products")]
        public List<ProductDto> Products { get; set; }

       
        public DateTimeOffset? SalesDate { get; set; }
    }


    //public class SalesWithProductsViewModel
    //{
    //    // Sales information
    //    public Guid? SalesId { get; set; }

    //    //[Display(Name = "Sales Number")]
    //    [JsonProperty("SalesNumber")]
    //    public string? SalesNumber { get; set; }

    //    //[Display(Name = "Customer")]
    //    public Guid? CustomerId { get; set; }



    //    // Other properties...

    //    [JsonProperty("Products")]
    //    public List<ProductDto> Products { get; set; }
    //    //[Display(Name = "Sales Date")]
    //    public DateTimeOffset? SalesDate { get; set; }

    //    //[Display(Name = "Customer Ref. Number")]
    //    //public string? CustomerRefNumber { get; set; }

    //    //public int? Qty { get; set; }

    //    //public string? Remarks { get; set; }

    //    //public double? Amount { get; set; }

    //    //public double? SubTotal { get; set; }

    //    //public double? Discount { get; set; }

    //    //public double? Tax { get; set; }

    //    //public double? Total { get; set; }

    //    //// Product information
    //    //public Guid ProductId { get; set; }

    //    //[Required(ErrorMessage = "Product Name is required.")]
    //    //[Display(Name = "Product Name")]
    //    //public string? ProductName { get; set; }

    //    //public string? ProductCode { get; set; }

    //    //public string? Description { get; set; }

    //    //public string? ProductImageUrl { get; set; }

    //    //public byte[]? ProductImage { get; set; }

    //    //[Display(Name = "Default Buying Price")]
    //    //public double? DefaultBuyingPrice { get; set; }

    //    //[Display(Name = "Default Selling Price")]
    //    //public double DefaultSellingPrice { get; set; }

    //    //public int? ProductQuantity { get; set; }

    //    //// Company and Branch information
    //    //public Guid? CompanyId { get; set; }

    //    //public Guid? BranchId { get; set; }

    //    //public Guid? UserId { get; set; }

    //    //// Other properties or methods as needed

    //}
}
