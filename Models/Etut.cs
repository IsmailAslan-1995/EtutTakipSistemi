using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EtutTakipSistemi.Models
{
    [Table("etut")]
    public class Etut
    {
        [Key]
        [Column("sira")]
        public int Sira { get; set; }

        [Column("ogrenciid")]
        public int OgrenciId { get; set; }

        [Column("tarih")]
        public DateTime Tarih { get; set; }

        [Column("konular")]
        public string Konular { get; set; }

        [Column("katilim")]
        public int Katilim { get; set; }

        [Column("dersadi")]
        public string DersAdi { get; set; }

        [Column("dersvideo")]
        public string DersVideo { get; set; }
    }
}
