using Example_01.Events;

namespace Example_01.Services
{
    public class InventoryService
    {
        public void OnOrderPlaced(object? sender, OrderPlacedEventArgs e)
        {
            Console.WriteLine($"[Inventory] Updating stock for {e.Order.Products.Count()} items\n");
        }
    }
}