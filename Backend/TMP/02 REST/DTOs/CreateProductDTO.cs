using _02_REST.Enums;

namespace _02_REST.DTOs
{
    public class CreateProductDTO
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public Category Category { get; set; }
        public int Stock { get; set; }
    }
}