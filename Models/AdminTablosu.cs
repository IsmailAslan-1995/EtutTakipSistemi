using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EtutTakipSistemi.Models
{
    [Table("admin_tablosu")]
    public class AdminTablosu
    {
        [Key]
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

        [Column("lastlogin")]
        public string LastLogin { get; set; }

        [Column("ip_adresi")]
        public string IpAdresi { get; set; }

        [Column("foto")]
        public string Foto { get; set; }
    }
}
