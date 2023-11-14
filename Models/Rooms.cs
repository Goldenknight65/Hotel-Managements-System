using System.ComponentModel.DataAnnotations;

namespace Hotel_Managements_System.Models
{
    public class Rooms
    {
        [Key]
        public int id { set; get; }
		[Required]

		public string type { set; get; }
		[Required]

		public double price { set; get; }
		[Required]

		public string image { set; get; }
		[Required]

		public string room_number { set; get; }
		[Required]

		public int hotelid { set; get; }
		[Required]

		public string food { set; get; }
		[Required]

		public string feature { set; get; }


		public Rooms() { }

		public Rooms(int id, string type, double price, string image, string room_number, int hotelid, string food, string feature)
		{
			this.id = id;
			this.type = type;
			this.price = price;
			this.image = image;
			this.room_number = room_number;
			this.hotelid = hotelid;
			this.food = food;
			this.feature = feature;
		}
	}
}
