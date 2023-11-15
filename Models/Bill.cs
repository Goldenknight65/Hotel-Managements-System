using System.ComponentModel.DataAnnotations;

namespace Hotel_Managements_System.Models
{
    public class Bill
    {


        [Key]
        public int id { set; get; }
        [Required]
        public int cartId { set; get; }
        [Required]
        public double tax { set; get; }
        [Required]
        public double total { set; get; }
        [Required]
        public double discount { set; get; }
        [Required]
        public DateTime invoiceDate { set; get; }
        [Required]
        public DateTime from { set; get; }

        [Required]
        public DateTime to { set; get; }
        [Required]
        public double net { set; get; }
        [Required]
        public string name { get; set; }
        [Required]
        public string phone { get; set; }

        public Bill() { }

        public Bill(int id, int cartId, double tax, double total, double discount, DateTime invoiceDate, 
            DateTime from, DateTime to, double net, string name, string phone)
        {
            this.id = id;
            this.cartId = cartId;
            this.tax = tax;
            this.total = total;
            this.discount = discount;
            this.invoiceDate = invoiceDate;
            this.from = from;
            this.to = to;
            this.net = net;
            this.name = name;
            this.phone = phone;
        }
    }
}
