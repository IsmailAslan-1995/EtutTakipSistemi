using Microsoft.EntityFrameworkCore;
using EtutTakipSistemi.Models;

namespace EtutTakipSistemi
{
    public class EtutContext : DbContext
    {
        public EtutContext(DbContextOptions<EtutContext> options) : base(options) { }

        public DbSet<AdminTablosu> AdminTablosu { get; set; }
        public DbSet<Kullanici> Kullanici { get; set; }
        public DbSet<Ders> Dersler { get; set; }
        public DbSet<Etut> Etut { get; set; }
        public DbSet<OgrenciDeneme> OgrenciDeneme { get; set; }
        public DbSet<OgrenciTest> OgrenciTestleri { get; set; }
        public DbSet<Test> Testler { get; set; }

        public DbSet<Ticket> Ticketlar { get; set; }
        public DbSet<Tyt> Tyts { get; set; }
        public DbSet<Not> Notlar { get; set; }
        public DbSet<CanliDers> CanliDersler { get; set; }
        public DbSet<Ogretmenler> Ogretmenler { get; set; }


    }
}
