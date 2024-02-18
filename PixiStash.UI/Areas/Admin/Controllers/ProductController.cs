using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PixiStash.Application.DTO;
using PixiStash.Application.IServices;
using PixiStash.Application.Services.IServices;
using PixiStash.Core.Models;

namespace PixiStash.UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        // GET: ProductController

        public async Task<IActionResult> Index()
        {
            string companyId = HttpContext.Session.GetString("ComId");
            //string companyName = HttpContext.Session.GetString("ComName");
            // string branchId = HttpContext.Session.GetString("BName");
            var CompanyId = Guid.Parse(companyId);
            var products = await _productService.GetProducts(CompanyId);
            return View(products.ToList()); // Ensure you convert the IEnumerable to a List
        }

        //public async Task<IActionResult> Index()
        //{
        //    var companyId = Guid.Parse("CAB0E736-3C30-4A50-A200-08DBE53B4DF2");
        //    var products = await _productService.GetProducts(companyId);

        //    // Return JSON data directly
        //    return Json(products);
        //}



        // GET: ProductController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProductController/Create
        public ActionResult Create()
        {
            var productDto = new ProductDto();
            return View(productDto);
        }




        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(ProductDto product, IFormFile file)
        {
            string companyId = HttpContext.Session.GetString("ComId");
            //string companyName = HttpContext.Session.GetString("ComName");
            string branchId = HttpContext.Session.GetString("BName");

            product.BranchId = Guid.Parse(branchId);
            product.CompanyId = Guid.Parse(companyId);
            try
            {
                if (ModelState.IsValid)
                {

                    if (file != null && file.Length > 0)
                    {
                        using (var memoryStream = new MemoryStream())
                        {
                            await file.CopyToAsync(memoryStream);
                            product.ProductImage = memoryStream.ToArray();
                            product.ProductImageUrl = $"data:image/png;base64,{Convert.ToBase64String(product.ProductImage)}";
                        }
                    }


                    _productService.CreateProduct(product);

                    return RedirectToAction(nameof(Index));
                }


                return View(product);
            }
            catch (Exception ex)
            {

                return View("Error");
            }
        }

        // GET: ProductController/Edit/{id}
        [HttpGet]
        public ActionResult Edit(Guid id)
        {
            // // Retrieve the existing product from your ProductService
            //// var existingProduct = _productService.GetProductById(id);

            // if (existingProduct == null)
            // {
            //     return NotFound();
            // }

            // // Map the existing product to the ProductDto
            // var productDto = new ProductDto
            // {
            //     ProductId = existingProduct.ProductId,
            //     ProductName = existingProduct.ProductName,
            //     ProductCode = existingProduct.ProductCode,
            //     Description = existingProduct.Description,
            //     ProductImageUrl = existingProduct.ProductImageUrl,
            //     DefaultBuyingPrice = existingProduct.DefaultBuyingPrice,
            //     DefaultSellingPrice = existingProduct.DefaultSellingPrice,
            //     BranchId = existingProduct.BranchId,
            //     Quantity = existingProduct.Quantity,
            //     CompanyId = existingProduct.CompanyId
            //};

            return View();
        }

        // POST: ProductController/Edit/{id}
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(Guid id, ProductDto product, IFormFile file)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    // Handle image upload
                    if (file != null && file.Length > 0)
                    {
                        using (var memoryStream = new MemoryStream())
                        {
                            await file.CopyToAsync(memoryStream);
                            product.ProductImage = memoryStream.ToArray();
                            product.ProductImageUrl = $"data:image/png;base64,{Convert.ToBase64String(product.ProductImage)}";
                        }
                    }

                    // Use your ProductService to update the product
                    //  _productService.UpdateProduct(id, product);

                    return RedirectToAction(nameof(Index));
                }

                // If ModelState is not valid, return to the edit view with the validation errors
                return View(product);
            }
            catch (Exception ex)
            {
                // Log the exception or handle it accordingly
                return View("Error"); // You might want to redirect to an error page
            }
        }

        // GET: ProductController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        [HttpGet]
        public ActionResult Details(Guid id)
        {
            return View();
        }

        // POST: ProductController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
