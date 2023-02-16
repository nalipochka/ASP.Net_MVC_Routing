using Microsoft.AspNetCore.Routing.Constraints;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapControllerRoute(
    name: "default",
    pattern: "{controller:regex(^[^HAU].*)}/{action=Index}/{id?}");
//-- 1 --
app.MapControllerRoute(
    name:"newOrder",
    pattern: "newOrder",
    defaults: new { controller ="Shop", action = "Buy" });
//-- 2 --
app.MapControllerRoute(
    name: "home_action<=7",
    pattern: "{controller=Home}/{action:maxlength(6)}/{id?}",
    defaults: new {action ="Index"},
    constraints: new { controller = new RegexRouteConstraint("^H.*") });
//-- 3 --
app.MapControllerRoute(
    name:"user",
    pattern: "usersettings/{id:int:range(1,999)?}",
    defaults: new {controller = "User", action = "Settings"});
//-- 4 --
app.MapControllerRoute(
    name: "admin",
    pattern:"Admin/{action:regex(^\\w+setup$)}",
    defaults: new { controller="Admin"});

app.Run();
