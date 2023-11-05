using System.ComponentModel.DataAnnotations;

namespace Hotel_Managements_System.Models
{
    public class RoomDetails
    {
        [Key]
        private int id;
        [Required]
        private string image;
        [Required]
        private string food;
        [Required]
        private int roomid;
        [Required]
        private string feature;
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
        public string Feature { get => Feature; set => Feature = value; }

    }

}
