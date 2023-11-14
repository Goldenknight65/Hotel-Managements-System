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
            var hotels = _context.hotel.ToList();
            return View(hotels);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult RentForm(int id)
        {
            var room = _context.rooms.SingleOrDefault(x => x.id == id);

            var hotel = _context.hotel.SingleOrDefault(x => x.id == room.hotelid);
            ViewBag.room = room.id;
            ViewBag.hotel = hotel.id;
            return View();
        }

        public IActionResult RoomList(int id)
        {
            var hotel = _context.hotel.SingleOrDefault(x => x.id == id);

            var rooms = _context.rooms.Where(r => r.hotelid == id).ToList();
            ViewBag.hotel = hotel;
            ViewBag.rooms = rooms;
            return View();
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}