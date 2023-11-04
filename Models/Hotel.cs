using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace Hotel_Managements_System.Models
{
    public class Hotel
    {
        [Key]
        private int id;
        private string name;
        private string address;
        private string city;
        private string country;
        private string image;

        public Hotel()
        {
        }

        public Hotel(int id, string name, string address, string city,
            string country, string image)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.city = city;
            this.country = country;
            this.image = image;
        }

        public int Id { get => Id; set => Id = value; }
        public string Name { get => Name; set => Name = value; }
        public string Address { get => Address; set => Address = value; }
        public string City { get => City; set => City = value; }
        public string Country { get => Country; set => Country = value; }
        public string Image { get => Image; set => Image = value; }

    }
}
