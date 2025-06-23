using Microsoft.AspNetCore.Mvc;
using EtutTakipSistemi;
using EtutTakipSistemi.Models;
using System.Linq;

public class TestController : Controller
{
    private readonly EtutContext _context;

    public TestController(EtutContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        // Tüm testleri çek
        var testler = _context.Testler.ToList();

        // Derslere göre grupla
        var grup = testler
            .GroupBy(t => t.DersAdi)
            .ToDictionary(g => g.Key, g => g.ToList());

        ViewBag.DersGruplari = grup;
        return View();
    }
}