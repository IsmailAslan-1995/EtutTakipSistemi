using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EtutTakipSistemi.Models
{
    [Table("ogrencideneme")]
    public class OgrenciDeneme
    {
        [Key]
        [Column("sira")]
        public int Sira { get; set; }

        [Column("ogrenciid")]
        public int OgrenciId { get; set; }

        [Column("turkced")]
        public string TurkceD { get; set; }

        [Column("turkcey")]
        public string TurkceY { get; set; }

        [Column("matd")]
        public string MatD { get; set; }

        [Column("maty")]
        public string MatY { get; set; }

        [Column("sosd")]
        public string SosD { get; set; }

        [Column("sosy")]
        public string SosY { get; set; }

        [Column("fend")]
        public string FenD { get; set; }

        [Column("feny")]
        public string FenY { get; set; }

        [Column("tarih")]
        public DateTime Tarih { get; set; }

        [Column("tyt_puan")]
        public string TytPuan { get; set; }
    }
}
