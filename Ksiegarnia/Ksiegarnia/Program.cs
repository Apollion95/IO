using Infrastructure.Data;
using Pomelo.EntityFrameworkCore.MySql;
using System.Configuration;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


//services.AddDbContext<MysqlContext>(options => options.UseMySQL(Configuration.GetConnectionString("MysqlConnection")));
builder.Services.AddCors();
builder.Services.AddDbContext<Context>(options =>
{
    
    options.UseMySql("server=localhost;port=49997;database=KSIEGARNIA;user=root;password=Mojekonto14", new MySqlServerVersion(new Version(8, 0, 27)));
    
});



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
