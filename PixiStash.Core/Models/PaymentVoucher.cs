using System;
using System.ComponentModel.DataAnnotations;

namespace PixiStash.Core.Models
{
    public class PaymentVoucher
    {
        public Guid PaymentvoucherId { get; set; }
        [Display(Name = "Payment Voucher Number")]
        public string PaymentVoucherName { get; set; }
        [Display(Name = "Bill")]
        public Guid BillId { get; set; }
        public DateTimeOffset PaymentDate { get; set; }
        [Display(Name = "Payment Type")]
        public Guid PaymentTypeId { get; set; }
        public double PaymentAmount { get; set; }
        [Display(Name = "Payment Source")]
        public Guid CashBankId { get; set; }
        [Display(Name = "Full Payment")]
        public bool IsFullPayment { get; set; } = true;

        public Guid CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
