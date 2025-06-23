using System.ComponentModel.DataAnnotations;

namespace EtutTakipSistemi.Models
{
    public class Tyt
    {
        public int Id { get; set; }

        [Required]
        public string Konu { get; set; }

        public int Dogru { get; set; }

        public int Yanlis { get; set; }
    }
}
