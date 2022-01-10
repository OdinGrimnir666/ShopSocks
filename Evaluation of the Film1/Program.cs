using Evaluation_of_the_Film1.Data;
using Evaluation_of_the_Film1.Data.interaces;
using Evaluation_of_the_Film1.Data.Models;
using Evaluation_of_the_Film1.Data.Repository;
using Evaluation_of_the_Film1.interaces;
using Evaluation_of_the_Film1.mocks;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using System;

var builder = WebApplication.CreateBuilder(args);



var builder1 = new ConfigurationBuilder();
// Add services to the container.
builder1.SetBasePath(Directory.GetCurrentDirectory());
builder1.AddJsonFile("dbsettings.json");
var config = builder1.Build();
string connectionString = config.GetConnectionString("DefaultConnection");



builder.Services.AddControllersWithViews();
builder.Services.AddTransient<IAllSocks,SocksRepositary>();
builder.Services.AddTransient<ISocksCategory,CategoryRepositary>() ;
builder.Services.AddTransient<ISocksfloor, FlorrREpositary>();
builder.Services.AddTransient<IALlordercs,OrderRepository>();
builder.Services.AddDbContext<AppDbContent>(options => options.UseSqlServer(config.GetConnectionString("DefaultConnection")));

builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

builder.Services.AddScoped(sp => ShopSocks.Getsocks(sp));

builder.Services.AddMemoryCache();
builder.Services.AddSession();




var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    AppDbContent content = scope.ServiceProvider.GetRequiredService<AppDbContent>();
    DBobject.initial(content);
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseSession();

//app.UseMvcWithDefaultRoute();

app.UseRouting();

app.UseAuthorization();


//app.UseMvc(routes
//    =>
//{
//    routes.MapRoute(name: "default", template: "{controller=home}/{action=Index}/{id?}");
//    routes.MapRoute(name: "categoryfilter", template: "ShopSocks/{action}/{category?}", defaults: new { Controller = "SocksShop", Action = "list" });
//});

app.MapControllerRoute(
  name: "default",
 pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name:"categoryfilter",
    pattern: "ShopSocks/{action}/{category?}");



app.Run();

