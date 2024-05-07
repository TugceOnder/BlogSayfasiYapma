using System.ComponentModel.DataAnnotations;

namespace TravelApplication.Models.Siniflar
{
    public class Admin
    {
        [Key]
        public int ID { get; set; }
        public string Kullanici {  get; set; }

        public string sifre {  get; set; }


    }
}
