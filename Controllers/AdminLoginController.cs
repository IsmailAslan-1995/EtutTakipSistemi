using Microsoft.AspNetCore.Mvc;
using EtutTakipSistemi.Models;
using EtutTakipSistemi;

public class AdminController : Controller
{
    private readonly EtutContext _context;

    public AdminController(EtutContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult Login()
    {
        return View("Views/AdminDashboard/Login.cshtml");
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Login(AdminTablosu adminTablosu)
    {
        
        var admin = _context.AdminTablosu
            .FirstOrDefault(x => x.KullaniciAdi == adminTablosu.KullaniciAdi 
                              && x.Sifre == adminTablosu.Sifre);

        if (admin != null)
        {
            HttpContext.Session.SetInt32("AdminId", admin.Id);
            return RedirectToAction("Index", "AdminDashboard");
        }

        ViewBag.Hata = "Geçersiz kullanıcı adı veya şifre!";
        return View();
    }
}