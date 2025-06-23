using Microsoft.AspNetCore.Mvc;
using EtutTakipSistemi;
using EtutTakipSistemi.Models;
using System.Linq;

public class DestekController : Controller
{
    private readonly EtutContext _context;

    public DestekController(EtutContext context)
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

        // Sadece kullanıcının ticketlarını çek
        var tickets = _context.Ticketlar
            .Where(t => t.OgrenciId == user.Id)
            .OrderByDescending(t => t.Id)
            .ToList();

        ViewBag.Tickets = tickets;
        return View();
    }
}