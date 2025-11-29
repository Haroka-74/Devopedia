using Example_01.Models;
using Example_01.Services;

var orderService = new OrderService();

var smsService = new SMSService();
var emailService = new EmailService();
var inventoryService = new InventoryService();

orderService.OrderPlaced += smsService.OnOrderPlaced;
orderService.OrderPlaced += emailService.OnOrderPlaced;
orderService.OrderPlaced += inventoryService.OnOrderPlaced;

orderService.PlaceOrder(new Order()
{
    OrderNumber = "16333",
    CustomerName = "John Smith",
    CustomerEmail = "john@email.com",
    Products =
    [
        new Product { Name = "Laptop", Price = 999.99m },
        new Product { Name = "Mouse", Price = 29.99m }
    ],
    Total = 1029.98m
});