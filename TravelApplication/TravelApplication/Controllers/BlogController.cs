using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;
using TravelApplication.Models.Siniflar;
using TravelApplication.Models.Siniflar.Modeller;

namespace TravelApplication.Controllers
{
	public class BlogController : Controller
	{
		Context c = new Context();
		BlogYorum by = new BlogYorum();

		public ActionResult Index()
		{
			//	var bloglar = c.Blogs.ToList();
			by.Deger1 = c.Blogs.ToList();
			by.Deger3 = c.Blogs.Take(5).ToList();
			YorumYap();
			return View(by);
		}

		[HttpGet]
		public ActionResult BlogDetay(int id)
	    {
			BlogYorum by = new BlogYorum();
			//var blogbul = c.Blogs.Where(x=>x.ID == id).ToList();
			by.Deger1 = c.Blogs.Where(x => x.ID == id).ToList();
			by.Deger2 = c.Yorumlars.Where(x => x.BlogID == id).ToList();
			return View(by);
	   }

		[HttpGet]
		public ActionResult Delete(int id)
		{
			var prd = c.Blogs.SingleOrDefault(x => x.ID == id);
			var model = new BlogYorum { Deger1 = new List<Blog> { prd } }; // Tek bir blog öğesi içeren bir BlogYorum nesnesi oluştur
			return View(model); // BlogYorum türündeki modeli görünüme geçir
		}

		[HttpGet]
		public PartialViewResult YorumYap()
		{
			return PartialView();
		}

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var prd = c.Blogs.SingleOrDefault(x => x.ID == id);
            if (prd == null)
            {
                // Belirli bir ID'ye sahip blog bulunamadı, uygun bir hata işleme mekanizması uygula
                return View(prd);// 404 Not Found dönebilirsiniz, ya da başka bir uygun hata sayfasına yönlendirme yapabilirsiniz.
            }

            var model = new BlogEditModel { BlogToUpdate = prd };
            return View(model);
        }


        [HttpPost]
		public ActionResult Edit(BlogUpdateModel data)
		{
			var prd = c.Blogs.SingleOrDefault(x => x.ID == data.ID);
			if (prd != null)
			{
				prd.ID = data.ID;
				prd.Aciklama = data.Aciklama;
				c.Blogs.Update(prd);
				c.SaveChanges();
			}
			var model = new BlogEditModel();
			model.BlogToUpdate = prd;
			model.BlogList = c.Blogs.ToList();

			 return RedirectToAction("Index", "Blog");
		}

		[HttpGet]
		public ActionResult New()

		{
			Context c = new Context();
			var model = new BlogNewModel();


			model.BlogList = c.Blogs.ToList();
			model.YorumlarList = c.Yorumlars.ToList();

			return View(model);
		}

	/*	[HttpPost]
        public PartialViewResult YorumYap(Yorumlar y)
        {
			c.Yorumlars.Add(y);
			c.SaveChanges();
			return PartialView();
        }*/



		[HttpPost]
		public ActionResult New(BlogtInsertModel data)

		{
			//data objesindeki ürün listesini product tablosuna insert edeceğiz 
			//ürünü veri tabanındaki tabloya eklemiş olacağız
			var prd = new Blog();
			prd.Baslık = data.Baslık;
			prd.Tarih = data.Tarih;
			prd.Aciklama = data.Aciklama;
			prd.BlogImage = data.BlogImage;


			var c = new Context();
			c.Blogs.Add(prd);
			c.SaveChanges();

			var model = new BlogNewModel();

			model.BlogList = c.Blogs.ToList();
			model.YorumlarList = c.Yorumlars.ToList();
			model.OperationMessage = "Blog Ekleme  Başarılı";

            return RedirectToAction("Index", "Blog");
        }
		public ActionResult DeleteBlog(int id)
		{

			var prd = c.Blogs.SingleOrDefault(x => x.ID == id);

			
			c.Blogs.Remove(prd);
			c.SaveChanges();

			return RedirectToAction("Index", "Home");
			}
		}

	


}
