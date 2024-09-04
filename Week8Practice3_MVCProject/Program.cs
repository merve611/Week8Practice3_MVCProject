var builder = WebApplication.CreateBuilder(args);



builder.Services.AddControllersWithViews(); // Controllerlar kullan�lacak. Viewler kullan�lacak.

var app = builder.Build();

app.MapControllerRoute(
    name: "Default",
    pattern: "{controller=Home}/{action=Index}"
    );

app.MapGet("/", () => "Hello World!");

app.Run();



