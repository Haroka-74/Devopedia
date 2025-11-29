using System.Text;
using System.Xml.Linq;
using System.Net.Sockets;

var client = new TcpClient();

await client.ConnectAsync("192.168.1.7", 5000);
Console.WriteLine("Connected to server! \n");

using var stream = client.GetStream();

var lengthBytes = new byte[4];
await stream.ReadExactlyAsync(lengthBytes.AsMemory(0, 4));
var length = BitConverter.ToInt32(lengthBytes);

var bytes = new byte[length];
await stream.ReadExactlyAsync(bytes.AsMemory(0, length));

var xml = Encoding.UTF8.GetString(bytes);

var document = XDocument.Parse(xml);
var source = document?.Root?.Elements("Employee");
var employees = source?.Select(e => new
{
    Id = e.Element("Id")?.Value,
    FirstName = e.Element("FirstName")?.Value,
    LastName = e.Element("LastName")?.Value,
    Email = e.Element("Email")?.Value,
    Salary = e.Element("Salary")?.Value,
    Skills = e.Element("Skills")?.Elements()?.Select(s => s.Value).ToList()
});

foreach(var employee in employees!)
{
    var id = employee.Id;
    var firstName = employee.FirstName;
    var lastName = employee.LastName;
    var email = employee.Email;
    var salary = employee.Salary;
    var skills = employee.Skills;

    Console.WriteLine($"{id}, {firstName}, {lastName}, {email}, {salary}");
    Console.WriteLine($"[{string.Join(", ", skills!)}]");
    Console.WriteLine();
}

client.Close();