namespace TravelApplication.Models.Siniflar.Modeller
{
	public class BlogtInsertModel
	{

		public string Baslık { get; set; }
		public DateTime Tarih { get; set; }

		public string Aciklama { get; set; }
		public string BlogImage { get; set; }

		//ilişkili değerleri property değerli tuttuumuz yer
		public ICollection<Yorumlar> Yorumlars { get; set; }
		//1yorum 1 blog için
	}
}
