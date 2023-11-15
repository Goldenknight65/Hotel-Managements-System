using Hotel_Managements_System.Data;
using Hotel_Managements_System.Models;
using Humanizer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
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

        public IActionResult RentApplication( int id, DateTime from, DateTime to, string name,string phoneNumber)
        {
            User user = new User();
            user.phone = phoneNumber;
            user.name = name;

/*          
                _context.users.Add(user);
                _context.SaveChanges();
*/

       

        var room = _context.rooms.SingleOrDefault(x => x.id == id).price;

            TimeSpan difference = to.Subtract(from);
            int days = difference.Days;
            double rentprice = (room * days);





            Invoice invoice = new Invoice();
            invoice.from = from;
            invoice.to = to;
            invoice.invoiceDate = DateTime.Now;
            invoice.total = rentprice;
            invoice.tax = 15;
            invoice.net = rentprice + (rentprice * 0.15);


            Bill bill = new Bill();
            bill.from = from;
            bill.to = to;
            bill.invoiceDate = DateTime.Now;
            bill.total = rentprice;
            bill.tax = 15;
            bill.net = rentprice + (rentprice * 0.15);
            bill.name = user.name;
            bill.phone = user.phone;
            bill.discount = 0;

            _context.bills.Add(bill);
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