<div style = "font-family: 'Roboto', sans-serif;">

# What is Virtualization?

- Traditional virtualization deals with resources that were normally bound to hardware. It can distribute a machine’s capacity among many users or environments.
- Virtualization began in the 1960s as a technology for time-sharing on mainframe computers. Virtualization as we know it today gained popularity in the 2000s as organizations looked for ways to make the most of their computing resources and optimize access to expensive hardware.
- Types of virtualization include:
    - **<ins>Data virtualization</ins>**, which lets you consolidate data sources into a single dynamic supply.
    - **<ins>Desktop virtualization</ins>**, which allows multiple simulated desktop environments to be deployed and controlled through a central administrator.
    - **<ins>Server virtualization</ins>**, which lets administrators partition servers into configurations meant to serve specific functions.
    - **<ins>OS virtualization</ins>**, which makes it possible to run multiple OSs on a single computer.
    - **<ins>Network functions virtualization</ins>**, which separates a network's functions (like directory services, file sharing, and IP configuration) so they can be distributed among environments.

# What is a Virtual Machine (VM)?

- A virtual machine is an isolated computing environment with its own CPU, memory, network interface, and storage, created from a pool of hardware resources.
- **Virtualization**, the concept behind VMs, makes it possible for a single computer to act like many different computers at the same time. VMs can emulate endless arrangements of operating systems (OSs) on the same physical hardware to help companies reduce costs, streamline operations, and gain more value from existing infrastructure.

# How does a VM work?

- The physical machine that runs the VMs is called the <ins>host machine</ins>, <ins>host computer</ins>, <ins>host OS</ins>, or simply <ins>host</ins>. The VMs that use its resources are <ins>guest machines</ins>, <ins>guest computers</ins>, <ins>guest OSs</ins>, or <ins>guests</ins>.
- Software called a **Hypervisor** isolates the necessary computing resources and allows the creation and management of VMs. The hypervisor treats compute resources—like CPU, memory, and storage—as a pool of resources that can easily be relocated between existing guests or to new VMs.
- You can define a VM as a single data file and run it the same way on different computers. When the VM needs additional resources while running, the hypervisor allocates and schedules access to the physical hardware, allowing the VM’s OS and applications to use the shared pool of system resources.

# What is a Hypervisor?

- A hypervisor is software that pools computing resources—like processing, memory, and storage—and reallocates them among virtual machines (VMs). This technology makes virtualization possible, meaning you can create and run many VMs from a single physical machine.
- A hypervisor is sometimes called a virtual machine monitor (VMM). Think of it as the supervisor in charge of dispersing the components that make up VMs. A hypervisor takes these resources from physical hardware and supplies them to multiple VMs at once, allowing the creation of new VMs and the management of existing ones.
- Types of hypervisors include:
    - **<ins>Type 1</ins>**, which runs directly on the host’s hardware to manage guest operating systems. It takes the place of a host operating system and VM resources are scheduled directly to the hardware by the hypervisor. This type of hypervisor is most common in enterprise data centers or other server-based environments. Examples include `KVM`, `Microsoft Hyper-V`, and `VMware vSphere`.
    - **<ins>Type 2</ins>**, which is run on a conventional operating system as a software layer or application. It abstracts guest operating systems from the host operating system, scheduling VM resources against the host OS before executing them on the hardware. This type is better for individual users who want to run multiple operating systems on a personal computer. Examples include `VMware Workstation` and `Oracle VirtualBox`.

# What is a Virtual Machine Image?

- A Virtual Machine Image (VMI) is a file that encapsulates the entire state of a virtual machine at a given point in time. This includes the operating system, applications, data, and configurations. VMIs are used to create and replicate virtual machines, ensuring consistency and reliability across different environments.
- A Virtual Machine Image is a critical component in virtualization technology, allowing users to create consistent and portable computing environments. VMIs enable rapid deployment, scaling, and migration of virtual machines across various infrastructures, from local data centers to cloud environments. By encapsulating the entire state of a virtual machine, VMIs simplify the process of backup, recovery, and distribution of virtualized systems.

# What is Containerization?

