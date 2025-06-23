using Microsoft.AspNetCore.Mvc;
using EtutTakipSistemi.Models;
using System.Linq;
using EtutTakipSistemi;

namespace EtutTakipSistemi.Controllers
{
    public class DersController : Controller
    {
        private readonly EtutContext _context;

        public DersController(EtutContext context)
        {
            _context = context;
        }

        // GET: /Ders/
        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("username") == null)
            {
                return RedirectToAction("Login", "Kullanici");
            }

            var dersler = _context.Dersler.ToList();
            return View(dersler);
        }

        // GET: /Ders/Create
        public IActionResult Create()
        {
            if (HttpContext.Session.GetString("username") == null)
            {
                return RedirectToAction("Login", "Kullanici");
            }

            return View();
        }

        // POST: /Ders/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Ders ders)
        {
            if (HttpContext.Session.GetString("username") == null)
            {
                return RedirectToAction("Login", "Kullanici");
            }

            if (ModelState.IsValid)
            {
                _context.Dersler.Add(ders);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View(ders);
        }
    }
}
