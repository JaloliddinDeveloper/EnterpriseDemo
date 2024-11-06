using Microsoft.AspNetCore.Mvc;

namespace OnlineBazar.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
