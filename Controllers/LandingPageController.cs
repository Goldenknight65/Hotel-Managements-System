using Microsoft.AspNetCore.Mvc;

namespace Hotel_Managements_System.Controllers
{
    public class LandingPageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
