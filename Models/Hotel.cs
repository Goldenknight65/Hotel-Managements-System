using System.ComponentModel.DataAnnotations;

namespace Hotel_Managements_System.Models
{
    public class Hotel
    {
        [Key]
        public int id { set; get; }
        [Required]
        [StringLength(25)]
        public string name { set; get; }
        [Required]
        [StringLength(100)]
        public string address { set; get; }
        [Required]
        [StringLength(25)]
        public string city { set; get; }

        [Required]
        public string image { set; get; }
        public string phone { set; get; }
        public Hotel() { }


        public Hotel(int id, string name, string address, string city,
            string image, string phone)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.city = city;
            this.image = image;
            this.phone = phone;
        }


    }
}
