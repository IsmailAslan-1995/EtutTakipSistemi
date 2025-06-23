using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace EtutTakipSistemi.Models
{   
     [Table("ogretmenler")]
    public class Ogretmenler
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("ad")]
        public string Ad { get; set; }

        [Column("soyad")]
        public string Soyad { get; set; }

        [Column("brans")]
        public string Brans { get; set; }

        [Column("isbaslangictarihi")]
        public DateTime IsBaslangicTarihi { get; set; }
    }
}