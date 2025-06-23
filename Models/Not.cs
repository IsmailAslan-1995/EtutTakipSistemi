using System.ComponentModel.DataAnnotations;

namespace EtutTakipSistemi.Models
{
    public class Not
    {
        public int Id { get; set; }

        [Required]
        public string OgrenciAdi { get; set; }

        [Required]
        public string DersAdi { get; set; }

        public int Puan { get; set; }
    }
}
