namespace TravelApplication.Models.Siniflar.Modeller
{
	public class BlogNewModel
	{

		public List<Blog> BlogList { get; set; }
		public List<Yorumlar> YorumlarList { get; set; }

		public string OperationMessage { get; set; }
	}
}
