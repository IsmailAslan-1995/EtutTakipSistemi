using Microsoft.AspNetCore.Mvc;
using EtutTakipSistemi;
using EtutTakipSistemi.Models;

public class AdminDashboardController : Controller
{
    private readonly EtutContext _context;

    public AdminDashboardController(EtutContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        ViewBag.ToplamDers = _context.Dersler.Count();
        ViewBag.ToplamOgretmen = _context.Ogretmenler.Count();
        ViewBag.ToplamToplanti = _context.CanliDersler.Count();
        ViewBag.ToplamDestek = _context.Ticketlar.Count();
        ViewBag.Admin = _context.AdminTablosu.FirstOrDefault(x => x.Id == HttpContext.Session.GetInt32("AdminId"));
        return View();
    }

    public IActionResult Profil()
    {
        var adminId = HttpContext.Session.GetInt32("AdminId");
        if (adminId == null)
            return RedirectToAction("Login", "Admin");

        var admin = _context.AdminTablosu.FirstOrDefault(x => x.Id == adminId);
        if (admin == null)
            return NotFound();

        return View(admin);
    }

    public IActionResult Dersler()
    {
        var dersler = _context.Dersler.ToList();
        return View(dersler);
    }

    [HttpPost]
    public IActionResult SilDers(int id)
    {
        var ders = _context.Dersler.Find(id);
        if (ders != null)
        {
            _context.Dersler.Remove(ders);
            _context.SaveChanges();
        }
        return RedirectToAction("Dersler");
    }
    [HttpPost]
public IActionResult EkleDers(string dersAdi, string dersAciklama)
{
    var yeniDers = new Ders
    {
        Ad = dersAdi,
        Aciklama = dersAciklama
    };

    _context.Dersler.Add(yeniDers);
    _context.SaveChanges();

    return RedirectToAction("Dersler"); 
}
public IActionResult Ogretmenler()
{
    var ogretmenler = _context.Ogretmenler.ToList();
    return View(ogretmenler);
}

[HttpPost]
public IActionResult SilOgretmen(int id)
{
    var ogretmen = _context.Ogretmenler.Find(id);
    if (ogretmen != null)
    {
        _context.Ogretmenler.Remove(ogretmen);
        _context.SaveChanges();
    }
    return RedirectToAction("Ogretmenler");
}

[HttpPost]
public IActionResult OgretmenEkle(string Ad, string Soyad, string Brans, DateTime IsBaslangicTarihi)
{
    var yeniOgretmen = new Ogretmenler
    {
        Ad = Ad,
        Soyad = Soyad,
        Brans = Brans,
        IsBaslangicTarihi = IsBaslangicTarihi
    };
    _context.Ogretmenler.Add(yeniOgretmen);
    _context.SaveChanges();
    return RedirectToAction("Ogretmenler");
}
public IActionResult DersProgrami()
{
    var canliDersler = _context.CanliDersler.ToList();
    return View(canliDersler);
}

[HttpPost]
public IActionResult SilCanliDers(int id)
{
    var ders = _context.CanliDersler.Find(id);
    if (ders != null)
    {
        _context.CanliDersler.Remove(ders);
        _context.SaveChanges();
    }
    return RedirectToAction("DersProgrami");
}

[HttpPost]
public IActionResult CanliDersEkle(string DersAdi, string Konu, string Ogretmen, DateTime DersTarihi, int OgrenciId)
{
    var yeniDers = new CanliDers
    {
        DersAdi = DersAdi,
        Konu = Konu,
        Ogretmen = Ogretmen,
        DersTarihi = DersTarihi,
        OgrenciId = OgrenciId
    };
    _context.CanliDersler.Add(yeniDers);
    _context.SaveChanges();
    return RedirectToAction("DersProgrami");
}
public IActionResult Destek()
{
    var talepler = _context.Ticketlar.ToList();
    return View(talepler);
}

[HttpPost]
public IActionResult DestekEkle(int OgrenciId, string Konu, string Mesaj)
{
    var yeniTalep = new Ticket
    {
        OgrenciId = OgrenciId,
        Konu = Konu,
        Mesaj = Mesaj,
        Cevap = ""
    };
    _context.Ticketlar.Add(yeniTalep);
    _context.SaveChanges();
    return RedirectToAction("Destek");
}

[HttpPost]
public IActionResult SilDestek(int id)
{
    var talep = _context.Ticketlar.Find(id);
    if (talep != null)
    {
        _context.Ticketlar.Remove(talep);
        _context.SaveChanges();
    }
    return RedirectToAction("Destek");
}
}