// Use `tcpdump -i any -nn port 5000` in Ubuntu WSL to monitor the TCP handshake
// tcpdump reference: https://www.tcpdump.org/index.html

using System.Net;
using System.Text;
using System.Net.Sockets;

var addressFamily = AddressFamily.InterNetwork;
var socketType = SocketType.Stream;
var protocolType = ProtocolType.Tcp;

var server = new Socket(addressFamily, socketType, protocolType);

server.Bind(new IPEndPoint(IPAddress.Parse("192.168.1.7"), 5000));

server.Listen(1);
Console.WriteLine("Server is listening on 192.168.1.7:5000...");

var client = server.Accept();
Console.WriteLine($"Client connected!");

var response = "Hello from server!";
client.Send(Encoding.UTF8.GetBytes(response));

client.Close();
server.Close();