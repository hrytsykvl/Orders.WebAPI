using Microsoft.EntityFrameworkCore;
using Orders.WebAPI.Entities;
using Orders.WebAPI.Repositories;
using Orders.WebAPI.RepositoryContracts;
using Orders.WebAPI.ServiceContracts.OrderItems;
using Orders.WebAPI.ServiceContracts.Orders;
using Orders.WebAPI.Services.OrderItems;
using Orders.WebAPI.Services.Orders;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
	options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});


builder.Services.AddScoped<IOrdersRepository, OrdersRepository>();
builder.Services.AddScoped<IOrderItemsRepository, OrderItemsRepository>();
builder.Services.AddScoped<IOrdersAdderService, OrdersAdderService>();
builder.Services.AddScoped<IOrdersDeleterService, OrdersDeleterService>();
builder.Services.AddScoped<IOrdersFilterService, OrdersFilterService>();
builder.Services.AddScoped<IOrdersGetterService, OrdersGetterService>();
builder.Services.AddScoped<IOrdersUpdaterService, OrdersUpdaterService>();
builder.Services.AddScoped<IOrderItemsAdderService, OrderItemsAdderService>();
builder.Services.AddScoped<IOrderItemsDeleterService, OrderItemsDeleterService>();
builder.Services.AddScoped<IOrderItemsGetterService, OrderItemsGetterService>();
builder.Services.AddScoped<IOrderItemsUpdaterService, OrderItemsUpdaterService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
	app.UseDeveloperExceptionPage();
}
else
{
	app.UseExceptionHandler("/error");
	app.UseHsts();
}

app.UseRouting();


app.MapControllers();


// Run the application.
app.Run();
