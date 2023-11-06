using System.ComponentModel.DataAnnotations;

namespace Hotel_Managements_System.Models
{
    public class RoomDetails
    {
        [Key]
        public int id { set; get; }
        [Required]
        public string image { set; get; }
        [Required]
        public string food { set; get; }
        [Required]
        public int roomid { set; get; }
        [Required]
        public string feature { set; get; }
        public RoomDetails() { }
        public RoomDetails(int id, string image, string food, int roomid)
        {
            this.id = id;
            this.image = image;
            this.food = food;
            this.roomid = roomid;
        }

 

    }

}
