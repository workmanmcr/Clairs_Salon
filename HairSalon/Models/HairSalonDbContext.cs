using Microsoft.EntityFrameworkCore;

namespace HairSalon.Models
{
    public class HairSalonDbContext : DbContext
    {
        public virtual DbSet<Stylist> Stylists { get; set; }
        public DbSet<Client>  Clients { get; set; }
        public HairSalonDbContext(DbContextOptions options) : base(options) { }
    }
}