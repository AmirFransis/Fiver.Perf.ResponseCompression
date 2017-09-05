using Microsoft.AspNetCore.Mvc;

namespace Fiver.Perf.ResponseCompression.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
