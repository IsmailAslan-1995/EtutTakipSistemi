using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EtutTakipSistemi.Models
{
    [Table("testler")]
    public class Test
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("testadi")]
        public string TestAdi { get; set; }

        [Column("sorusayisi")]
        public int SoruSayisi { get; set; }

        [Column("dersadi")]
        public string DersAdi { get; set; }

        [Column("eklenmetarihi")]
        public DateTime EklenmeTarihi { get; set; }
    }
}
