using Microsoft.AspNetCore.Mvc;
using TravelApplication.Models.Siniflar;

namespace TravelApplication.Controllers
{
    public class AboutController : Controller
    {
        Context c = new Context();
        public ViewResult Index()
        {
            var degerler = c.Hakkimizdas.ToList();
            return View(degerler);
        }
    }
}
