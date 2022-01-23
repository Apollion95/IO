using Infrastructure.Data;
using Pomelo.EntityFrameworkCore.MySql;
using System.Configuration;
using Microsoft.EntityFrameworkCore;
using Infrastructure.Repository.Interfaces;
using Infrastructure.Repository;
using Bookstore.Services;

var builder = WebApplication.CreateBuilder(args);


var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddCors();
builder.Services.AddDbContext<BookStoreContext>(options =>
{

    options.UseMySql(connectionString, new MySqlServerVersion(new Version(8, 0, 27)));

});


builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IAuthorRepository, AuthorRepository>();
builder.Services.AddScoped<AuthorService, AuthorService>();

// Add services to the container.

builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();




app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html"); ;

app.Run();
