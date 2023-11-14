using System.ComponentModel.DataAnnotations;

namespace Hotel_Managements_System.Models
{
	public class Client
	{
		[Key]
		public int id { get; set; }
		public string name { get; set; }
		public int age { get; set; }
		public string phone { get; set; }
		public string email { get; set; }
		public string invoiceid { get; set; }

		public Client(){}
		public Client(int id, string name, int age, string phone, string email, string invoiceid)
		{
			this.id = id;
			this.name = name;
			this.age = age;
			this.phone = phone;
			this.email = email;
			this.invoiceid = invoiceid;
		}
	}
}
