var builder = WebApplication.CreateBuilder(args);



builder.Services.AddControllersWithViews(); // Controllerlar kullanılacak. Viewler kullanılacak.

var app = builder.Build();

app.MapControllerRoute(
    name: "Default",
    pattern: "{controller=Home}/{action=Index}"
    );

app.MapGet("/", () => "Hello World!");

app.Run();