- Containerization is the packaging together of software code with all its necessary components—like libraries, frameworks, and other dependencies—into a single, isolated unit called a **container**.
- Unlike traditional virtual machines, which require a full operating system, containers share the **<ins>host OS kernel</ins>**, making them lightweight, fast, and efficient.
- The container acts as a self-contained computing environment, surrounding the application and keeping it independent of its surroundings. This ensures that the software can run consistently across any environment or infrastructure, whether on-premises, in the cloud, or in hybrid setups, without compatibility issues.
- Containers achieve isolation and resource control using kernel features such as namespaces (to separate processes, networking, and file systems) and control groups (cgroups) to limit CPU, memory, and I/O usage.
- By packaging an application in a container, developers can avoid environment-specific bugs, reduce deployment friction, and improve productivity. **<ins>Docker Engine</ins>**, introduced in 2013, standardized container usage with easy-to-use tools, making containerization a cornerstone of modern cloud-native applications, enabling portability, scalability, rapid deployment, and efficient resource utilization.

# Virtualization vs. Containerization

- Virtualization uses software called a hypervisor to separate resources from their physical machines, allowing them to be partitioned and dedicated to virtual machines (VMs).
- When a user issues a VM instruction that requires additional resources, the hypervisor relays the request to the physical system and caches the changes.
- VMs behave like physical servers, which can lead to larger OS footprints and unnecessary application dependencies, even if only a single app or microservice is running.
- Containerization packages everything within a container using a container image, a file that includes all necessary libraries and dependencies.
- Container images are similar to software installation packages but only require a compatible kernel and container runtime to run, regardless of the OS used to create them or where the libraries came from.
- Containers are lightweight, can be deployed in large numbers, and are typically managed by orchestration platforms like **Kubernetes** or **Red Hat OpenShift** for efficient scaling, provisioning, and operation.

# Docker

