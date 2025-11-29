using System.Net;
using Spectre.Console;
using Google.Protobuf;
using System.Net.Sockets;

var server = new TcpListener(IPAddress.Parse("192.168.1.7"), 5000);

server.Start();
Console.WriteLine("Server is listening on 192.168.1.7:5000...");

var client = await server.AcceptTcpClientAsync();
Console.WriteLine($"Client connected!");

var employeeList = new EmployeeList();

employeeList.Employees.Add(new Employee
{
    Id = 1,
    FirstName = "John",
    LastName = "Smith",
    Email = "john.smith@company.com",
    Salary = 95000
});
employeeList.Employees[0].Skills.AddRange(["C#", "SQL", "Azure"]);

employeeList.Employees.Add(new Employee
{
    Id = 2,
    FirstName = "Sarah",
    LastName = "Johnson",
    Email = "sarah.johnson@company.com",
    Salary = 78000
});
employeeList.Employees[1].Skills.AddRange(["SEO", "Content Writing"]);

employeeList.Employees.Add(new Employee
{
    Id = 3,
    FirstName = "Michael",
    LastName = "Williams",
    Email = "michael.williams@company.com",
    Salary = 102000
});
employeeList.Employees[2].Skills.AddRange(["C++", "System Design"]);

employeeList.Employees.Add(new Employee
{
    Id = 4,
    FirstName = "Emily",
    LastName = "Brown",
    Email = "emily.brown@company.com",
    Salary = 72000
});
employeeList.Employees[3].Skills.AddRange(["Recruitment", "Employee Relations"]);

employeeList.Employees.Add(new Employee
{
    Id = 5,
    FirstName = "David",
    LastName = "Jones",
    Email = "david.jones@company.com",
    Salary = 85000
});
employeeList.Employees[4].Skills.AddRange(["Negotiation", "CRM"]);

var bytes = employeeList.ToByteArray();
var length = bytes.Length;

AnsiConsole.Write(new Panel("[red]Protobuf data is not human-readable[/]")
{
    Header = new PanelHeader($"Protobuf ({length} bytes)", Justify.Center),
    Border = BoxBorder.Rounded,
    Padding = new Padding(1, 1, 1, 1)
});

using var stream = client.GetStream();
await stream.WriteAsync(BitConverter.GetBytes(length));
await stream.WriteAsync(bytes);

client.Close();
server.Stop();