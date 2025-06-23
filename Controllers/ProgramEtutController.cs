using Microsoft.AspNetCore.Mvc;
using EtutTakipSistemi;
using EtutTakipSistemi.Models;
using System.Linq;


public class ProgramEtutController : Controller
{
    private readonly EtutContext _context;

    public ProgramEtutController(EtutContext context)
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

        var bugun = DateTime.UtcNow.Date; // <-- DÜZELTİLDİ

        // Geçmemiş etütler
        var aktifEtutler = _context.Etut
            .Where(e => e.OgrenciId == user.Id && e.Tarih >= bugun)
            .OrderBy(e => e.Tarih)
            .ToList();

        // Geçmiş etütler
        var gecmisEtutler = _context.Etut
            .Where(e => e.OgrenciId == user.Id && e.Tarih < bugun)
            .OrderByDescending(e => e.Tarih)
            .ToList();

        ViewBag.AktifEtutler = aktifEtutler;
        ViewBag.GecmisEtutler = gecmisEtutler;

        return View();
    }
}