using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;

namespace Hotel_Managements_System.Models
{
    public class Rooms
    {
        [Key]
        private int id;
        private string type;
        private string feature;
        private double price;
        private string image;
        private string room_number;
        private int hotelid;

        public Rooms(int id, string type, string feature, double price,
            string image, string room_number, int hotelid)
        {
            this.id = id;
            this.type = type;
            this.feature = feature;
            this.price = price;
            this.image = image;
            this.room_number = room_number;
            this.hotelid = hotelid;
        }
       public int Id { get => Id; set => Id = value; }
        public string Type { get => Type; set => Type = value; }
        public string Feature { get => Feature; set => Feature = value; }

        public double Price { get => Price; set => Price = value; }
        public string Image { get => Image; set => Image = value; }
        public int Hotelid { get => Hotelid; set => Hotelid = value; }
        
    }
}
