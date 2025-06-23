using Microsoft.AspNetCore.Mvc;
using EtutTakipSistemi;
using EtutTakipSistemi.Models;
using System.Linq;

public class TestSonucController : Controller
{
    private readonly EtutContext _context;

    public TestSonucController(EtutContext context)
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

        // Test sonuçlarını OgrenciTest tablosundan çek
        var testSonuclari = _context.OgrenciTestleri
            .Where(t => t.OgrenciId == user.Id)
            .ToList();

        // Derslere göre grupla
        var grup = testSonuclari
            .GroupBy(t => t.DersAdi)
            .ToDictionary(g => g.Key, g => g.ToList());

        ViewBag.DersGruplari = grup;

        return View();
    }
}