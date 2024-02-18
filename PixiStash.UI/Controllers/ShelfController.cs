using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PixiStash.Application.DTO.ProductShelfDTO;
using PixiStash.Application.Services.IServices;

namespace PixiStash.UI.Controllers
{
    public class ShelfController : Controller
    {
        private readonly IProductShelfService _shelfService;
        public ShelfController(IProductShelfService shelfService)
        {
            _shelfService = shelfService;   
                
        }
        // GET: ShelfController
        public ActionResult Index()
        {
           var data = _shelfService.GetShelfs();
            return View(data);
        }

        // GET: ShelfController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ShelfController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ShelfController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProductShelfDto model)
        {
            try
            {
                _shelfService.CreateShelf(model);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ShelfController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ShelfController/Edit/5
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

        // GET: ShelfController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ShelfController/Delete/5
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
