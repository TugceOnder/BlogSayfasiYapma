using System.ComponentModel.DataAnnotations;

namespace TravelApplication.Models.Siniflar
{
    public class Yorumlar
    {
        [Key]
        public int ID { get; set; }
        public string KullaniciAdi { get; set; }
        public string Mail { get; set; }
        public string Yorum { get; set; } 
        public int BlogID {  get; set; }

        //bir yorumda birden fazla yorum olabilir
        public virtual Blog Blog { get; set; }
        

    }
}
