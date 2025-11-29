using Example_01.Events;

namespace Example_01.Services
{
    public class SMSService
    {
        public void OnOrderPlaced(object? sender, OrderPlacedEventArgs e)
        {
            Console.Write("[SMS] Sending message: ");
            Console.WriteLine($"Order {e.Order.OrderNumber} confirmed\n");
        }
    }
}