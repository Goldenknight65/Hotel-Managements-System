using System.ComponentModel.DataAnnotations;

namespace Hotel_Managements_System.Models
{
    public class Cart
    {
        [Key]
        public int id { set; get; }
        [Required]
        public int hotelid { set; get; }
        [Required]
        public int roomid { set; get; }
     
        [Required]
        public double price { set; get; }
        [Required]
        public int userid { set; get; }
        public Cart() { }

        public Cart(int id, int hotelid, int roomid,
            double price, int userid)
        {
            this.id = id;
            this.hotelid = hotelid;
            this.roomid = roomid;
         
            this.price = price;
            this.userid = userid;
        }
       
    }
}
