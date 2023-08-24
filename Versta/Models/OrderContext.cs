using Microsoft.EntityFrameworkCore;
using Versta.Entities;

namespace Versta.Models
{
    public class OrderContext : DbContext
    {
        public DbSet<OrderInfo> OrdersDB { get; set; }
        public OrderContext(DbContextOptions<OrderContext> options)
            : base(options)
        {
            //Database.EnsureCreated();
        }
    }
}


