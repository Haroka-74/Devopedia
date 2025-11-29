using Spectre.Console;
using _01_Encapsulation.Models;

var unsafeCart = new ShoppingCart(1);
var safeCart = new ShoppingCart(2);

AnsiConsole.Write(new Rule("[red bold]UNSAFE[/]").Justify(Justify.Center));

var unsafeItems = unsafeCart.UnsafeItems;

Console.WriteLine($"User Products: [{string.Join(", ", unsafeItems)}]");

unsafeItems.Clear();

Console.WriteLine($"User Products: [{string.Join(", ", unsafeItems)}]");
Console.WriteLine("The user's products have been accidentally removed");

AnsiConsole.Write(new Rule("[green bold]SAFE[/]").Justify(Justify.Center));

var safeItems = safeCart.SafeItems;

Console.WriteLine($"User Products: [{string.Join(", ", safeItems)}]");