using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace Hotel_Managements_System.Models
{
    public class Invoice
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

        
        public Invoice() { }
        public Invoice(int id, int cartId, double tax, double total, double discount, DateTime from, DateTime to, double net, DateTime invoiceDate)
        {
            this.id = id;
            this.cartId = cartId;
            this.tax = tax;
            this.total = total;
            this.discount = discount;
            this.from = from;
            this.to = to;
            this.net = net;
            this.invoiceDate = invoiceDate;
        }
    }
}
