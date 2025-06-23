using Microsoft.AspNetCore.Mvc;
using EtutTakipSistemi.Models;
using System.Linq;
using EtutTakipSistemi;

public class TytController : Controller
{
    private readonly EtutContext _context;

    public TytController(EtutContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        if (HttpContext.Session.GetString("username") == null)
            return RedirectToAction("Login", "Kullanici");

        var tyts = _context.Tyts.ToList();
        return View(tyts);
    }

    public IActionResult Create()
    {
        if (HttpContext.Session.GetString("username") == null)
            return RedirectToAction("Login", "Kullanici");

        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(Tyt tyt)
    {
        if (HttpContext.Session.GetString("username") == null)
            return RedirectToAction("Login", "Kullanici");

        if (ModelState.IsValid)
        {
            _context.Tyts.Add(tyt);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        return View(tyt);
    }
}
