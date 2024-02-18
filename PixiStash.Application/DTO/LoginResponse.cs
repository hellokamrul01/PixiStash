using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixiStash.Application.DTO
{
    public class LoginResponse
    {

        public LoginResponse(string json)
        {
            if (json != null)
            {
                JObject str = JObject.Parse(json);

                var result = str["Result"].ToString();
                var com = str["Companies"].ToString();
                JObject str1 = JObject.Parse(result);


                ResponseObject Response = JsonConvert.DeserializeObject<ResponseObject>(json);
                var company = JsonConvert.DeserializeObject<List<CareCompany>>(com);
                Success = (bool)str1["Succeeded"];
                IsLockedOut = (bool)str1["IsLockedOut"];
                IsNotAllowed = (bool)str1["IsNotAllowed"];
                RequiresTwoFactor = (bool)str1["RequiresTwoFactor"];
                Companies = company;
                UserId = Response.UserId;
                UserName = Response.UserName;
                FullName = Response.FullName;
                Products = Response.Products;
                AppKey = Response.AppKeys;
                UserRoles = Response.UserRoles;
                Errors = Response.Errors;
                IsActive = Response.IsActive;
            }
        }


        public bool Success { get; set; }
        public bool IsActive { get; set; }
        public bool IsLockedOut { get; set; }
        public bool IsNotAllowed { get; set; }
        public bool RequiresTwoFactor { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string[] Errors { get; set; }
        public List<CareCompany> Companies { get; set; }
        public List<Product> Products { get; set; }
        public List<AppKey> AppKey { get; }
        public List<UserRole> UserRoles { get; set; }
    }


    public class ResponseObject
    {
        public int Id { get; set; }
        //public SignInResult Result { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string[] Errors { get; set; }
        public bool IsActive { get; set; }
        public CareCompany Companie { get; set; }
        public List<Product> Products { get; set; }
        public List<AppKey> AppKeys { get; set; }
        public List<UserRole> UserRoles { get; set; }

    }
    public class CareCompany
    {
        public string ComId { get; set; }
        public string CompanyName { get; set; }

        public static explicit operator CareCompany(List<JToken> v)
        {
            throw new NotImplementedException();
        }
    }
    public class Product
    {
        public string AppKey { get; set; }
        public string Name { get; set; }
        public string ComId { get; set; }
        public string VersionName { get; set; }
        public int SoftwareId { get; set; }
        public int VersionId { get; set; }
    }

    public class Software
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }

    }

    public class AppKey
    {
        public Guid Id { get; set; }
        public Guid ComId { get; set; }
        public DateTime Exdate { get; set; }
    }

    public class UserRole
    {
        public string UserId { get; set; }
        public string Role { get; set; }
        public string ComId { get; set; }
    }
}
