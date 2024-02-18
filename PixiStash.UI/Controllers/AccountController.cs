using AutoMapper;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using PixiStash.Application.DTO.Auth;
using PixiStash.Application.Service.IService;
using PixiStash.Core.Models;
using PixiStash.DataAccess;
using System.Security.Claims;
using PixiStash.Application.DTO.Auth.RegistrationRequestDto;
using PixiStash.Application.IServices;
using PixiStash.Application.DTO;
using PixiStash.Application.Services.IServices;
using Microsoft.IdentityModel.Tokens;

namespace PixiStash.UI.Controllers
{
    public class AccountController : Controller
    {

        private readonly IAuthService _authService;
        private readonly IUnitOfWork _unit;
        private readonly IMapper _mapper;

        private readonly IConfiguration _configuration;
        protected ResponseDto _response;
        private readonly ICompanyService _companyService;
        private readonly IUserService _userService;
        public AccountController( IUserService userService, IAuthService authService, IConfiguration configuration, IUnitOfWork unit, ICompanyService companyService)

        {
            _authService = authService;
            _configuration = configuration;
            _unit = unit;
            _companyService = companyService; 
            _userService = userService;

            _response = new();
        }


       
        public async Task<IActionResult> Companyregister([FromBody] CompanyDTO model)
        {
            Company register = new Company
            {
                Id = Guid.NewGuid(),
                Name = model.Name,
                Description = model.Description,
                Phone = model.Phone,
                Email = model.Email
                // Add other properties as needed
            };

            // Company company = _mapper.Map<Company>(model);

            //var company = _mapper.Map<Company>(model);
            _unit.Companies.Add(register);
            _unit.save();
            return Ok();

        }



       
        [HttpPost]
        public async Task<IActionResult> Registration(RegistrationRequestDto model)
        {

            var errorMessage = await _authService.Register(model);
            if (!string.IsNullOrEmpty(errorMessage))
            {
                _response.IsSuccess = false;
                _response.Message = errorMessage;
                return BadRequest(_response);
            }
            // await _messageBus.PublishMessage(model.Email, _configuration.GetValue<string>("TopicAndQueueNames:RegisterUserQueue"));
            return RedirectToAction("Login", "Account");
        }


        [HttpPost]
        public async Task<IActionResult> Login(LoginRequestDto model)
        {
            var loginResponse = await _authService.Login(model);

            if (loginResponse.User == null)
            {
                _response.IsSuccess = false;
                _response.Message = "Username or password is incorrect";
                return View(_response);
            }
            else
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, loginResponse.User.Name),
                    new Claim(ClaimTypes.Email, loginResponse.User.Email),
                    new Claim(ClaimTypes.Role, loginResponse.Role),
                    // Add additional claims as needed
                };

                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var authProperties = new AuthenticationProperties
                {
                    // Set additional authentication properties if needed
                };

                await HttpContext.SignInAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(claimsIdentity),
                    authProperties);

                if(loginResponse.Role == "SuperAdmin")
                {
                    HttpContext.Session.SetString("UserName", loginResponse.User.Name);
                    HttpContext.Session.SetString("UserEmail", loginResponse.User.Email);
                    HttpContext.Session.SetString("UserRole", loginResponse.Role);
                    HttpContext.Session.SetString("UserId", loginResponse.User.ID);
                    return RedirectToAction("Index", "Home", new { area = "Admin" });

                }
                else
                {
                    // Store user information in session
                    HttpContext.Session.SetString("UserName", loginResponse.User.Name);
                    HttpContext.Session.SetString("UserEmail", loginResponse.User.Email);
                    HttpContext.Session.SetString("UserRole", loginResponse.Role);
                    HttpContext.Session.SetString("UserId", loginResponse.User.ID);
                    CompanyDTO company = _companyService.GetCompanyByUserId(new Guid(loginResponse.User.ID));
                    if (company != null)
                    {
                        HttpContext.Session.SetString("ComId", company.Id.ToString());
                        HttpContext.Session.SetString("ComName", company.Name);
                        HttpContext.Session.SetString("BName", company.user.BranchId.ToString());
                        TempData["CompanyName"] = company.Name;

                        return RedirectToAction("Index", "Home", new { area = "Admin" });
                    }
                    else
                    {
                        return View("Login");
                    }
                }
               
                    

                // Redirect to the "Index" action in the "Home" controller in the "Admin" area
                //return RedirectToAction("Index", "Home", new { area = "Admin" });
            }
        }



        [HttpGet]
        public ActionResult Register(string ComId, string BName)
        {
            ViewBag.CompanyId = new Guid(ComId);
            ViewBag.BranchId = new Guid(BName);

            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Register(UserDTO model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            RegistrationRequestDto registrationRequest = new RegistrationRequestDto
            {
                Email = model.Email,
                Name = model.FirstName,
                Password = model.Password,
                PhoneNumber = model.PhoneNumber,
                Role = "User"
            };

            try
            {
                var userId = await _authService.Register(registrationRequest);

                if (!string.IsNullOrEmpty(userId))
                {
                    model.IsActive = true;
                    model.Id = new Guid(userId);

                   
                     _userService.CreateUser(model);

                    return RedirectToAction("Login", "Account");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Registration failed. Please try again.");
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, "An error occurred during registration. Please try again.");
            }

            return View(model);
        }


        //[HttpPost]
        //public async Task<IActionResult> Login(LoginRequestDto model)
        //{
        //    var loginResponse = await _authService.Login(model);


        //    if (loginResponse.User == null)
        //    {
        //        _response.IsSuccess = false;
        //        _response.Message = "Username or password is incorrect";
        //        return View(_response);
        //    }
        //    else
        //    {
        //       // _response.Result = loginResponse;

        //        return RedirectToAction("Index", "Account", new { area = "Admin" });
        //    }



        //}


        public async Task<IActionResult> AssignRole([FromBody] RegistrationRequestDto model)
        {
            var assignRoleSuccessful = await _authService.AssignRole(model.Email, model.Role.ToUpper());
            if (!assignRoleSuccessful)
            {
                _response.IsSuccess = false;
                _response.Message = "Error encountered";
                return BadRequest(_response);
            }
            return Ok(_response);

        }


       
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Registration()
        {
            return View();
        }

       
       
        public ActionResult Create()
        {
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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
