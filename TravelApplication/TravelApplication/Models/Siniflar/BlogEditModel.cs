namespace TravelApplication.Models.Siniflar
{
	public class BlogEditModel
	{

		public List<Blog> BlogList { get; set; }
		public List<BlogYorum> YorumList { get; set; }

		public string TitleOfProductList { get; set; }

		public Blog BlogToUpdate { get; set; }
	}
}
