using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using sgo_back_end.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<ApplicationDbContext>
    (options => options.UseSqlServer
    ("Server = tcp:coredbserver321.database.windows.net, 1433; Initial Catalog = coreDb; Persist Security Info=False; User ID = serversgo; Password = Pucsgo,1; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30"));
//("Server = tcp:projetosgo.database.windows.net, 1433; Initial Catalog = coreDb; Persist Security Info=False; User ID = projetosgo; Password = Sgo,testando; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30"));
//("Server=(localdb)\\mssqllocaldb;Database=SGO_backend;Trusted_Connection=True;MultipleActiveResultSets=true"));

builder.Services.Configure<CookiePolicyOptions>(options =>
{
    options.CheckConsentNeeded = Context => true;
    options.MinimumSameSitePolicy = SameSiteMode.None;
});

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options =>
    {
        options.AccessDeniedPath = "/Account/AccessDenied/";
        options.LoginPath = "/Usuarios/Login/";
    });



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

app.UseCookiePolicy();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Usuarios}/{action=Login}/{id?}");

app.Run();
