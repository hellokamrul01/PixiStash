using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PixiStash.Application.DTO.BranchDTO;
using PixiStash.Application.IServices;
using PixiStash.Application.Services.IServices;

namespace PixiStash.UI.Controllers
{
    public class BranchController : Controller
    {
        private readonly IBranchService _branchService;
        public BranchController(IBranchService branchService)
        {
            _branchService = branchService;  
        }
        // GET: BranchController
        public ActionResult Index()
        {
           var branch = _branchService.GetBranches();
            return View(branch);
        }

        // GET: BranchController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BranchController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BranchController/Create
        [HttpPost]
        
        public ActionResult Create(BranchDto model)
        {
            try
            {
                _branchService.Create(model);   
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BranchController/Edit/5
        public async Task<IActionResult> Edit(Guid id, Guid companyId)
        {
          var data = await _branchService.GetBranchDetails(id, companyId);

            return View(data);
        }

        // POST: BranchController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(BranchDto model)
        {
            try
            {
                _branchService.UpdateBranch(model);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BranchController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BranchController/Delete/5
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