- [What is Docker?](https://docs.docker.com/get-started/docker-overview)
    - [Reference](https://docs.docker.com/reference/cli/docker)
- [Docker vs. containerd](https://www.docker.com/blog/containerd-vs-docker)
- [What is a Registry?](https://docs.docker.com/get-started/docker-concepts/the-basics/what-is-a-registry)
- [Storage](https://docs.docker.com/engine/storage)
- [Networking](https://docs.docker.com/engine/network)
- [Dockerfile](https://docs.docker.com/reference/dockerfile)
- [Docker Compose](https://docs.docker.com/compose)
    - [Reference](https://docs.docker.com/reference/compose-file)

# Fedora in Docker

- Pull the latest Fedora image from Docker Hub and verify the download:
```powershell
docker image pull fedora:latest
```
```powershell
docker image ls
```
- Create and start an interactive Fedora container with a custom hostname:
```powershell
docker container create -it --name fedora-dev --hostname Haroka fedora bash
```
```powershell
docker container start -i fedora-dev
```
- Clean up by removing the container and image:
```powershell
docker container rm fedora-dev
```
```powershell
docker image rm fedora
```

# PostgreSQL in Docker

- Pull the latest [PostgreSQL](https://hub.docker.com/_/postgres) image and verify the download:
```powershell
docker image pull postgres:latest
```
```powershell
docker image ls
```
- Create a Docker volume to persist PostgreSQL data and inspect its local `Mountpoint` path:
```powershell
docker volume create pgdata
```
```powershell
docker volume inspect pgdata
```
- Run a PostgreSQL container with user credentials and attach the volume for data persistence:
```powershell
docker run -d `
    --name postgres-dev `
    -e POSTGRES_USER=Haroka `
    -e POSTGRES_PASSWORD=H123 `
    --volume pgdata:/var/lib/postgresql/18/docker `
    postgres
```
- Access the PostgreSQL interactive shell:
```powershell
docker exec -it postgres-dev psql -U Haroka -d postgres
```
- In the container (psql shell), run SQL commands to verify database functionality:
```sql
CREATE TABLE students (
    id SERIAL PRIMARY KEY,
    username VARCHAR(50),
    age INTEGER
);
```
```sql
INSERT INTO students (username, age) VALUES ('Ali', 21);
INSERT INTO students (username, age) VALUES ('Sara', 22);
INSERT INTO students (username, age) VALUES ('Mohamed', 23);
```
```sql
SELECT * FROM students;
```
- Stop and remove the PostgreSQL container:
```powershell
docker container stop postgres-dev
```
```powershell
docker container rm postgres-dev
```
- Run a new PostgreSQL container using the same volume to restore the previous data:
```powershell
docker run -d `
    --name postgres-dev `
    -e POSTGRES_USER=Haroka `
    -e POSTGRES_PASSWORD=H123 `
    --volume pgdata:/var/lib/postgresql/18/docker `
    postgres
```
- Access the PostgreSQL interactive shell again to verify data persistence:
```powershell
docker exec -it postgres-dev psql -U Haroka -d postgres
```
- In the container (psql shell), verify that the `students` table and records still exist:
```sql
SELECT * FROM students;
```
- Stop the PostgreSQL container when finished:
```powershell
docker container stop postgres-dev
```

# ASP.NET Core Minimal API (Without Dockerfile)

- Pull the official .NET SDK image (version 8.0) and verify the download:
```powershell
docker image pull mcr.microsoft.com/dotnet/sdk:8.0
```
```powershell
docker image ls
```
- Create an interactive .NET container:
```powershell
docker container create -it --name dotnet-dev --hostname Haroka mcr.microsoft.com/dotnet/sdk:8.0 bash
```
- Create a new ASP.NET Core web project (Minimal API):
```powershell
dotnet new web -o App -f net8.0
```
- Open `App/Program.cs` and replace its content with the following:
```csharp
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.MapGet("/", () => "Hello from containers!");

app.Run();
```
- Copy the project into the container:
```powershell
docker container cp ./App dotnet-dev:/App
```
- Start the container interactively:
```powershell
docker container start -i dotnet-dev
```
- In the container, navigate to the project directory and install the Swagger NuGet package:
```powershell
cd App
```
```powershell
dotnet add package Swashbuckle.AspNetCore
```
```powershell
exit
```
- Create a new Docker image from the configured container and verify it's available:
```powershell
docker commit dotnet-dev haroka1337/api:v1.0
```
```powershell
docker image ls
```
- Remove the old container:
```powershell
docker container rm dotnet-dev
```
- Run a new container from the saved image:
```powershell
docker run -d `
    --name dotnet-dev `
    -p 8080:5227 `
    haroka1337/api:v1.0 `
    dotnet run `
        --urls http://0.0.0.0:5227 `
        --project /App/App.csproj
```
- Stop the container when finished:
```powershell
docker container stop dotnet-dev
```

# ASP.NET Core Minimal API (With Dockerfile)

- Create a new directory named `Project` and navigate into it:
```powershell
mkdir Project
```
```powershell
cd Project
```
- Create a new ASP.NET Core web project (Minimal API):
```powershell
dotnet new web -o App -f net8.0
```
- Navigate into the `App` directory and install the Swagger NuGet package:
```powershell
cd App
```
```powershell
dotnet add package Swashbuckle.AspNetCore
```
```powershell
cd ..
```
- Open `App/Program.cs` and replace its content with the following:
```csharp
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.MapGet("/", () => "Hello from containers!");

app.Run();
```
- Create a `.dockerignore` file in the project root and add the following content:
```dockerignore
**/bin/
**/obj/
**/.vs/
**/.vscode/
**/.idea/

.git/
.gitignore
.gitattributes

**/Dockerfile*
**/docker-compose*
.dockerignore
```
- Create a `Dockerfile` in the project root and add the following content:
```dockerfile
# ---------------------------------- Build ---------------------------------- #
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

COPY ["App/App.csproj", "App/"]
# This layer will be cached and reused if 'App.csproj' hasn't changed
RUN dotnet restore "App/App.csproj"

COPY . .
WORKDIR "/src/App"

# Build the application in Release configuration
# Output goes to /App/build (absolute path, not affected by WORKDIR)
RUN dotnet build "App.csproj" -c Release -o /App/build
# --------------------------------------------------------------------------- #

# --------------------------------- Publish --------------------------------- #
# Start from the build stage to reuse everything we've already built
FROM build AS publish
RUN dotnet publish "App.csproj" -c Release -o /App/publish /p:UseAppHost=false
# --------------------------------------------------------------------------- #

# --------------------------------- Runtime --------------------------------- #
# Use the lightweight ASP.NET runtime image (contains only runtime, not SDK)
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /App

# Copy the published application from the publish stage
# Only the deployment-ready files are included in the final image
COPY --from=publish /App/publish .

EXPOSE 8080

ENTRYPOINT ["dotnet", "App.dll"]
# --------------------------------------------------------------------------- #
```
- Build the Docker image from the `Dockerfile`:
```powershell
docker build -t haroka1337/api:v1.1 .
```
- Run a new container from the built image:
```powershell
docker run -d -p 8080:8080 --name dotnet-dev haroka1337/api:v1.1
```
- Stop the container when finished:
```powershell
docker container stop dotnet-dev
```

# NGINX in Docker

- Create a new directory named `Project` and navigate into it:
```powershell
mkdir Project
```
```powershell
cd Project
```
- Create a new file at `app/index.html` and add the following content:
```html
<!DOCTYPE html>
<html lang = "en">
<head>
    <meta charset = "UTF-8">
    <title> NGINX </title>
</head>
<body>
    <h1 style = "text-align: center;">
        Hello from <span style = "color: green;"> NGINX </span> container!
    </h1>
</body>
</html>
```
- Create a `Dockerfile` in the project root and add the following content:
```dockerfile
FROM nginx:alpine

WORKDIR /usr/share/nginx/html

RUN rm -rf ./*

COPY ./app/* .

EXPOSE 80
```
- Build the Docker image from the `Dockerfile`:
```powershell
docker build -t haroka1337/nginx:v1.0 .
```
- Run a new container from the built image:
```powershell
docker run -d -p 8080:80 --name nginx-dev haroka1337/nginx:v1.0
```
- Stop the container when finished:
```powershell
docker container stop nginx-dev
```

# Database Scaffolding in Docker

- Pull the latest [Microsoft SQL Server](https://hub.docker.com/r/microsoft/mssql-server) image and verify the download:
```powershell
docker image pull mcr.microsoft.com/mssql/server:2022-latest
```
```powershell
docker image ls
```
- Run a Microsoft SQL Server container with required environment variables and expose the default SQL Server port:
```powershell
docker run -d `
    --name mssql-dev `
    -e ACCEPT_EULA=Y `
    -e MSSQL_SA_PASSWORD=Haroka%123$ `
    -p 1433:1433 `
    mcr.microsoft.com/mssql/server:2022-latest
```
- Access the Microsoft SQL Server interactive shell:
```powershell
docker exec -it mssql-dev /opt/mssql-tools18/bin/sqlcmd -S localhost -U SA -P Haroka%123$ -C
```
- In the container (sqlcmd shell), run SQL commands to create a test database structure:
```sql
CREATE TABLE students (
    id INT IDENTITY(1, 1) PRIMARY KEY,
    username NVARCHAR(50),
    age INT
);
GO
```
```sql
INSERT INTO students (username, age) VALUES ('Ali', 21);
INSERT INTO students (username, age) VALUES ('Sara', 22);
INSERT INTO students (username, age) VALUES ('Mohamed', 23);
GO
```
```sql
SELECT * FROM students;
GO
```
- Create a new directory named `Project` and navigate into it:
```powershell
mkdir Project
```
```powershell
cd Project
```
- Create a new ASP.NET Core console application:
```powershell
dotnet new console -o App -f net8.0
```
- Navigate into the `App` directory and install the required NuGet packages:
```powershell
cd App
```
```powershell
dotnet add package Microsoft.EntityFrameworkCore.Tools
```
```powershell
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
```
- Scaffold the database to generate the DbContext and entity models:
```powershell
$CONN = "Server=localhost,1433;Database=master;User Id=SA;Password=Haroka%123$;TrustServerCertificate=True"
```
```powershell
dotnet ef dbcontext scaffold "$CONN" `
    Microsoft.EntityFrameworkCore.SqlServer `
    --output-dir Models `
    --context AppDbContext
```
- Create a `.dockerignore` file in the project root and add the following content:
```dockerignore
**/bin/
**/obj/
**/.vs/
**/.vscode/
**/.idea/

.git/
.gitignore
.gitattributes

**/Dockerfile*
**/docker-compose*
.dockerignore
```
- Create a `Dockerfile` in the project root and add the following content:
```dockerfile
# ---------------------------------- Build ---------------------------------- #
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

WORKDIR /src

COPY ["App/App.csproj", "App/"]

RUN dotnet restore "App/App.csproj"

COPY . .

WORKDIR "/src/App"

RUN dotnet build "App.csproj" -c Release -o /App/build
# --------------------------------------------------------------------------- #

# --------------------------------- Publish --------------------------------- #
FROM build AS publish
RUN dotnet publish "App.csproj" -c Release -o /App/publish /p:UseAppHost=false
# --------------------------------------------------------------------------- #

# --------------------------------- Runtime --------------------------------- #
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime

WORKDIR /App

COPY --from=publish /App/publish .

ENTRYPOINT ["dotnet", "App.dll"]
# --------------------------------------------------------------------------- #
```
- Open `App/Program.cs` and replace its content with the following:
```csharp
using App.Models;

using var context = new AppDbContext();

foreach(var student in context.Students.ToList())
{
    Console.WriteLine($"student({student.Id}, {student.Username}, {student.Age})");
}
```
- Update the connection string in the `OnConfiguring` method inside `AppDbContext` to use the container name instead of `localhost` (for Docker's internal network communication):
```csharp
protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
{
    optionsBuilder.UseSqlServer(
        "Server=mssql-dev;Database=master;User Id=SA;Password=Haroka%123$;TrustServerCertificate=True"
    );
}
```
- Create a dedicated Docker network to allow inter-container communication:
```powershell
docker network create -d bridge app-net
```
- Move the SQL Server container to the new network for isolated internal communication:
```powershell
docker network disconnect bridge mssql-dev
```
```powershell
docker network connect app-net mssql-dev
```
- Build the Docker image from the `Dockerfile`:
```powershell
docker build -t haroka1337/scaffolding:v1.0 .
```
- Run a container from the built image on the `app-net` network to communicate with the SQL Server container:
```powershell
docker run --rm --name dotnet-dev --network app-net haroka1337/scaffolding:v1.0
```

# Full-Stack Web Application in Docker

- Create the project structure with separate directories for client and server:
```powershell
mkdir Project
```
```powershell
cd Project
```
```powershell
mkdir server
```
```powershell
mkdir client
```
- Navigate into the server directory and create a new Minimal API project:
```powershell
cd server
```
```powershell
dotnet new web -o App -f net8.0
```
- Navigate into the `App` directory and install the required NuGet packages:
```powershell
cd App
```
```powershell
dotnet add package Swashbuckle.AspNetCore
```
```powershell
dotnet add package Microsoft.EntityFrameworkCore.Tools
```
```powershell
dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL
```
- Create `Models/Product.cs` and add the following content:
```csharp
namespace App.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
    }
}
```
- Create `Data/AppDbContext.cs` and add the following content:
```csharp
using App.Models;
using Microsoft.EntityFrameworkCore;

namespace App.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}
```
- Open `Program.cs` and replace its content with the following:
```csharp
using App.Data;
using App.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
    });
});
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseNpgsql("Host=postgres-dev;Username=Haroka;Password=H123;Database=Shopify");
});
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    db.Database.Migrate();
}

