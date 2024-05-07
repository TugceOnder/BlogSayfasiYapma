namespace TravelApplication.Models.Siniflar
{
    public class IndexModel
    {
        // Bütü dataları burada tutcağımız yer 
        public List <Blog> BlogList{ get; set; }
        public List <BlogYorum > YorumList { get; set; }

        public string TitleOfProductList { get; set; }
    }
}
