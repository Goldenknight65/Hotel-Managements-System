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

		public IActionResult DeleteHotel(int id)
		{
			var removeHotel = _context.hotel.SingleOrDefault(x => x.id == id);
			if (removeHotel != null)
			{
				_context.hotel.Remove(removeHotel);
				_context.SaveChanges();
				TempData["messageState"] = "1";
                TempData["message"] = "تم حذف الفندق " + removeHotel.name;
			
			}
			return RedirectToAction("Index");
		}


		public IActionResult EditHotel(int id)
		{
			var hotel = _context.hotel.SingleOrDefault(x => x.id == id);
			return View(hotel);
		}

        public IActionResult HotelDetails(int id)
        {
            var hotel = _context.hotel.SingleOrDefault(x => x.id == id);
			ViewBag.hotel = hotel;
			return View();
        }


        public IActionResult Update(Hotel hotel)
		{
			_context.hotel.Update(hotel);
			_context.SaveChanges();
			return RedirectToAction("Index");
		}
	}
}
