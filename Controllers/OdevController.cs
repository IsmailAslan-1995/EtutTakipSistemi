using Microsoft.AspNetCore.Mvc;
using EtutTakipSistemi;
using EtutTakipSistemi.Models;
using System.Linq;

public class OdevController : Controller
{
    private readonly EtutContext _context;

    public OdevController(EtutContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var username = HttpContext.Session.GetString("username");
        if (string.IsNullOrEmpty(username))
            return RedirectToAction("Login", "Kullanici");

        var user = _context.Kullanici.FirstOrDefault(x => x.KullaniciAdi == username);
        if (user == null)
            return RedirectToAction("Login", "Kullanici");

        var bugun = DateTime.UtcNow.Date;

        // Sadece tarihi geçmiş denemeler (tamamlanan ödevler)
        var tamamlananOdevler = _context.OgrenciDeneme
            .Where(d => d.OgrenciId == user.Id && d.Tarih < bugun)
            .OrderByDescending(d => d.Tarih)
            .ToList();

        ViewBag.TamamlananOdevler = tamamlananOdevler;

        return View();
    }
}