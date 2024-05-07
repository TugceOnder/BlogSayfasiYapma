using System.ComponentModel.DataAnnotations;

namespace TravelApplication.Models.Siniflar
{
    public class AdresBlog
    {
        [Key]
        public int ID { get; set; }
        public string Baslık { get; set; }
        public string Aciklama { get; set; }
        public string AdresAciklama { get; set; }
        public string Mail { get; set; }
        public string Telefon{ get; set; }
        public string Konum { get; set; }




    }
}
