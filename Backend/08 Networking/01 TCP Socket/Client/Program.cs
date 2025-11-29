using System.Net;
using System.Text;
using System.Net.Sockets;

var addressFamily = AddressFamily.InterNetwork;
var socketType = SocketType.Stream;
var protocolType = ProtocolType.Tcp;

var client = new Socket(addressFamily, socketType, protocolType);

client.Connect(new IPEndPoint(IPAddress.Parse("192.168.1.7"), 5000));
Console.WriteLine("Connected to server at 192.168.1.7:5000");

var buffer = new byte[1024];
var received = client.Receive(buffer);
Console.WriteLine("Server says: " + Encoding.UTF8.GetString(buffer, 0, received));

client.Close();