using Microsoft.EntityFrameworkCore;

namespace FreshMarqueSnails.Models
{
    public class SupplierContext : DbContext
    {
        public SupplierContext(DbContextOptions<SupplierContext> options) : base(options)
        {
            
        }

        public DbSet<Supplier> Supplier { get; set; }
    }
}