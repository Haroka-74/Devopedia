namespace Example_01.Models
{
    public class Order
    {
        public string OrderNumber { get; set; } = string.Empty;
        public string CustomerName { get; set; } = string.Empty;
        public string CustomerEmail { get; set; } = string.Empty;
        public IEnumerable<Product> Products { get; set; } = [];
        public decimal Total { get; set; }
    }
}