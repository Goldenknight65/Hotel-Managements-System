using System.ComponentModel.DataAnnotations;

namespace Hotel_Managements_System.Models
{
    public class Invoice
    {
        [Key]
        private int id;
        private Cart cart;
        private double tax;
        private double total;
        private double discount;
        private DateOnly from;
        private DateOnly to;

        public Invoice(int id, Cart cart, double tax, double total, 
            double discount, DateOnly from, DateOnly to)
        {
            this.id = id;
            this.cart = cart;
            this.tax = tax;
            this.total = total;
            this.discount = discount;
            this.from = from;
            this.to = to;
        }

        public int Id { get => id; set => id = value; }
        public Cart Cart { get => cart; set => cart = value; }
        public double Tax { get => tax; set => tax = value; }
        public double Total { get => total; set => total = value; }
        public double Discount { get => discount; set => discount = value; }
        public DateOnly From { get => from; set => from = value; }
        public DateOnly To { get => to; set => to = value; }

    }
}
