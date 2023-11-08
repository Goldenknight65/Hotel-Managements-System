using System.ComponentModel.DataAnnotations;

namespace Hotel_Managements_System.Models
{
    public class User

    {
        [Key]
        public int Id { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
    }
}
