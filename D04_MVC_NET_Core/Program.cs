using Microsoft.EntityFrameworkCore;
using D04_MVC_NET_Core.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// TODO MRS: ler connection string de appsettings.json
var connectionString = builder.Configuration.GetConnectionString("ContactDB_EFCore_DatabaseFirstContext");

// TODO MRS: configurar a EF
builder.Services.AddDbContext<ContactDB_EFCore_DatabaseFirstContext>(options =>
options.UseSqlServer(connectionString));

builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
