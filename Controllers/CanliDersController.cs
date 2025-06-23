using Microsoft.AspNetCore.Mvc;
using EtutTakipSistemi.Models;
using System.Linq;
using EtutTakipSistemi; 

public class CanliDersController : Controller
{
    private readonly EtutContext _context;

    public CanliDersController(EtutContext context)
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

        var bugun = DateTime.Today;

        var dersler = _context.CanliDersler
            .Where(d => d.OgrenciId == user.Id)
            .OrderBy(d => d.DersTarihi)
            .ToList();

        ViewBag.Bugun = bugun;
        ViewBag.Dersler = dersler;

        return View();
    }
}