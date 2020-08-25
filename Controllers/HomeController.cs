using Microsoft.AspNetCore.Mvc;

namespace Commander.Controllers
{
    // [Route("home")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}