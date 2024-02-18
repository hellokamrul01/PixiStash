using PixiStash.Application.DTO;

namespace PixiStash.UI.Models
{
    public class SalesVM
    {
       
            public SalesDTO SalesData { get; set; }
            public List<SalesProductViewModel> Products { get; set; }
       

    }
}
