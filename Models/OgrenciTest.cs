using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EtutTakipSistemi.Models
{
    [Table("test_sonuclari")]
    public class OgrenciTest
    {
        [Key]
        [Column("id")]
        public int Sira { get; set; }

        [Column("ogrenciid")]
        public int OgrenciId { get; set; }

        [Column("ders")]
        public string DersAdi { get; set; }

        [Column("dsayisi")]
        public int DogruSayisi { get; set; }

        [Column("ysayisi")]
        public int YanliSayisi { get; set; }

        [Column("net")]
        public float NetSayisi { get; set; }

        [Column("testid")]
        public int CozulenSoru { get; set; }
    }
}
