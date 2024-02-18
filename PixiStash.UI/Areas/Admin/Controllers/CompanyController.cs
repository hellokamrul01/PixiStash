using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using PixiStash.Application.DTO;
using PixiStash.Application.DTO.Auth;
using PixiStash.Application.DTO.Auth.RegistrationRequestDto;
using PixiStash.Application.DTO.BranchDTO;
using PixiStash.Application.IServices;
using PixiStash.Application.Service.IService;
using PixiStash.Application.Services.IServices;
using PixiStash.Core.Models;
using PixiStash.DataAccess.Persistence;

namespace PixiStash.UI.Areas.Admin.Controllers
{
    [Area("Admin")]
   // [Authorize]
    public class CompanyController : Controller
    {

        private readonly ICompanyService _companyService;
        private readonly IAuthService _authService;
        private readonly IBranchService _branchService;
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;
        private readonly IUserService _userService;
        public CompanyController(IUserService userService, ICompanyService companyService, IAuthService authService,IBranchService branchService, IMapper mapper)
        {
            _companyService = companyService;
            _authService = authService; 
            _branchService = branchService; 
            _mapper = mapper; 
            _userService = userService; 
        }
        // GET: CompanyController
        public ActionResult Index()

        {
            List<CompanyDTO> companies = _companyService.GetCompanies().ToList();

            return View(companies);
        }

        // GET: CompanyController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CompanyController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CompanyController/Create
       // [Authorize(Roles = "SuperAdmin")]
        [HttpPost]
        //[ValidateAntiForgeryToken]
       
        public ActionResult Create(CompanyDTO model)
        {
           // var user = HttpContext.User;
           var comid = Guid.NewGuid();
           var bid = Guid.NewGuid();
          // var comid = Guid.NewGuid();
            try
            {
                model.Id = comid;
                _companyService.CreateCompany(model);

                RegistrationRequestDto user = new RegistrationRequestDto
                {
                    Email = model.Email,
                    Name = model.Name,
                    PhoneNumber = model.Phone,
                    Role = "",
                    Password = "#@BinaryBrust12",
                };
                var data = _authService.Register(user).Result;

                var f = _authService.AssignRole(model.Email, "CompanyAdmin").Result;
                    BranchDto branch = new BranchDto
                    {
                        BranchId = bid,   
                        BranchName = model.Name,
                        Address = "N/A",
                        CompanyId = comid,  
                    };
                _branchService.Create(branch);

                UserDTO comUser = new UserDTO
                {
                    Id = new Guid(data),
                    UserName = model.Name,
                    FirstName = model.Name, 
                    LastName = model.Name,
                    Email = model.Email,
                    Password = user.Password,
                    PhoneNumber = model.Phone, 
                    IsActive = true,
                    BranchId = bid,
                    CompanyId = comid ,
                    DateOfBirth = DateTime.Now, 
                                                
                };

                //var us =  _mapper.Map<User>(comUser);
                // _context.Users.Add(us);
                //_context.SaveChanges(); 
                _userService.CreateUser(comUser);   

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }



        [HttpGet]
        public IActionResult SendInviteLink()
        {
            string companyId = HttpContext.Session.GetString("ComId");
            string companyName = HttpContext.Session.GetString("ComName");
            string branchId = HttpContext.Session.GetString("BName");
           // string inviteLink = $"{HttpContext.Request.Scheme}://{HttpContext.Request.Host}/register?ComId={companyId}&BName={branchId}";
            string inviteLink = $"{HttpContext.Request.Scheme}://{HttpContext.Request.Host}/Account/Register?ComId={companyId}&BName={branchId}";

            ViewBag.InviteLink = inviteLink;
            return View();
        }


        // GET: CompanyController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

       

        // POST: CompanyController/Edit/5
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

        // GET: CompanyController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CompanyController/Delete/5
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
