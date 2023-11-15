using System.ComponentModel.DataAnnotations;

namespace Hotel_Managements_System.Models
{
    public class User

    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        
        public string phone {  get; set; }
    }
}
