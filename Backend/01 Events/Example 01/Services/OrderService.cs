using Example_01.Events;
using Example_01.Models;

namespace Example_01.Services
{
    public class OrderService
    {
        public event EventHandler<OrderPlacedEventArgs>? OrderPlaced;

        public void PlaceOrder(Order order)
        {
            Console.WriteLine($"Processing order {order.OrderNumber}...\n");

            OnOrderPlaced(order);

            Console.WriteLine($"Order {order.OrderNumber} completed!");
        }

        protected virtual void OnOrderPlaced(Order order)
            => OrderPlaced?.Invoke(this, new OrderPlacedEventArgs(order));
    }
}