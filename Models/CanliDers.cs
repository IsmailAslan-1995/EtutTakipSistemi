using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EtutTakipSistemi.Models
{
    [Table("canli_dersler")]
    public class CanliDers
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("ogrenciid")]
        public int OgrenciId { get; set; }

        [Column("ders_adi")]
        public string DersAdi { get; set; }

        [Column("konu")]
        public string Konu { get; set; }

        [Column("ogretmen")]
        public string Ogretmen { get; set; }

        [Column("ders_tarihi")]
        public DateTime DersTarihi { get; set; }
    }
}