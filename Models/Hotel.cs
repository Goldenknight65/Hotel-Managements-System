using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace Hotel_Managements_System.Models
{
    public class Hotel
    {
        [Key]
        private int id;
        [Required]
        [StringLength(25)]
        private string name;
        [Required]
        [StringLength(100)]
        private string address;
        [Required]
        [StringLength(25)]
        private string city;
     
        [Required]
        private string image;

        public Hotel()
        {
        }

        public Hotel(int id, string name, string address, string city,
            string image)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.city = city;
            this.image = image;
        }

        public int Id { get => Id; set => Id = value; }
        public string Name { get => Name; set => Name = value; }
        public string Address { get => Address; set => Address = value; }
        public string City { get => City; set => City = value; }
        public string Image { get => Image; set => Image = value; }

    }
}
