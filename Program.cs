var builder = WebApplication.CreateBuilder(args);

//mvc şablonunun eklenmesi
builder.Services.AddControllersWithViews();

var app = builder.Build();

// {controller=Home}/{action=Index}/{id?}
//app.MapDefaultControllerRoute();

app.UseStaticFiles();
app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);

app.Run();
