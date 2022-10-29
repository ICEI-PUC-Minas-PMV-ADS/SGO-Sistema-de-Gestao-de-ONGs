using Microsoft.EntityFrameworkCore;
using sgo_back_end.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<ApplicationDbContext>
    (options => options.UseSqlServer
    ("Server = tcp:domingosolidario.database.windows.net, 1433; Initial Catalog = coreDb; Persist Security Info=False; User ID = gestorsgo; Password = sgologin,1; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30"));
    //("Server=(localdb)\\mssqllocaldb;Database=SGO_backend;Trusted_Connection=True;MultipleActiveResultSets=true"));

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

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
