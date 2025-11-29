using System.Net;
using System.Text;
using System.Net.WebSockets;
using System.Collections.Concurrent;

var clients = new ConcurrentDictionary<string, WebSocket>();

var listener = new HttpListener();

listener.Prefixes.Add("http://localhost:5000/");
listener.Start();

while(true)
{
    var context = await listener.GetContextAsync();

    if(context.Request.IsWebSocketRequest)
    {
        var wsContext = await context.AcceptWebSocketAsync(null);
        var ws = wsContext.WebSocket;

        var id = Guid.NewGuid().ToString()[..8];
        clients.TryAdd(id, ws);

        Console.WriteLine($"Client {id} connected. Total clients: {clients.Count}");

        _ = Task.Run(() => HandleClient(id, ws));
    }
}

async Task HandleClient(string id, WebSocket ws)
{
    var buffer = new byte[1024];

    try
    {
        while(ws.State == WebSocketState.Open)
        {
            var result = await ws.ReceiveAsync(
                new ArraySegment<byte>(buffer),
                CancellationToken.None
            );

            if(result.MessageType == WebSocketMessageType.Close)
            {
                break;
            }
            else if(result.MessageType == WebSocketMessageType.Text)
            {
                var message = Encoding.UTF8.GetString(buffer, 0, result.Count);

                Console.WriteLine(message);

                await Broadcast(message, id);
            }
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Unexpected error handling client {id}: {ex.Message}");
    }
    finally
    {
        clients.TryRemove(id, out _);

        Console.WriteLine($"Client {id} connected. Total clients: {clients.Count}");

        if (ws.State == WebSocketState.Open)
        {
            try
            {
                await ws.CloseAsync(
                    WebSocketCloseStatus.NormalClosure,
                    "Server closing connection",
                    CancellationToken.None
                );
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error closing connection for client {id}: {ex.Message}");
            }
        }
    }
}

async Task Broadcast(string message, string senderId)
{
    var bytes = Encoding.UTF8.GetBytes(message);

    foreach(var client in clients)
    {
        if(client.Key != senderId && client.Value.State == WebSocketState.Open)
        {
            try
            {
                await client.Value.SendAsync(
                    new ArraySegment<byte>(bytes),
                    WebSocketMessageType.Text,
                    true,
                    CancellationToken.None
                );
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Error sending to client: {ex.Message}");
            }
        }
    }
}