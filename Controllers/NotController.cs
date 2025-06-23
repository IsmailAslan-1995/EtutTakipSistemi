using Microsoft.AspNetCore.Mvc;
using EtutTakipSistemi.Models;
using System.Linq;
using EtutTakipSistemi;

public class NotController : Controller
{
    private readonly EtutContext _context;

    public NotController(EtutContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        if (HttpContext.Session.GetString("username") == null)
            return RedirectToAction("Login", "Kullanici");

        var notlar = _context.Notlar.ToList();
        return View(notlar);
    }

    public IActionResult Create()
    {
        if (HttpContext.Session.GetString("username") == null)
            return RedirectToAction("Login", "Kullanici");

        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(Not not)
    {
        if (HttpContext.Session.GetString("username") == null)
            return RedirectToAction("Login", "Kullanici");

        if (ModelState.IsValid)
        {
            _context.Notlar.Add(not);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        return View(not);
    }
}
