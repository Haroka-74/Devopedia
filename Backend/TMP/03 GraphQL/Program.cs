using _03_GraphQL.Data;
using _03_GraphQL.Mapping;
using _03_GraphQL.GraphQL;
using _03_GraphQL.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ProductDbContext>(options =>
{
    options.UseInMemoryDatabase("Products");
});
builder.Services.AddAutoMapper(typeof(ProductProfile));
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddGraphQLServer().AddQueryType<Query>().AddMutationType<Mutation>();

var app = builder.Build();

app.MapGraphQL();

app.Run();