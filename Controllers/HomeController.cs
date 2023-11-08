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
            var hotels = _context.hotel.ToList();
            return View(hotels);
            /*    ViewBag.hotels = hotels;
                  return View();*/
        }
        public IActionResult ViewRoom(int id) {
            var hotel = _context.hotel.SingleOrDefault(x => x.id == id);
            return RedirectToAction("RoomDetails");
        }

        public IActionResult EditHotel(int id)
        {
            var hotel = _context.hotel.SingleOrDefault(x=>x.id ==id);
            return View(hotel);
        }
        public IActionResult Update(Hotel hotel)
        {
            _context.hotel.Update(hotel);
            _context.SaveChanges();
            return RedirectToAction("HotelModule");
        }
        public IActionResult DeleteHotel(int id)
        {
            var removeHotel = _context.hotel.SingleOrDefault(x => x.id == id);
            _context.hotel.Remove(removeHotel);
            _context.SaveChanges();
            return RedirectToAction("HotelModule");
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