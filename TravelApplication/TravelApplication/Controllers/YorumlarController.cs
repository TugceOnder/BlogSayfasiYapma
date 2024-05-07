using Microsoft.AspNetCore.Mvc;
using TravelApplication.Models.Siniflar;
using TravelApplication.Models.Siniflar.Modeller;

namespace TravelApplication.Controllers
{
    public class YorumlarController : Controller // Controller sınıfından türetilmiş
    {
        Context c = new Context();
        public ActionResult Index() // IActionResult kullanmak daha esnek olabilir
        {
            YorumlarModel by = new YorumlarModel();
            //var blogbul = c.Blogs.Where(x=>x.ID == id).ToList();
            by.Blogs = c.Blogs.ToList();
            by.Yorumlars = c.Yorumlars.ToList();
            return View(by);
        }
    }
}
