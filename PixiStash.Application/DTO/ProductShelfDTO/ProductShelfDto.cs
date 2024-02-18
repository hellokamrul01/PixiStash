using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixiStash.Application.DTO.ProductShelfDTO
{
    public class ProductShelfDto
    {
        public Guid? Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public Guid BranchId { get; set; }
      
    }
}
