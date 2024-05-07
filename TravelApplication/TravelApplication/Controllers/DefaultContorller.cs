using Microsoft.AspNetCore.Mvc;

namespace TravelApplication.Controllers
{
    public class DefaultContorller : Controller
    {
        Context c= new Context();
        public IActionResult Index()
        {
            var degerler = c.Blogs.Take(10).ToList();
            return View(degerler);
        }

        public ViewResult About()
        {
            return View();
        }
        public PartialViewResult Partial1()
            
        {
            var degerler = c.Blogs.OrderByDescending(x => x.ID ).Take(2).ToList();
            return PartialView(degerler);
        }
    }
}
