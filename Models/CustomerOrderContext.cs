using Microsoft.EntityFrameworkCore;

namespace FreshMarqueSnails.Models
{
    public class CustomerOrderContext : DbContext
    {
        public CustomerOrderContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<CustomerOrder> CustomerOrder { get; set; }
    }
}