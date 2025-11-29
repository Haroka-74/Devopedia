using System.Text;
using System.Text.Json;
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

var json = Encoding.UTF8.GetString(bytes);

var document = JsonDocument.Parse(json);
var source = document.RootElement.EnumerateArray();
var employees = source.Select(e => new
{
    Id = e.GetProperty("Id").GetInt32(),
    FirstName = e.GetProperty("FirstName").GetString(),
    LastName = e.GetProperty("LastName").GetString(),
    Email = e.GetProperty("Email").GetString(),
    Salary = e.GetProperty("Salary").GetDouble(),
    Skills = e.GetProperty("Skills").EnumerateArray().Select(s => s.ToString()).ToList()
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