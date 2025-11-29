using Example_01.Events;

namespace Example_01.Services
{
    public class EmailService
    {
        public void OnOrderPlaced(object? sender, OrderPlacedEventArgs e)
        {
            Console.WriteLine($"[Email] Sending confirmation to {e.Order.CustomerEmail}");
            Console.WriteLine($"Order: {e.Order.OrderNumber}, Total: {e.Order.Total:F2}\n");
        }
    }
}