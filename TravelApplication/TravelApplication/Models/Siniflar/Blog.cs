using System.ComponentModel.DataAnnotations;

namespace TravelApplication.Models.Siniflar
{
    public class Blog
    {
        [Key]
        public int ID { get; set; }
        public string Baslık { get; set; }
        public DateTime Tarih { get; set; }

        public string Aciklama { get; set; }
        public string BlogImage { get; set; }
        
        //ilişkili değerleri property değerli tuttuumuz yer
        public ICollection <Yorumlar>Yorumlars { get; set; }
        //1yorum 1 blog için 
    }
}
