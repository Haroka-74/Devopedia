using System.Net;
using System.Text;
using Server.Models;
using Spectre.Console;
using System.Net.Sockets;
using System.Xml.Serialization;

var server = new TcpListener(IPAddress.Parse("192.168.1.7"), 5000);

server.Start();
Console.WriteLine("Server is listening on 192.168.1.7:5000...");

var client = await server.AcceptTcpClientAsync();
Console.WriteLine($"Client connected!");

List<Employee> employees =
[
    new()
    {
        Id = 1, FirstName = "John", LastName = "Smith", Email = "john.smith@company.com",
        Salary = 95000, Skills = ["C#", "SQL", "Azure"]
    },
    new()
    {
        Id = 2, FirstName = "Sarah", LastName = "Johnson", Email = "sarah.johnson@company.com",
        Salary = 78000, Skills = ["SEO", "Content Writing"]
    },
    new()
    {
        Id = 3, FirstName = "Michael", LastName = "Williams", Email = "michael.williams@company.com",
        Salary = 102000, Skills = ["C++", "System Design"]
    },
    new()
    {
        Id = 4, FirstName = "Emily", LastName = "Brown", Email = "emily.brown@company.com",
        Salary = 72000, Skills = ["Recruitment", "Employee Relations"]
    },
    new()
    {
        Id = 5, FirstName = "David", LastName = "Jones", Email = "david.jones@company.com",
        Salary = 85000, Skills = ["Negotiation", "CRM"]
    }
];

var serializer = new XmlSerializer(typeof(List<Employee>));
using var sw = new StringWriter();

serializer.Serialize(sw, employees);

var xml = sw.ToString();
var bytes = Encoding.UTF8.GetBytes(xml);
var length = bytes.Length;

AnsiConsole.Write(new Panel(xml)
{
    Header = new PanelHeader($"XML ({length} bytes)", Justify.Center),
    Border = BoxBorder.Rounded,
    Padding = new Padding(1, 1, 1, 1)
});

using var stream = client.GetStream();

await stream.WriteAsync(BitConverter.GetBytes(length));
await stream.WriteAsync(bytes);

client.Close();
server.Stop();