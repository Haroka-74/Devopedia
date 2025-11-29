using SoapCore;
using _01_SOAP.Data;
using _01_SOAP.Mapping;
using _01_SOAP.Services;
using _01_SOAP.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ProductDbContext>(options =>
{
    options.UseInMemoryDatabase("Products");
});
builder.Services.AddAutoMapper(typeof(ProductProfile));
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddSoapCore();

var app = builder.Build();

app.UseRouting();

app.UseSoapEndpoint<IProductService>(
    "/ProductService.asmx",
    [new()],
    SoapSerializer.XmlSerializer,
    false,
    null,
    true,
    false,
    null
);

app.Run();