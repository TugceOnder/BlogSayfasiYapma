using System.ComponentModel.DataAnnotations;
using TravelApplication.Models.Siniflar.Enumlar;

namespace TravelApplication.Models.Siniflar
{
    public class Oteller
    {
        [Key]
        public int ID { get; set; }
        public string Baslık { get; set; }
        public string Aciklama  { get; set; }

        public string OtelImage { get; set; }

      // public Hizmetler hizmetler { get; set; }
    }
}
