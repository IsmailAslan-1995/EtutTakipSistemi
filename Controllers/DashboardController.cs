using Microsoft.AspNetCore.Mvc;
using EtutTakipSistemi;

public class DashboardController : Controller
{
    private readonly EtutContext _context;

    public DashboardController(EtutContext context)
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

        // Kullanıcının denemeleri
        var denemeler = _context.OgrenciDeneme
            .Where(d => d.OgrenciId == user.Id)
            .OrderByDescending(d => d.Tarih)
            .ToList();

        // En son alınan puan
        var sonPuan = denemeler.FirstOrDefault()?.TytPuan ?? "0";

        // Ortalama puan
        double ortalama = 0;
        List<double> puanlar = new List<double>();
        if (denemeler.Count > 0)
        {
            puanlar = denemeler
                .Select(d => double.TryParse(d.TytPuan, out var p) ? p : 0)
                .ToList();
            ortalama = puanlar.Any() ? puanlar.Average() : 0;
        }

        // Toplamda çözülen soru sayısı (örnek: Türkçe Doğru + Yanlış + Matematik Doğru + Yanlış ...)
        int toplamSoru = denemeler.Sum(d =>
            (int.TryParse(d.TurkceD, out var td) ? td : 0) +
            (int.TryParse(d.TurkceY, out var ty) ? ty : 0) +
            (int.TryParse(d.MatD, out var md) ? md : 0) +
            (int.TryParse(d.MatY, out var my) ? my : 0) +
            (int.TryParse(d.SosD, out var sd) ? sd : 0) +
            (int.TryParse(d.SosY, out var sy) ? sy : 0) +
            (int.TryParse(d.FenD, out var fd) ? fd : 0) +
            (int.TryParse(d.FenY, out var fy) ? fy : 0)
        );

        // Toplam doğru ve yanlış sayısı
        int toplamDogru = denemeler.Sum(d =>
            (int.TryParse(d.TurkceD, out var td) ? td : 0) +
            (int.TryParse(d.MatD, out var md) ? md : 0) +
            (int.TryParse(d.SosD, out var sd) ? sd : 0) +
            (int.TryParse(d.FenD, out var fd) ? fd : 0)
        );

        int toplamYanlis = denemeler.Sum(d =>
            (int.TryParse(d.TurkceY, out var ty) ? ty : 0) +
            (int.TryParse(d.MatY, out var my) ? my : 0) +
            (int.TryParse(d.SosY, out var sy) ? sy : 0) +
            (int.TryParse(d.FenY, out var fy) ? fy : 0)
        );

        // Net hesaplama (doğru - yanlış/4)
        double toplamNet = toplamDogru - (toplamYanlis / 4.0);

       
        int kullaniciId = user.Id;
        // Önce puanları string olarak çek
        var puanStrList = _context.OgrenciDeneme
            .Where(x => x.OgrenciId == kullaniciId && x.TytPuan != null && x.TytPuan != "")
            .Select(x => x.TytPuan)
            .ToList();

        // Sonra double'a çevir
        var puanlar2 = puanStrList
            .Select(s => double.TryParse(s, out var puan) ? puan : 0)
            .ToList();

        ViewBag.User = user;
        ViewBag.SonPuan = sonPuan;
        ViewBag.Ortalama = ortalama.ToString("0.##");
        ViewBag.ToplamSoru = toplamSoru;
        ViewBag.ToplamDogru = toplamDogru;
        ViewBag.ToplamYanlis = toplamYanlis;
        ViewBag.ToplamNet = toplamNet.ToString("0.##");
        
        var puanlar3 = puanStrList
            .Select(s => double.TryParse(s, out var puan) ? puan : 0)
            .ToList();

        ViewBag.OrtalamaPuan = ortalama;

        return View("~/Views/Kullanici/Dashboard.cshtml");
    }
}