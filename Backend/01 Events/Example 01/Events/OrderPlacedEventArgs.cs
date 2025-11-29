using Example_01.Models;

namespace Example_01.Events
{
    public class OrderPlacedEventArgs(Order order)
    {
        public Order Order { get; set; } = order;
    }
}