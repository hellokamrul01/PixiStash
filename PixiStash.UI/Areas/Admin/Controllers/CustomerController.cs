using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PixiStash.Application.DTO;
using PixiStash.Application.Services.IServices;

namespace PixiStash.UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CustomerController : Controller
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
                _customerService = customerService;
        }
        public async Task<IActionResult> Index()
        {
            string comid = HttpContext.Session.GetString("ComId");
           // string branchId = HttpContext.Session.GetString("BName");
            var companyId = Guid.Parse(comid);
     

            var data = await _customerService.GetCustomers(companyId);
            return View(data.ToList());
        }


        public ActionResult Details(int id)
        {
            return View();
        }


        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]      
        public ActionResult Create(CustomerDTO model)
        {
            string comid = HttpContext.Session.GetString("ComId");
            string branchId = HttpContext.Session.GetString("BName");
            var companyId = Guid.Parse(comid);
            var bid = Guid.Parse(branchId);
            model.BranchId = bid;
            model.CompanyId = companyId;    
            try
            {
                _customerService.CreateCustomer(model); 
                return RedirectToAction(nameof(Index));
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
                return RedirectToAction(nameof(Index));
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
