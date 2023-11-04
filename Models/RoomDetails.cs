using System.ComponentModel.DataAnnotations;

namespace Hotel_Managements_System.Models
{
    public class RoomDetails
    {
        [Key]
        private int id;
        private string image;
        private string food;
        private int roomid;

        public RoomDetails(int id, string image, string food, int roomid)
        {
            this.id = id;
            this.image = image;
            this.food = food;
            this.roomid = roomid;
        }

        public int Id { get => Id; set => Id = value; }
        public string Image { get => Image;set => Image = value; }
        public string Food { get => Food; set => Food = value; }
        public int Roomid { get => Roomid; set => Roomid = value; }
    }

}
