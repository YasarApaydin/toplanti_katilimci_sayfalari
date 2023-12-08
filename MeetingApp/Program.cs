var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();
/*
app.MapGet("/", () => "Hello World!");
app.MapGet("/abc", () => "Guten tag!");
*/
//controller/action/id?
//app.MapDefaultControllerRoute();
app.MapControllerRoute(
   name: "default",
   pattern:"{controller=Home}/{action=Index}/{id?}"
    ) ;

app.Run();
