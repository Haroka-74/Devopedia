using System.Text;
using System.Net.WebSockets;

var client = new ClientWebSocket();

Console.Write("Enter your username: ");

var username = Console.ReadLine() ?? "Anonymous";

await client.ConnectAsync(
    new Uri("ws://localhost:5000/"),
    CancellationToken.None
);

Console.WriteLine("\nType 'exit' to disconnect");
Console.WriteLine(new string('-', 50));

var cts = new CancellationTokenSource();

var task = Task.Run(async () =>
{
    var buffer = new byte[1024];

    while(client.State == WebSocketState.Open)
    {
        try
        {
            var result = await client.ReceiveAsync(
                new ArraySegment<byte>(buffer),
                CancellationToken.None
            );

            if(result.MessageType == WebSocketMessageType.Text)
            {
                var message = Encoding.UTF8.GetString(buffer, 0, result.Count);

                Console.Write("\r" + new string(' ', Console.WindowWidth - 1) + "\r");
                Console.WriteLine(message);
                Console.Write("> ");
            }
            else if(result.MessageType == WebSocketMessageType.Close)
            {
                break;
            }
        }
        catch
        {
            break;
        }
    }
}, cts.Token);

while (true)
{
    Console.Write("> ");

    var input = Console.ReadLine();

    if (input == "exit")
    {
        break;
    }

    var message = $"{username}: {input}";
    var bytes = Encoding.UTF8.GetBytes(message);

    try
    {
        await client.SendAsync(
            new ArraySegment<byte>(bytes),
            WebSocketMessageType.Text,
            true,
            CancellationToken.None
        );
    }
    catch
    {
        break;
    }
}

cts.Cancel();

if (client.State == WebSocketState.Open || client.State == WebSocketState.CloseReceived)
{
    try
    {
        await client.CloseAsync(
            WebSocketCloseStatus.NormalClosure,
            "Client disconnecting",
            CancellationToken.None
        );
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error during disconnect: {ex.Message}");
    }
}

await task;