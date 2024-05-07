using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TravelApplication.Models;

namespace TravelApplication.Controllers
{
    public class HomeController : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            var degerler = c.Blogs.ToList();
            return View(degerler);
        }

      




    }
}
