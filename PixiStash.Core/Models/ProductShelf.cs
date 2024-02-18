using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixiStash.Core.Models
{
    public class ProductShelf
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        
      //  public Guid CompanyId { get; set; }
       // public Company Company { get; set; }
        public Guid BranchId { get; set; }
        public Branch Branch { get; set; }
        public List<Product> Products { get; set; }
    }

}
