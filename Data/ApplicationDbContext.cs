using Hotel_Managements_System.Models;
using Microsoft.EntityFrameworkCore;

namespace Hotel_Managements_System.Data

{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Cart> cart { set; get; }
        public DbSet<Hotel> hotel { set; get; }
        public DbSet<Invoice> Invoice { set; get; }
        public DbSet<RoomDetails> roomDetails { set; get; }
        public DbSet<Rooms> rooms { set; get; }
    }
}
    