app.UseSwagger();
app.UseSwaggerUI();
app.UseCors();

app.MapGet("/", (AppDbContext db) =>
{
    return Results.Ok(db.Products.ToList());
});

app.MapPost("/product/add", async (Product product, AppDbContext db) =>
{
    db.Products.Add(product);
    await db.SaveChangesAsync();
    return Results.Created($"/products/{product.Id}", product);
});

app.Run();
```
- Create and apply the initial database migration:
```powershell
dotnet ef migrations add InitialCreate
```
- Create a `.dockerignore` file in the server directory and add the following content:
```dockerignore
**/bin/
**/obj/

**/.vs/
**/.vscode/
**/.idea/

.git/
.gitignore
.gitattributes

**/Dockerfile*
**/docker-compose*
**/.dockerignore
```
- Create a `Dockerfile` in the server directory and add the following content:
```dockerfile
# ---------------------------------- Build ---------------------------------- #
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

WORKDIR /src

COPY ["App/App.csproj", "App/"]

RUN dotnet restore "App/App.csproj"

COPY . .

WORKDIR "/src/App"

RUN dotnet build "App.csproj" -c Release -o /app/build
# --------------------------------------------------------------------------- #

# --------------------------------- Publish --------------------------------- #
FROM build AS publish
RUN dotnet publish "App.csproj" -c Release -o /app/publish /p:UseAppHost=false
# --------------------------------------------------------------------------- #

