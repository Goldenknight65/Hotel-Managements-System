using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;

namespace Hotel_Managements_System.Models
{
    public class Rooms
    {
        [Key]
        public int id { set; get; }
        public string type { set; get; }
        public double price { set; get; }
        public string image { set; get; }
        public string room_number { set; get; }
        public int hotelid { set; get; }
         
        public Rooms() { }
        public Rooms(int id, string type, double price,
            string image, string room_number, int hotelid)
        {
            this.id = id;
            this.type = type;
            this.price = price;
            this.image = image;
            this.room_number = room_number;
            this.hotelid = hotelid;
        }
 
        
    }
}
