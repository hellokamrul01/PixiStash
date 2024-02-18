namespace PixiStash.UI.Models
{
    public class SalesProductViewModel
    {
        public DateTime ServiceDate { get; set; }
        public Guid ProductId { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal Rate { get; set; }
        public int Quantity { get; set; }
        public decimal Amount { get; set; }
        public decimal Tax { get; set; }
    }
}