# --------------------------------- Runtime --------------------------------- #
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime

WORKDIR /app

COPY --from=publish /app/publish .

EXPOSE 8080

ENTRYPOINT ["dotnet", "App.dll"]
# --------------------------------------------------------------------------- #
```
- Navigate into the client directory and create a new React project using `Vite`:
    - When prompted, name your project `app`, select `React` as the framework, and choose `JavaScript` as the variant.
```powershell
cd client
```
```powershell
npm create vite@latest
```
- Navigate into the `app` directory and install `Axios` for API communication:
```powershell
cd app
```
```powershell
npm install axios
```
- Create `src/services/productService.js` and add the following content:
```javascript
import axios from 'axios';

export const getProducts = async () => {
    const response = await axios.get('http://localhost:8080');
    return response.data;
};
```
- Open `src/App.jsx` and replace its content with the following:
```javascript
import { useEffect, useState } from 'react';
import { getProducts } from './services/productService';

const App = () => {
    const [products, setProducts] = useState([]);

    useEffect(() => {
        async function fetchProducts() {
            try {
                const data = await getProducts();
                setProducts(data);
            } catch(e) {
                console.log('Failed to fetch products: ', e);
            }
        }

        fetchProducts();
    }, [])

    return (
        <div style = {{ padding: '20px' }}>
            <h1> Shopify Products </h1>
            {products.length === 0 ? (
                <p> No products available. </p>
            ) : (
                <div style = {{ display: 'flex', flexDirection: 'column', gap: '10px' }}>
                    {products.map((p) => (
                        <div
                            key = {p.id}
                            style = {{
                                border: '1px solid #CCC',
                                borderRadius: '5px',
                                padding: '10px'
                            }}
                        >
                            <div><strong> {p.name} </strong></div>
                            <div> ${p.price.toFixed(2)} </div>
                        </div>
                    ))}
                </div>
            )}
        </div>
    );
};

