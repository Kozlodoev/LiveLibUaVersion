using LiveLibUaVersionMVC.Data;
using LiveLibUaVersionMVC.Models;

var builder = WebApplication.CreateBuilder(args);

RegisterServices(builder.Services);

var app = builder.Build();

Configure(app);

app.Run();

void RegisterServices(IServiceCollection services)
{
    services.AddDbContext<LibraryContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("LibraryContext") ?? throw new InvalidOperationException("Connection string 'LibraryContext' not found.")));

    services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
        .AddCookie(options => options.LoginPath = "/auth/login");
    services.AddAuthorization();

    services.AddControllersWithViews();
}

void Configure(WebApplication app)
{
    if (!app.Environment.IsDevelopment())
    {
        app.UseDeveloperExceptionPage();
        app.UseHsts();
    }

    app.UseHttpsRedirection();
    app.UseStaticFiles();

    // Дозволяє вибрати правильний спосіб використання IDisposable objects.
    using (var scope = app.Services.CreateScope())
    {
        var services = scope.ServiceProvider;

        SeedData.Initialize(services);
    }

    app.UseAuthentication();
    app.UseAuthorization();

    /* Універсальний метод, заміняє метод MapControllerRoute(), по замовчуванню створює маршрут
      { controller = Home}/{ action = Index}/{ id ?}
     app.MapDefaultControllerRoute();*/
    app.MapControllerRoute(
        name: "default",
        pattern: "{controller=Books}/{action=Index}/{id?}");
    app.MapControllerRoute(
        name: "validation",
        pattern: "{controller=Auth}/{action}/{id?}");


}


