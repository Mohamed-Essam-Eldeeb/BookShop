using BookShop.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BookShop.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }


        public DbSet<Book> Book { get; set; }
        public DbSet<CartDetail> CartDetail{ get; set; }
        public DbSet<Genre> Genre{ get; set; }
        public DbSet<Order> Order{ get; set; }
        public DbSet<OrderDetail> OrderDetail{ get; set; }
        public DbSet<OrderStatus> OrderStatus{ get; set; }
        public DbSet<ShoppingCart> ShoppingCart{ get; set; }


    }
}
