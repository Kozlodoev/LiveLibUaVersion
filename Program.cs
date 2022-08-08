using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using LiveLibUaVersionMVC.Data;
using LiveLibUaVersionMVC.Models;


var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<LiveLibUaVersionMVCContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("LiveLibUaVersionMVCContext") ?? throw new InvalidOperationException("Connection string 'LiveLibUaVersionMVCContext' not found.")));
/*builder.Services.AddDbContext<LiveLibUaVersionMVCContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("LiveLibUaVersionMVCContext")));*/


builder.Services.AddControllersWithViews();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    SeedData.Initialize(services);
}

if (!app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseHsts();
}


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Books}/{action=Index}/{id?}");

app.UseHttpsRedirection();
app.UseStaticFiles();


app.Run();
