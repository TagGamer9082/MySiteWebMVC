var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseStaticFiles();

app.MapControllerRoute(
    "Default",                                              // Route name
    "{controller}/{action}/{id}",                           // URL with parameters
    new { controller = "Home", action = "Index", id = "" }  // Parameter defaults
);

app.Run();
