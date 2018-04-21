using Microsoft.EntityFrameworkCore;

namespace FreshMarqueSnails.Models
{
    public class SupplierContext : DbContext
    {
        public SupplierContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Supplier> Supplier { get; set; }
    }
}