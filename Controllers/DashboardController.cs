using Hotel_Managements_System.Data;
using Hotel_Managements_System.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Hotel_Managements_System.Controllers
{
    public class DashboardController : Controller
    {

        private readonly ApplicationDbContext _context;
        public DashboardController(ApplicationDbContext context)
        {
            _context = context;
        }
		[Authorize]
        public IActionResult Index()
        {
            var hotels = _context.hotel.ToList();
			
			//user name from login 
			var user = HttpContext.User.Identity.Name;
			
			//View bag
			ViewBag.user = user;
			
			//cookies
			CookieOptions option = new CookieOptions();
			Response.Cookies.Append("user",user,option);
			
			//session 


            return View(hotels);
            /*    ViewBag.hotels = hotels;
                  return View();*/
        }
		[HttpPost]
		public IActionResult Index(string city)
		{
		
			var user = HttpContext.User.Identity.Name;
			ViewBag.user = user;
			CookieOptions option = new CookieOptions();
			Response.Cookies.Append("user", user, option);

			if (city == "all")
			{
				var allhotels = _context.hotel.ToList();

				return View(allhotels);
			}

			ViewBag.user = user;
			var hotels = _context.hotel.Where(x => x.city.Equals(city));
			return View(hotels);
			/*    ViewBag.hotels = hotels;
                  return View();*/
		}

		public IActionResult Rooms()
		{
			var user = HttpContext.User.Identity.Name;
			ViewBag.user = user;
			var Rooms = _context.rooms.ToList();
			var hotels = _context.hotel.ToList();
			ViewBag.hotels = hotels;
			return View(Rooms);
			/*    ViewBag.hotels = hotels;
                  return View();*/
		}
		public IActionResult createNewHotel(Hotel hotel)
		{
			if(ModelState.IsValid)
			{
				_context.hotel.Add(hotel);
				_context.SaveChanges();
				return RedirectToAction("Index");
			}

			/*_context.hotel.Add(hotel);
			_context.SaveChanges();*/
			var hotels = _context.hotel.ToList();
			return View("Index",hotels);

		}
		public IActionResult createNewRoomA(Rooms room)
		{
			var hotels = _context.hotel.ToList();
			ViewBag.hotels = hotels;
			_context.rooms.Add(room);
			_context.SaveChanges();
			return RedirectToAction("Rooms");
		}
		public IActionResult createNewRoomD(Rooms room)
        {
            _context.rooms.Add(room);
            _context.SaveChanges();
            return RedirectToAction("HotelDetails", new { id = room.hotelid });

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

		public IActionResult DeleteRoomIndex(int id)
		{
            var removeRoom = _context.rooms.SingleOrDefault(x => x.id == id);
            if (removeRoom != null)
            {
                _context.rooms.Remove(removeRoom);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

		public IActionResult DeleteRoom(int id)
		{
			var removeRoom = _context.rooms.SingleOrDefault(x => x.id == id);
			if (removeRoom != null)
			{
				_context.rooms.Remove(removeRoom);
				_context.SaveChanges();
			}
			return RedirectToAction("Rooms");
		}

        public IActionResult DeleteRoomD(int id)
        {
            var room = _context.rooms.FirstOrDefault(x => x.id == id);

            var removeRoom = _context.rooms.SingleOrDefault(x => x.id == id);
            if (removeRoom != null)
            {
                _context.rooms.Remove(removeRoom);
                _context.SaveChanges();
            }

            var rooms = _context.rooms.Where(r => r.hotelid == id).ToList();
            var hotel = _context.hotel.SingleOrDefault(x => x.id == room.hotelid);


            ViewBag.hotel = hotel;
            ViewBag.rooms = rooms;
            var hotelid = id;
            return RedirectToAction("HotelDetails", new { id = room.hotelid });
        }

        public IActionResult EditHotel(int id)
		{
			var hotel = _context.hotel.SingleOrDefault(x => x.id == id);
			return View(hotel);
		}

		public IActionResult EditRoom(int id)
		{
			var room = _context.rooms.SingleOrDefault(x => x.id == id);
			var hotels = _context.hotel.ToList();
			ViewBag.hotels = hotels;
			return View(room);
		}


		public IActionResult UpdateRoom(Rooms room)
		{
            if (ModelState.IsValid)
			{
                _context.rooms.Update(room);
                _context.SaveChanges();
                return RedirectToAction("Rooms");
            }
            var ro = _context.rooms.SingleOrDefault(x => x.id == room.id);
            var hotels = _context.hotel.ToList();
            ViewBag.hotels = hotels;
            return View("EditRoom");
		}
		public IActionResult HotelDetails(int id)
        {
            var hotel = _context.hotel.SingleOrDefault(x => x.id == id);

            var rooms = _context.rooms.Where(r => r.hotelid == id).ToList();
            ViewBag.hotel = hotel;
			ViewBag.rooms = rooms;
			return View();
        }


        public IActionResult Update(Hotel hotel)
		{
			if (ModelState.IsValid)
			{
                _context.hotel.Update(hotel);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
			
			return View("EditHotel");
		}



	}
}
