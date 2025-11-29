<div style = "font-family: 'Roboto', sans-serif;">

# Syllabus

- [𝐂#](https://learn.microsoft.com/en-us/dotnet/csharp)
- [𝓒#](https://learn.microsoft.com/en-us/dotnet/csharp)


<!--

https://xunit.net
https://fluentassertions.com

-->













#
#
#
#
#
#
#


- [Object-Oriented Programming (OOP)](https://www.freecodecamp.org/news/how-to-use-oop-in-c-sharp#heading-what-is-object-oriented-programming-oop)
- [SOLID Principles](https://www.freecodecamp.org/news/solid-principles-explained-in-plain-english)
    - [`SRP`](https://en.wikipedia.org/wiki/Single-responsibility_principle) [`OCP`](https://en.wikipedia.org/wiki/Open%E2%80%93closed_principle) [`LSP`](https://en.wikipedia.org/wiki/Liskov_substitution_principle) [`ISP`](https://en.wikipedia.org/wiki/Interface_segregation_principle) [`DIP`](https://en.wikipedia.org/wiki/Dependency_inversion_principle)
- [DRY Principle](https://www.bytehide.com/blog/dry-principle-csharp)
- [KISS Principle](https://www.bytehide.com/blog/kiss-principle-csharp)
- [YAGNI Principle](https://www.bytehide.com/blog/yagni-principle-csharp)
- [Design Patterns](https://refactoring.guru/design-patterns)
- [How does Computer Hardware Work?](https://www.youtube.com/watch?v=d86ws7mQYIg)
- [Process vs. Thread](https://www.youtube.com/watch?v=4rLW7zg21gI)
    - [Process](https://en.wikipedia.org/wiki/Process_(computing))
        - [Inter-process Communication](https://en.wikipedia.org/wiki/Inter-process_communication)
    - [Thread](https://en.wikipedia.org/wiki/Thread_(computing))
- [Multithreading vs. Multiprocessing](https://www.youtube.com/watch?v=PgDaJEjlBuI)
- [Concurrency vs. Parallelism](https://www.youtube.com/watch?v=RlM9AfWf1WU)
- [Computer Memory](https://simple.wikipedia.org/wiki/Computer_memory)
- [Central Processing Unit vs. Graphics Processing Unit](https://www.youtube.com/watch?v=Axd50ew4pco)
    - [Central Processing Unit (CPU)](https://en.wikipedia.org/wiki/Central_processing_unit)
    - [Graphics Processing Unit (GPU)](https://en.wikipedia.org/wiki/Graphics_processing_unit)
- [Operating System](https://en.wikipedia.org/wiki/Operating_system)
- [Computer Multitasking](https://en.wikipedia.org/wiki/Computer_multitasking)
    - [Cooperative Multitasking](https://en.wikipedia.org/wiki/Cooperative_multitasking)
    - [Preemption](https://en.wikipedia.org/wiki/Preemption_(computing))
- [Computer Network](https://en.wikipedia.org/wiki/Computer_network)
- [Open Systems Interconnection (OSI)](https://en.wikipedia.org/wiki/OSI_model)
    - [Open Systems Interconnection (OSI)](https://www.youtube.com/watch?v=A31bxOyj5mk)
- [Internet Protocol version 4 (IPv4)](https://en.wikipedia.org/wiki/IPv4)
- [Internet Protocol version 6 (IPv6)](https://en.wikipedia.org/wiki/IPv6)
- [What is a Computer Port?](https://www.cloudflare.com/learning/network-layer/what-is-a-computer-port)
- [What is a Socket?](https://www.youtube.com/watch?v=D26sUZ6DHNQ)
    - [Transmission Control Protocol (TCP)](https://en.wikipedia.org/wiki/Transmission_Control_Protocol)
    - [User Datagram Protocol (UDP)](https://en.wikipedia.org/wiki/User_Datagram_Protocol)
- [Remote Procedure Call (RPC)](https://en.wikipedia.org/wiki/Remote_procedure_call)
- [Hypertext Transfer Protocol (HTTP)](https://developer.mozilla.org/en-US/docs/Web/HTTP)
    - [HTTP/1 vs. HTTP/2 vs. HTTP/3](https://www.youtube.com/watch?v=UMwQjFzTQXw)
    - [Hypertext Transfer Protocol Secure (HTTPS)](https://www.youtube.com/watch?v=j9QmMEWmcfo)
    - [QUIC and HTTP/3](https://www.youtube.com/watch?v=_QQX0Ezpq8U)
- [What is Data Exchange?](https://www.ibm.com/think/topics/data-exchange)
    - [Extensible Markup Language (XML)](https://en.wikipedia.org/wiki/XML)
    - [JavaScript Object Notation (JSON)](https://en.wikipedia.org/wiki/JSON)
    - [Protocol Buffers (Protobuf)](https://protobuf.dev)
- [.NET](https://learn.microsoft.com/en-us/dotnet)
- [API Architecture Styles](https://www.youtube.com/watch?v=4vLxWqE94l4)
    - [Simple Object Access Protocol (SOAP)](https://www.ramotion.com/blog/soap-in-web-services)
    - [Representational State Transfer (REST)](https://www.youtube.com/watch?v=XvFmUE-36Kc)
    - [GraphQL](https://graphql.org)

</div>



#
#
#
#
#
#
#
#
#
#
#
#
#
#
#


gRPC
WebSocket
Webhook



- [SignalR]()











<!--
1. Repository Pattern
2. Unit of Work Pattern
3. Factory Pattern
7. Decorator Pattern
-->

<!--

// Compilation Process: [ https://www.scaler.com/topics/csharp/compilation-process-in-c-sharp/ ].
// source code [ using C# compiler ] ==> Intermediate Language 'IL' or Microsoft Intermediate Language 'MSIL' or Common Intermediate Language 'CIL' [ Common Language Runtime 'CLR' has 'JIT' ] ==> Machine Code 'zeros and ones'.
// search for 'CLS' and 'CTS'.

-->



<!--

https://learn.microsoft.com/en-us/dotnet/csharp/linq [ read about LINQ and also what is PLINQ ]

https://claude.ai/chat/6a55929e-a733-44c4-9cc1-95533a19c3dd
https://claude.ai/chat/84760d01-d526-4390-a475-c2f26b4ac657

-->

<!--  don't forget repo cases  -->






#
#
#
#
#
#
#
#
#
#



<!--










/*
using System;
using System.Net;
using System.Net.WebSockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        var listener = new HttpListener();
        listener.Prefixes.Add("http://localhost:5000/ws/");
        listener.Start();
        Console.WriteLine("WebSocket server started at ws://localhost:5000/ws/");

        while (true)
        {
            var context = await listener.GetContextAsync();

            if (context.Request.IsWebSocketRequest)
            {
                var wsContext = await context.AcceptWebSocketAsync(null);
                var webSocket = wsContext.WebSocket;
                Console.WriteLine("Client connected");

                await EchoMessages(webSocket);
            }
            else
            {
                context.Response.StatusCode = 400;
                context.Response.Close();
            }
        }
    }

    static async Task EchoMessages(WebSocket webSocket)
    {
        var buffer = new byte[1024 * 4];

        while (webSocket.State == WebSocketState.Open)
        {
            var result = await webSocket.ReceiveAsync(new ArraySegment<byte>(buffer), CancellationToken.None);

            if (result.MessageType == WebSocketMessageType.Close)
            {
                await webSocket.CloseAsync(WebSocketCloseStatus.NormalClosure, "Closing", CancellationToken.None);
            }
            else
            {
                var message = Encoding.UTF8.GetString(buffer, 0, result.Count);
                Console.WriteLine("Received: " + message);

                // Echo back
                var reply = Encoding.UTF8.GetBytes("Server says: " + message);
                await webSocket.SendAsync(new ArraySegment<byte>(reply), WebSocketMessageType.Text, true, CancellationToken.None);
            }
        }
    }
}
*/





/*

using System;
using System.Net.WebSockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        using var ws = new ClientWebSocket();
        await ws.ConnectAsync(new Uri("ws://localhost:5000/ws/"), CancellationToken.None);
        Console.WriteLine("Connected to WebSocket server");

        // Send a message
        string msg = "Hello Server!";
        var bytes = Encoding.UTF8.GetBytes(msg);
        await ws.SendAsync(new ArraySegment<byte>(bytes), WebSocketMessageType.Text, true, CancellationToken.None);

        // Receive reply
        var buffer = new byte[1024 * 4];
        var result = await ws.ReceiveAsync(new ArraySegment<byte>(buffer), CancellationToken.None);
        Console.WriteLine("Received from server: " + Encoding.UTF8.GetString(buffer, 0, result.Count));

        await ws.CloseAsync(WebSocketCloseStatus.NormalClosure, "Done", CancellationToken.None);
    }
}


*/

-->




























# Dispose Pattern

```csharp
class CoinbaseService : IDisposable
{
    private readonly HttpClient _httpClient;
    private bool _disposed = false;

    public CoinbaseService()
    {
        _httpClient = new HttpClient();
    }

    public async Task<string> GetCurrenciesAsync()
    {
        if (_disposed)
            throw new ObjectDisposedException(nameof(CoinbaseService));

        var response = await _httpClient.GetAsync("https://www.coinbase.com/api/v2/currencies");

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync();
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (_disposed)
            return;

        if (disposing)
        {
            _httpClient?.Dispose();
        }

        _disposed = true;
    }
}
```
```csharp
class Program
{
    static async Task Main()
    {
        using (var service = new CoinbaseService())
        {
            string result = await service.GetCurrenciesAsync();
            Console.WriteLine(result);
        }
    }
}
```
















#
#
#
#
#
#
#

# Middleware

- [ASP.NET Core Middleware](https://learn.microsoft.com/en-us/aspnet/core/fundamentals/middleware)
    - [RunExtensions.Run](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.builder.runextensions.run)
    - [UseExtensions.Use](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.builder.useextensions.use)
    - [MapExtensions.Map](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.builder.mapextensions.map)
- [Middleware in Minimal API apps](https://learn.microsoft.com/en-us/aspnet/core/fundamentals/minimal-apis/middleware)
- [Write custom middleware](https://learn.microsoft.com/en-us/aspnet/core/fundamentals/middleware/write)





































<!--

- [gRPC - wikipedia](https://en.wikipedia.org/wiki/GRPC)
- [WebSocket - wikipedia](https://en.wikipedia.org/wiki/WebSocket)
- [Webhook - wikipedia](https://en.wikipedia.org/wiki/Webhook)

-->








































<!--

https://www.youtube.com/watch?v=zDDnt1Ez2hc&list=PL3ZHxqs6YGONxc_pOWcGX2cON3swIzrup [ ITI signalR ]

https://learn.microsoft.com/en-us/aspnet/core/fundamentals/websockets
https://developer.mozilla.org/en-US/docs/Web/API/WebSockets_API/Writing_WebSocket_server
https://claude.ai/chat/6a55929e-a733-44c4-9cc1-95533a19c3dd
https://en.wikipedia.org/wiki/WebSocket
https://www.youtube.com/watch?v=2Nt-ZrNP22A
https://medium.com/@hanxuyang0826/roadmap-to-backend-programming-master-real-time-data-88f3a3fa8304
https://www.youtube.com/watch?v=X_DdIXrmWOo








https://medium.com/@anoopnayak1/exploring-real-time-communication-in-web-development-short-polling-vs-long-polling-ec571f5e8af8
https://ankur-javaarch.medium.com/polling-in-software-architecture-different-types-of-polling-advantages-disadvantages-where-to-1eca6426a08d
https://developer.mozilla.org/en-US/docs/Glossary/AJAX


https://ably.com/topic/websockets#:~:text=WebSocket%20is%20a%20network%20protocol,communication%20between%20client%20and%20server.

- polling: after a 't' time, send AJAX request.
    - load a lot of requests on server, not good [ not all requests get new data ]

- Long polling [ like normal polling, but the response is sent back to client if a new data coming ]:
    - limited to the HTTP timeout.
    - in this model, the frontend request send to server and booked until new data coming, then the sever send back the response with new data and front do the same cycle.
    - but in this model the request booked at the sever until new data coming is limited because it can booked over 30 sec which is the HTTP connection timeout.

- Forever frame:
    - the bug: http send response without calculate the total length.
    - there a vulnerability in http called 'chunked encoding'.
    - https://bunny.net/academy/http/what-is-chunked-encoding/
    - https://www.ioriver.io/terms/http-chunked-encoding
    - in this model, the server still work and if a new data coming, it send as chunks.
    - browser default is wait all chunks to create the response, so you need to change the client configuration.
    - server configuration also.
    - model is hard.
    - pros of the model:
        - one way 'client receive only'.

- Server sent event [ HTML 5 Feature ]:
    - server is publisher
    - client subscribe events
    - this model, work on all browsers but not the microsoft browsers 'IIS'.

- all the prev depend on HTTP but why we don't create a new protocol [ called WebSocket ].

- WebSocket ==> depend on TCP, with full-duplex
- WebSocket has one problem: every tech before 2012 not support it.
    - in client:
        - windows: after 2012 [ windows 7 not supported ]
        - browser: after 2012
    - in server:
        - OS
        - .NET framework after 4.8
        - IIS after 8



----------------------------------
client 'JS client, PY client, ...'
----------------------------------
    Proxy files 'between hub and client'
----------------------------------
hub layer 'C# as service' [ service ==> REST, SOAP ]
----------------------------------
negotiate layer 'connection layer'
----------------------------------

signalR:
    - client: consume our service.
    - server: hub and connection layer.




Steps to define the client:
    - define the connection [ where the service 'if the same project, we dont write URL, otherwise we write URL' ]
    - create Proxy
    - start the connection [ choose the suitable method to connect from the previous ways ]
    - calling the sevice method
    - define subscribe callback method

- SignalR

https://www.youtube.com/watch?v=Vf0ETZOGUQE&list=PLesfn4TAj57WLtiWtHP1Xkel7WD6QHvpe&index=2
https://learn.microsoft.com/en-us/aspnet/signalr/
https://learn.microsoft.com/en-us/aspnet/core/signalr/introduction?view=aspnetcore-9.0#transports

See the Namespace for SignalR.

https://developer.mozilla.org/en-US/docs/Web/API/WebSockets_API#related_http_headers

https://learn.microsoft.com/en-us/aspnet/core/security/cors?view=aspnetcore-9.0
https://learn.microsoft.com/en-us/aspnet/core/signalr/introduction?view=aspnetcore-9.0
https://learn.microsoft.com/en-us/aspnet/signalr/overview/getting-started/introduction-to-signalr

ConnectionId

onConnect
onDisconnect


# Real-time Communication Approaches

# http based solutions:

## Polling
Polling is a technique where the client sends an AJAX request to the server every `t` seconds to check for new data.

### Pros:
- Simple to implement.
- Works with all HTTP-based systems.

### Cons:
- Creates a high load on the server due to frequent requests.
- Not all requests receive new data, leading to inefficient resource usage.

## Long Polling
Long polling is similar to normal polling, but instead of responding immediately, the server holds the request until new data is available.

### Pros:
- Reduces unnecessary requests by only responding when there is new data.
- Works with standard HTTP without requiring special configurations.

### Cons:
- Limited by HTTP connection timeouts (typically around 30 seconds).
- Still introduces some latency since a new request is needed after each response.

## Forever Frame
Forever Frame exploits a bug in HTTP where the response is sent without specifying the total content length, using chunked encoding to continuously send updates.

### Pros:
- Provides a unidirectional communication model where the client can receive continuous updates from the server.

### Cons:
- Relies on an HTTP vulnerability (chunked encoding) that requires special client and server configurations.
- Complex to implement and maintain.
- May introduce security risks.

## Server-Sent Events (SSE)
Server-Sent Events is an HTML5 feature where the server acts as a publisher and the client subscribes to receive real-time updates.

### Pros:
- Efficient and simple implementation.
- Works with most modern browsers.

### Cons:
- Not supported in Microsoft browsers and IIS.
- Unidirectional (client can only receive updates, not send messages).

## WebSockets
WebSockets is a protocol that enables full-duplex communication over a single TCP connection, allowing real-time bidirectional data exchange.

### Pros:
- More efficient than HTTP-based approaches.
- Reduces latency due to persistent connections.
- Enables true real-time bidirectional communication.

### Cons:
- Not supported in older technologies (pre-2012 systems, Windows 7, older browsers, .NET Framework < 4.8, IIS < 8).
- Requires additional server configurations.

-->



<!-- What is Polling? (AJAX apps) -->
<!-- What is Long Polling? -->






















#
#
#
#
#
#
#






<!--

https://www.youtube.com/watch?v=Yw4rkaTc0f8
https://learn.microsoft.com/en-us/aspnet/core/grpc
https://learn.microsoft.com/en-us/dotnet/architecture/cloud-native/grpc
https://learn.microsoft.com/en-us/aspnet/core/tutorials/grpc/grpc-start

https://en.wikipedia.org/wiki/GRPC

https://www.youtube.com/watch?v=gnchfOojMk4 [ gRPC ]
https://www.youtube.com/watch?v=baPfCdRNLrI
https://www.youtube.com/watch?v=sDmwWzRAOI8
https://www.youtube.com/watch?v=K4_cgtAe4HM
https://www.youtube.com/watch?v=QyxCX2GYHxk&t=151s
https://claude.ai/chat/798fa972-9987-4460-8616-8c4551c5965c
https://medium.com/@ma9458596/rest-who-grpc-just-stole-the-spotlight-8776b4faebd7

unit testing, integration testing
CI/CD

-->

<!--

DNS: Resolving hostnames to IP

Load balancers(Round-robin, least connections, Sticky sessions)

https://www.youtube.com/watch?v=LQuuoHTyYz8
https://www.youtube.com/watch?v=dBmxNsS3BGE
https://www.youtube.com/watch?v=MuR3y6uILMk&t=157s
https://www.youtube.com/watch?v=NiQTs9DbtW4&t=104s

Reverse Proxy
Nginx
Load Balancer
Sticky Sessions
Horizontal Scaling vs Vertical Scaling
How large systems handle millions of traffic

Service Discovery
API Gateway
Internal Communication
gRPC vs REST
Kubernetes Networking

Certificate Pinning
JWT Signatures
CSRF
CORS
Rate Limiting
DDOS basics

https://www.youtube.com/watch?v=4NB0NDtOwIQ

https://teachcomputerscience.com/simplex-half-duplex-full-duplex

-->

<!--

Request/response cycle
CORS
Proxy & Reverse Proxy (Nginx, Traefik)
Load Balancers: L4 vs L7 (IMPORTANT)

Service discovery (Consul, Eureka)
Message queues vs HTTP (Kafka, RabbitMQ)
Circuit breakers & retry logic

VPC (Virtual Private Cloud)
Security groups & firewalls
API gateways
Ingress vs Egress traffic
VPN basics
DNS in cloud (Route53, Azure DNS, etc.)

-->













<!--

// =========================================================
// Roadmap:
// ========
// https://codewitharyan.com/tech-blogs/lld-crash-course
// =========================================================
// Threads - Thread class and Runnable Interface
// Thread Executors
// Thread Synchronization
// Locks and Types of Locks
// Semaphore
// Java Concurrent Collections

// Design Bounded Blocking Queue
// Multithreaded Web Crawler
// =========================================================

-->









#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#




<!--

Hands-on Experience With:
Microservices architecture
Distributed systems
Monolithic architecture
Event-driven architecture

Database & Messaging:
Writing advanced SQL queries
Working with NoSQL databases
DBMS like PostgreSQL & MySQL
Search engines (Elasticsearch)
Message brokers (RabbitMQ or Kafka)

Backend Technologies:
WebSockets
Security & Authentication (JWT, OAuth2, SAML)
Performance monitoring & error tracking

DevOps & Cloud (Bonus):
Redis caching
API documentation (Swagger)

-->



==> Here all NuGet Packages installed ==> C:\Users\hp\.nuget\packages


https://nginx.org
https://www.digitalocean.com/community/tutorials/apache-vs-nginx-practical-considerations
https://medium.com/@NeotericEU/single-page-application-vs-multiple-page-application-2591588efe58
https://cleancommit.io/blog/spa-vs-mpa-which-is-the-king/
https://www.youtube.com/watch?v=xX9m1393XXo

- what is Database Journal.






































# Entity Framework Core (EF Core)

- [Overview of Entity Framework Core - microsoft](https://learn.microsoft.com/en-us/ef/core)
    - [Installing Entity Framework Core - microsoft](https://learn.microsoft.com/en-us/ef/core/get-started/overview/install)
- [Getting Started with EF Core - microsoft](https://learn.microsoft.com/en-us/ef/core/get-started/overview/first-app)
- [DbContext Lifetime, Configuration, and Initialization - microsoft](https://learn.microsoft.com/en-us/ef/core/dbcontext-configuration)
    - [Context Pooling - microsoft](https://learn.microsoft.com/en-us/ef/core/performance/advanced-performance-topics)
- [Creating and Configuring a Model - microsoft](https://learn.microsoft.com/en-us/ef/core/modeling)
    - [Entity Types - microsoft](https://learn.microsoft.com/en-us/ef/core/modeling/entity-types)
    - [Owned Entity Types - microsoft](https://learn.microsoft.com/en-us/ef/core/modeling/owned-entities)
    - [Keyless Entity Types - microsoft](https://learn.microsoft.com/en-us/ef/core/modeling/keyless-entity-types)
    - [Entity Properties - microsoft](https://learn.microsoft.com/en-us/ef/core/modeling/entity-properties)
    - [Keys - microsoft](https://learn.microsoft.com/en-us/ef/core/modeling/keys)
    - [Generated Values - microsoft](https://learn.microsoft.com/en-us/ef/core/modeling/generated-properties)
    - [Overview of Relationships - microsoft](https://learn.microsoft.com/en-us/ef/core/modeling/relationships)
        - [One-to-one Relationships - microsoft](https://learn.microsoft.com/en-us/ef/core/modeling/relationships/one-to-one)
        - [One-to-many Relationships - microsoft](https://learn.microsoft.com/en-us/ef/core/modeling/relationships/one-to-many)
        - [Many-to-many Relationships - microsoft](https://learn.microsoft.com/en-us/ef/core/modeling/relationships/many-to-many)
    - [Foreign and Principal Keys - microsoft](https://learn.microsoft.com/en-us/ef/core/modeling/relationships/foreign-and-principal-keys)
    - [Relationship Navigations - microsoft](https://learn.microsoft.com/en-us/ef/core/modeling/relationships/navigations)
    - [Mapping Attributes - microsoft](https://learn.microsoft.com/en-us/ef/core/modeling/relationships/mapping-attributes)
- [Migrations Overview - microsoft](https://learn.microsoft.com/en-us/ef/core/managing-schemas/migrations)
- [Scaffolding (Reverse Engineering) - microsoft](https://learn.microsoft.com/en-us/ef/core/managing-schemas/scaffolding)
- [Overview of Querying Data - microsoft](https://learn.microsoft.com/en-us/ef/core/querying)
    - [Tracking vs. No-Tracking Queries - microsoft](https://learn.microsoft.com/en-us/ef/core/querying/tracking)
    - [Loading Related Data - microsoft](https://learn.microsoft.com/en-us/ef/core/querying/related-data)
        - [Eager Loading - microsoft](https://learn.microsoft.com/en-us/ef/core/querying/related-data/eager)
            - [Split Queries - youtube](https://www.youtube.com/watch?v=43hr80ldoGc)
            - [Single vs. Split Queries - microsoft](https://learn.microsoft.com/en-us/ef/core/querying/single-split-queries)
        - [Explicit Loading - microsoft](https://learn.microsoft.com/en-us/ef/core/querying/related-data/explicit)
        - [Lazy Loading - microsoft](https://learn.microsoft.com/en-us/ef/core/querying/related-data/lazy)
    - [Pagination - microsoft](https://learn.microsoft.com/en-us/ef/core/querying/pagination)
    - [SQL Queries - microsoft](https://learn.microsoft.com/en-us/ef/core/querying/sql-queries)
    - [Global Query Filters - microsoft](https://learn.microsoft.com/en-us/ef/core/querying/filters)
    - [How Queries Work - microsoft](https://learn.microsoft.com/en-us/ef/core/querying/how-query-works)
- [Transactions - microsoft](https://learn.microsoft.com/en-us/ef/core/saving/transactions)


- [Overview of ASP.NET Core MVC](https://learn.microsoft.com/en-us/aspnet/core/mvc/overview)
    - [Getting Started with ASP.NET Core MVC - microsoft](https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/start-mvc)
    - [Add a controller - microsoft](https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/adding-controller)
    - [Add a view - microsoft](https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/adding-view)
    - [Add a model - microsoft](https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/adding-model)
    - [Work with a database - microsoft](https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/working-with-sql)
    - [Controller actions and views - microsoft](https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/controller-methods-views)
    - [Add search - microsoft](https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/search)
    - [Add a new field - microsoft](https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/new-field)
    - [Add validation - microsoft](https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/validation)
    - [Examine Details and Delete - microsoft](https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/details)
- [Create a controller-based web API - microsoft](https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-web-api)
- [Make HTTP requests - microsoft](https://learn.microsoft.com/en-us/aspnet/core/fundamentals/http-requests)

#

<!--

https://learn.microsoft.com/en-us/aspnet/core/tutorials/signalr
https://learn.microsoft.com/en-us/aspnet/core/tutorials/grpc/grpc-start

> ASP.NET core provides built-in support for file uploads via the ‹IFormFile› interface, enabling secure and efficient handling of files in HTTP requests.
    > For more information, check the following link ‹ https://learn.microsoft.com/en-us/aspnet/core/mvc/models/file-uploads ›.

https://learn.microsoft.com/en-us/aspnet/core/mvc/controllers/filters
https://learn.microsoft.com/en-us/aspnet/core/mvc/models/model-binding
https://learn.microsoft.com/en-us/aspnet/core/mvc/models/validation
https://learn.microsoft.com/en-us/aspnet/core/mvc/controllers/routing

The Security Guide:
-------------------
> The Security Description: is a collection of features designed to ensure authentication, authorization, data protection, and safeguard against security vulnerabilities.
> The Security Topics:
    > ASP.NET core offers built-in support for identity management and authentication through rich namespaces and classes, simplifying security and user management.
        > For more information, check the following link ‹ https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.identity ›.
        > For more information, check the following link ‹ https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.identity.entityframeworkcore ›.
        > For more information, check the following link ‹ https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.authentication.jwtbearer ›.
        > For more information, check the following link ‹ https://learn.microsoft.com/en-us/dotnet/api/system.identitymodel.tokens.jwt ›.
    > ASP.NET core offers flexible authentication mechanisms, including cookie-based authentication and token-based authentication, each suited for different security needs.
        > For more information, check the following link ‹ https://auth0.com/blog/cookies-tokens-jwt-the-aspnet-core-identity-dilemma ›.
    > ASP.NET core identity manages users, roles, and related data through a customizable database schema, enabling flexible and extensible authentication and authorization.
        > For more information, check the following link ‹ https://learn.microsoft.com/en-us/aspnet/core/security/authentication/customize-identity-model ›.

https://learn.microsoft.com/en-us/aspnet/core/security/authorization/simple
https://learn.microsoft.com/en-us/aspnet/core/security/authorization/roles

https://learn.microsoft.com/en-us/aspnet/core/security/authentication/identity-custom-storage-providers

https://learn.microsoft.com/en-us/dotnet/api/system.security.claims

> Before diving into token-based authentication, it is essential to understand the structure of JWTs, as they play a key role in authentication and authorization security.
    > For more information, check the following link ‹ https://jwt.io/introduction ›.
> ASP.NET core identity supports token-based authentication for secure, stateless user login, logout, and access control using JWTs, enabling role-based authorization.
    > For more information, check the following link ‹ https://learn.microsoft.com/en-us/aspnet/core/security/authentication/configure-jwt-bearer-authentication ›.
    > For more information, check the following link ‹ https://medium.com/@KumarHalder/token-based-authentication-in-asp-net-core-43e99aee0593 ›.

https://auth0.com/blog/refresh-tokens-what-are-they-and-when-to-use-them/ [ Read it about Refresh Tokens. ]

https://learn.microsoft.com/en-us/aspnet/core/security/authentication/identity-configuration

NOTE: when you try to fetch the api from outside the project, the server or provider must be [ app.UseCORS("MyPolicy") ].
    - CORS occur:
        - if two domain are connect
        - if two same domain but different protocols

- to create 'MyPolicy':
    - builder.Services.AddCors(corsOptions => {
        corsOptions.AddPolicy("MyPolicy", corsPolicyBuilder => {
            corsPolicyBuilder.withOrigins("www.iti.gow")
        })
    });

- you can use corsPolicyBuilder.AllowAnyOrigin();
- you can use corsPolicyBuilder.AllowAnyOrigin().WithMethod("Get")
- you can use corsPolicyBuilder.AllowAnyOrigin().AllowAnyMethod()
- you can use corsPolicyBuilder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader()

> The Service layer in ASP.NET core centralizes business logic, streamlines data flow, and connects controllers to repositories, ensuring a clean and scalable architecture.
    > For more information, check the following link ‹ https://tinyurl.com/rem92ypc ›.

https://manage.auth0.com/dashboard/us/dev-h717s2gsbzmvo143/
https://auth0.com/docs/quickstart/backend/aspnet-core-webapi/interactive
https://auth0.com/docs/api/authentication/introduction

https://learn.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore ( DbContext, DbSet )
https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.http?view=aspnetcore-9.0 ( HttpContext )
https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.builder.webapplication
https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.builder.webapplicationbuilder
https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc ( Controller, ControllerBase )

https://app.exchangerate-api.com/dashboard/confirmed
https://v6.exchangerate-api.com/v6/1049f322f3e95dabb395d31c/latest/USD
https://v6.exchangerate-api.com/v6/1049f322f3e95dabb395d31c/pair/USD/EGp

-->



















#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#















Tic Tac Toe Game ==> done (State & Strategy)
Snake & Food Game ==> done (State & Factory)
Design Parking Lot
Design Car Rental System
Design File System










https://learn.microsoft.com/en-us/aspnet/core/overview



In Program.cs or Startup.cs
builder.Services.AddSingleton<AppContext>();

inversion of Control 'IoC': is a principal design that allows classes to be loosely coupled and therefore, easier to test and maintain [ not creation of class inside another class ].
    - IoC: refers to transferring the control of objects and their dependencies from the main program to a container or framework.
    - IoC: is a principal, not a design Pattern.
    ---- benefits:
        - reduce the code amount.
        - decrease coupling between classes.
        - make the application easier to test and maintain.

- IoC Patterns:
    - Service Locater
    - Factory
    - Template method
    - abstract Factory
    - Strategy
    - Dependency Injection: in our model

steps:
======
tightly coupled classes ===> implement IoC using Factory Pattern 'built-in class' ===> implement DIP 'Dependency Inversion Principle' by creating abstractions ===> implement DI 'dependency injection' ===> use IoC container 'remove any new keyword' ===>

injection types:
    - constructor [ .NET core default ]
    - property
    - method parameter

- Controller Factory: is responsible for create an object from the parameter in injection by asking thing called 'IoC Container'.




https://www.youtube.com/watch?v=M-l7gVm69KI
https://blog.logrocket.com/what-is-railway-oriented-programming
https://en.wikipedia.org/wiki/Inversion_of_control
https://en.wikipedia.org/wiki/Unit_of_work





<!--

My .NET Conferences I lived with:
- https://www.dotnetconf.net [ 2025 ]

-->