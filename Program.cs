using EtutTakipSistemi;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using Npgsql.EntityFrameworkCore.PostgreSQL;

var builder = WebApplication.CreateBuilder(args);

// 🔌 PostgreSQL bağlantı ayarı
builder.Services.AddDbContext<EtutContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

// 🧠 Session servisi
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

// MVC + Razor
builder.Services.AddControllersWithViews();

// HttpContext erişimi için
builder.Services.AddHttpContextAccessor();

var app = builder.Build();

// Ekstra: HTTPS yönlendirme
app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseRouting();
app.UseSession();

// Default yönlendirme
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Kullanici}/{action=Login}/{id?}");

app.Run();