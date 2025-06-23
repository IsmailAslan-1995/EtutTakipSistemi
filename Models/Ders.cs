using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EtutTakipSistemi.Models
{
    [Table("dersler")]
    public class Ders
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("dersad")]
        public string Ad { get; set; }

        [Column("aciklama")]
        public string? Aciklama { get; set; }
    }
}

