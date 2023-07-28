using Microsoft.EntityFrameworkCore;

namespace HairSalon.Models
{
  public class HairSalonDbContext : DbContext
  {
    public HairSalonDbContext(DbContextOptions
    options) : base(options) { }
  }
}