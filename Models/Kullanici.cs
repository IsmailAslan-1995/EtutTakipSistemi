using System.ComponentModel.DataAnnotations.Schema;

namespace EtutTakipSistemi.Models
{
    [Table("kullanici_tablosu")]
    public class Kullanici
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("kullanici_adi")]
        public string KullaniciAdi { get; set; }

        [Column("sifre")]
        public string Sifre { get; set; }

        [Column("ad")]
        public string Ad { get; set; }

        [Column("soyad")]
        public string Soyad { get; set; }

        [Column("eposta")]
        public string Eposta { get; set; }

        [Column("universite")]
        public string Universite { get; set; }

        [Column("unibolum")]
        public string Unibolum { get; set; }

        [Column("unitur")]
        public string Unitur { get; set; }

        [Column("unitkont")]
        public string Unitkont { get; set; }

        [Column("unitaban")]
        public string Unitaban { get; set; }

        [Column("unitavan")]
        public string Unitavan { get; set; }

        [Column("unitanitimvideo")]
        public string Unitanitimvideo { get; set; }

        [Column("fotoprofil")]
        public string Fotoprofil { get; set; }

        [Column("lastlogin")]
        public string Lastlogin { get; set; }

        [Column("ip")]
        public string Ip { get; set; }
    }
}