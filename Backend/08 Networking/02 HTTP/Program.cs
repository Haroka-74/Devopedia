using Spectre.Console;
using System.Net.Sockets;

var table = new Table();

table.AddColumn(new TableColumn("Version").Centered());
table.AddColumn(new TableColumn("Mode").Centered());
table.AddColumn(new TableColumn("TCP Connections").Centered());

table.AddRow("HTTP/1.0", "Sequential", CountConnections(new Version(1, 0), false).ToString());
table.AddRow("HTTP/1.0", "Parallel", CountConnections(new Version(1, 0), true).ToString());
table.AddRow("HTTP/1.1", "Sequential", CountConnections(new Version(1, 1), false).ToString());
table.AddRow("HTTP/1.1", "Parallel", CountConnections(new Version(1, 1), true).ToString());
table.AddRow("HTTP/2.0", "Sequential", CountConnections(new Version(2, 0), false).ToString());
table.AddRow("HTTP/2.0", "Parallel", CountConnections(new Version(2, 0), true).ToString());

AnsiConsole.Write(table);

int CountConnections(Version version, bool parallel)
{
    var count = 0;

    var handler = new SocketsHttpHandler
    {
        ConnectCallback = async (context, cancellationToken) =>
        {
            count++;

            var socket = new Socket(SocketType.Stream, ProtocolType.Tcp);

            await socket.ConnectAsync(context.DnsEndPoint, cancellationToken);

            return new NetworkStream(socket, ownsSocket: true);
        }
    };

    using var httpClient = new HttpClient(handler)
    {
        DefaultRequestVersion = version
    };

    if (parallel)
    {
        var threads = new Thread[5];

        for(int i = 0; i < 5; i++)
        {
            threads[i] = new Thread(() =>
            {
                _ = httpClient.GetAsync("https://dummyjson.com/products").Result;
            });

            threads[i].Start();
        }

        foreach(var thread in threads)
        {
            thread.Join();
        }
    }
    else
    {
        for (int i = 1; i <= 5; i++)
        {
            _ = httpClient.GetAsync("https://dummyjson.com/products").Result;
        }
    }

    return count;
}