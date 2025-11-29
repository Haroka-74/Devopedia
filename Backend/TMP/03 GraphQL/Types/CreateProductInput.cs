using _03_GraphQL.Enums;

namespace _03_GraphQL.Types
{
    public class CreateProductInput
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public Category Category { get; set; }
        public int Stock { get; set; }
    }
}