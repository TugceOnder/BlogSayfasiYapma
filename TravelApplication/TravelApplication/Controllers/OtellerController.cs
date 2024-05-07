using Microsoft.AspNetCore.Mvc;
using TravelApplication.Models.Siniflar.Modeller;

namespace TravelApplication.Controllers
{
    public class OtellerController : Controller
    {
        Context c = new Context();

        public ViewResult Index()
        {
            // Oteller verilerini almak yerine, OtelModel sınıfından bir model oluşturun
            var otelModel = new OtelModel
            {
                Otellers = c.Otellers.ToList()
            };

            // OtelModel'i View'a gönderin
            return View(otelModel);
        }
    }
}
