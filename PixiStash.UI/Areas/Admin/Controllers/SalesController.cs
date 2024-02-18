using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PixiStash.Application.Services.IServices;
using PixiStash.UI.Models;
using System.ComponentModel.DataAnnotations;

namespace PixiStash.UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SalesController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICustomerService _customerService; 
        public SalesController(IProductService productService, ICustomerService customerService)
        {
            _productService = productService;
            _customerService = customerService; 
        }
        public async Task<ActionResult> IndexAsync()
        {
            string companyId = HttpContext.Session.GetString("ComId");
            //string companyName = HttpContext.Session.GetString("ComName");
            // string branchId = HttpContext.Session.GetString("BName");
            var comid = Guid.Parse(companyId);
            var products = await _productService.GetProducts(comid);
            ViewBag.ProductList = products;
            return View();
        }


        public ActionResult Details(int id)
        {
            return View();
        }


        public async Task<ActionResult> Create()
        {
            string comid = HttpContext.Session.GetString("ComId");
            
            var companyId = Guid.Parse(comid);

            var data = await _customerService.GetCustomers(companyId);
            ViewBag.customerList = data.ToList();    
            var products = await _productService.GetProducts(companyId);
            ViewBag.ProductList = JsonConvert.SerializeObject(products);
            return View();          
        }


        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(IndexAsync));
            }
            catch
            {
                return View();
            }
        }


        public ActionResult Edit(int id)
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(IndexAsync));
            }
            catch
            {
                return View();
            }
        }


        public ActionResult Delete(int id)
        {
            return View();
        }

        public class ProductInfo
        {
            public Guid Id { get; set; }
            public string Name { get; set; }
            public string Desc { get; set; }
            public double Rate { get; set; }
        }

        public class ProductData
        {
            public DateTime ServiceDate { get; set; }
            public ProductInfo Products { get; set; }
            public int Quantity { get; set; }
            public double Amount { get; set; }
            public int Tax { get; set; }
        }

        public class SalesRequestModel
        {
            public string SalesNumber { get; set; }
            public Guid CustomerId { get; set; }
            public DateTime SalesDate { get; set; }
            public string CustomerName { get; set; }
            [Display(Name = "Street Address")]
            public string? Address { get; set; }
            public string? City { get; set; }
            public string? Phone { get; set; }
            public string? Email { get; set; }
            public List<ProductData> Products { get; set; }
        }

        [HttpPost]
        public IActionResult SaveSales([FromBody] SalesRequestModel model)
        {
            string companyName = HttpContext.Session.GetString("ComName");
            string branchName = HttpContext.Session.GetString("BName");

            try
            {
                var invoiceReportViewModel = new InvoiceReportViewModel
                {
                    CompanyName = companyName,
                    SalesNumber = model.SalesNumber,
                    CustomerId = model.CustomerId,
                    SalesDate = model.SalesDate,
                    CustomerName = model.CustomerName,
                    Address = model.Address,
                    City = model.City,
                    Phone = model.Phone,
                    Email = model.Email,
                    Products = model.Products
                };

               ViewBag.InvoiceData = invoiceReportViewModel;
              //  return RedirectToAction("ShowInvoiceReport", new { area = "Admin", controller = "Sales" });

                return RedirectToAction("ShowInvoiceReport", invoiceReportViewModel);
               // return Ok(new { Message = "Sales data saved successfully." });
            }
            catch (Exception ex)
            {
                // Handle exceptions and return an error response
                return StatusCode(500, new { Message = "An error occurred while saving sales data.", Error = ex.Message });
            }
        }


        public class InvoiceReportViewModel
        {
            public string CompanyName { get; set; }

            public string SalesNumber { get; set; }
            public Guid CustomerId { get; set; }
            public DateTime SalesDate { get; set; }
            public string CustomerName { get; set; }

            [Display(Name = "Street Address")]
            public string Address { get; set; }
            public string City { get; set; }
            public string Phone { get; set; }
            public string Email { get; set; }

            public List<ProductData> Products { get; set; }
        }

        [HttpGet]
        public IActionResult ShowInvoiceReport(InvoiceReportViewModel model)
        {
            // Retrieve the model data from TempData
            var invoiceReportViewModel = ViewBag.InvoiceData as InvoiceReportViewModel;

            if (invoiceReportViewModel == null)
            {
                
                return RedirectToAction("Index");
            }

            return View(invoiceReportViewModel);
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(IndexAsync));
            }
            catch
            {
                return View();
            }
        }
    }
}
