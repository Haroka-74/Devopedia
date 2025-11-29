namespace _01_Encapsulation.Models
{
    public class ShoppingCart(int userId)
    {
        private readonly IList<string> _items =
        [
            "Samsung Galaxy S24",
            "AirPods Pro 2",
            "Amazon Kindle Paperwhite"
        ];

        public int UserId => userId;

        // Unsafe: client could modify the list
        public IList<string> UnsafeItems => _items;

        // Safe: client cannot modify the list
        public IReadOnlyList<string> SafeItems => _items.AsReadOnly();
    }
}