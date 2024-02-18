using PixiStash.Application.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixiStash.Application.Services.IServices
{
    public interface IComUserService
    {
        List<CompanyDTO> GetComByUser();
    }
}
