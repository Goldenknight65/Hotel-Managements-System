using System.ComponentModel.DataAnnotations;

namespace Hotel_Managements_System.Models
{
    public class Cart
    {
        [Key]
        private int id;
        [Required]
        private int hotelid;
        [Required]
        private int roomid;
        [Required]
        private int detailid;
        [Required]
        private double price;
        [Required]
        private int userid;

        public Cart(int id, int hotelid, int roomid,
            int detailid, double price, int userid)
        {
            this.id = id;
            this.hotelid = hotelid;
            this.roomid = roomid;
            this.detailid = detailid;
            this.price = price;
            this.userid = userid;
        }
        public int Id { get=>  id; set=> id = value; }
        public int Hotelid { get=> hotelid; set=> hotelid = value; }
        public int Roomid { get=> roomid; set=> roomid = value; }
        public int Detailid { get=> detailid; set=> detailid = value; }
        public double Price { get=> price; set=> price = value; }
        public int Userid { get=> userid; set=> userid = value; }
    }
}
