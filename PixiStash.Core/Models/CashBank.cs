using System.ComponentModel.DataAnnotations;

namespace PixiStash.Core.Models
{
    public class CashBank
    {
        public int CashBankId { get; set; }
        [Display(Name = "Cash / Bank Name")]
        public string CashBankName { get; set; }
        public string Description { get; set; }

        public Guid CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
