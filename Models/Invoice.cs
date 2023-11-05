using System.ComponentModel.DataAnnotations;

namespace Hotel_Managements_System.Models
{
    public class Invoice
    {
        [Key]
        private int id;
        [Required]
        private Cart cart;
        [Required]
        private double tax;
        [Required]
        private double total;
        [Required]
        private double discount;
        [Required]
        private DateOnly from;
        [Required]
        private DateOnly to;
        [Required]
        private double net;
        [Required]
        private DateOnly invoiceDate;

        public Invoice(int id, Cart cart, double tax, double total, 
            double discount, DateOnly from, DateOnly to, double net, DateOnly invoiceDate)
        {
            this.id = id;
            this.cart = cart;
            this.tax = tax;
            this.total = total;
            this.discount = discount;
            this.from = from;
            this.to = to;
            this.net = net;
            this.invoiceDate = invoiceDate;
        }

        public int Id { get => id; set => id = value; }
        public Cart Cart { get => cart; set => cart = value; }
        public double Tax { get => tax; set => tax = value; }
        public double Total { get => total; set => total = value; }
        public double Discount { get => discount; set => discount = value; }
        public DateOnly From { get => from; set => from = value; }
        public DateOnly To { get => to; set => to = value; }
        public double Net { get => net; set => net = value; }
        public DateOnly InvoiceDate { get => invoiceDate; set => invoiceDate = value; }

    }
}
