using Hotel_Managements_System.Data;
using Hotel_Managements_System.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Hotel_Managements_System.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;
        public HomeController(ApplicationDbContext context)
        {
            _context = context; 
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult BuyForm()
        {
            return View();
        }

        public IActionResult HotelModule()
        {
            return View();
        }

        public IActionResult RoomDetails() {
            return View();

        }

        public IActionResult AddHotel()
        {
            return View();

        }

        public IActionResult createNewHotel(Hotel hotel)
        {
            
            _context.hotel.Add(hotel);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}