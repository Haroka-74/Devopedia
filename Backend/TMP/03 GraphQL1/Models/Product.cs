namespace Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public ICollection<string> Tags { get; set; } = [];
        public Category Category { get; set; } = null!;
    }
}