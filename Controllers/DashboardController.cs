using Hotel_Managements_System.Data;
using Hotel_Managements_System.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Hotel_Managements_System.Controllers
{
    public class DashboardController : Controller
    {

        private readonly ApplicationDbContext _context;
        public DashboardController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var hotels = _context.hotel.ToList();
            return View(hotels);
            /*    ViewBag.hotels = hotels;
                  return View();*/
        }

		public IActionResult createNewHotel(Hotel hotel)
		{

			_context.hotel.Add(hotel);
			_context.SaveChanges();
			return RedirectToAction("Index");

		}
	}
}
