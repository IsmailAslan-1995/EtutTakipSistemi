using Microsoft.AspNetCore.Mvc;
using EtutTakipSistemi.Models;
using System.Linq;
using EtutTakipSistemi;

public class KullaniciController : Controller
{
    private readonly EtutContext _context;

    public KullaniciController(EtutContext context)
    {
        _context = context;
    }

    public IActionResult Login()
    {
        return View();
    }

[HttpPost]
[ValidateAntiForgeryToken]
public IActionResult Login(Kullanici kullanici)
{
    Console.WriteLine($"Kullanıcı Adı: {kullanici.KullaniciAdi}, Şifre: {kullanici.Sifre}");
    Console.WriteLine($"ModelState.IsValid: {ModelState.IsValid}");

    var user = _context.Kullanici
        .FirstOrDefault(x => x.KullaniciAdi == kullanici.KullaniciAdi && x.Sifre == kullanici.Sifre);

    if (user != null)
    {
        HttpContext.Session.SetString("username", user.KullaniciAdi);
        return RedirectToAction("Index", "Dashboard");
    }

    ViewBag.Hata = "Kullanıcı adı veya şifre hatalı!";
    return View();
}

    public IActionResult Logout()
    {
        HttpContext.Session.Clear();
        return RedirectToAction("Login");
    }

    public IActionResult Profile()
    {
        var username = HttpContext.Session.GetString("username");
        if (username == null)
            return RedirectToAction("Login");

        var kullanici = _context.Kullanici.FirstOrDefault(x => x.KullaniciAdi == username);
        return View(kullanici);
    }
    public IActionResult Register()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Register(Kullanici kullanici)
    {
        if (_context.Kullanici.Any(x => x.KullaniciAdi == kullanici.KullaniciAdi))
        {
            ViewBag.Hata = "Bu kullanıcı adı zaten kayıtlı.";
            return View();
        }

        if (ModelState.IsValid)
        {
            _context.Kullanici.Add(kullanici);
            _context.SaveChanges();
            return RedirectToAction("Login");
        }

        return View(kullanici);
    }

    }