export default App;
```
- Create a `.dockerignore` file in the client directory and add the following content:
```dockerignore
app/node_modules
app/npm-debug.log*
app/package-lock.json

app/build
app/dist
app/.next
app/out

.git
.gitignore
README.md

Dockerfile
Dockerfile.*
docker-compose.yml
docker-compose.yaml
.dockerignore
```
- Create a `Dockerfile` in the client directory and add the following content:
```dockerfile
# ---------------------------------- Build ---------------------------------- #
FROM node:20-alpine AS build
WORKDIR /app

COPY app/package*.json ./

RUN npm install

COPY app/ .

# Build the React application for production
# Output goes to /app/dist by default
RUN npm run build
# --------------------------------------------------------------------------- #

# --------------------------------- Runtime --------------------------------- #
FROM nginx:alpine AS runtime
WORKDIR /usr/share/nginx/html

RUN rm -rf ./*

COPY --from=build /app/dist .

EXPOSE 80

CMD ["nginx", "-g", "daemon off;"]
# --------------------------------------------------------------------------- #
```
- Navigate back to the project root and create a `docker-compose.yml` file with the following content:
```yaml
services:
  database:
    image: postgres:latest
    container_name: postgres-dev
    hostname: Haroka
    environment:
      POSTGRES_USER: Haroka
      POSTGRES_PASSWORD: H123
      POSTGRES_DB: Shopify
    networks:
      - app-net
    ports:
      - "5432:5432"

  server:
    build: ./server
    image: haroka1337/dotnet:v1.0
    container_name: dotnet-dev
    hostname: Haroka
    depends_on:
      - database
    networks:
      - app-net
    ports:
      - "8080:8080"
    restart: unless-stopped

  client:
    build: ./client
    image: haroka1337/react:v1.0
    container_name: react-dev
    depends_on:
      - server
    networks:
      - app-net
    ports:
      - "5173:80"
    restart: unless-stopped

networks:
  app-net:
    driver: bridge
```
- Build and start all services with Docker Compose:
```powershell
docker compose up -d
```

</div>