using Microsoft.AspNetCore.Mvc;

namespace TravelApplication.Controllers
{
    public class IletisimController :Controller
    {
        Context c = new Context();
        public ActionResult Index()
        {
            var degerler = c.Iletisims.ToList();
            return View(degerler);
        }
    }
}
