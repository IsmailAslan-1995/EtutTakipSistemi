using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EtutTakipSistemi.Models
{
    [Table("ticket")]
    public class Ticket
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("ogrenciid")]
        public int OgrenciId { get; set; }

        [Column("mesaj")]
        public string Mesaj { get; set; }

        [Column("cevap")]
        public string Cevap { get; set; }

        [Column("konu")]
        public string Konu { get; set; }
    }
}
