using Microsoft.EntityFrameworkCore;
using TsdNetCoreLab6_EF.Models;


namespace TsdNetCoreLab_EF.Entities
{
  
    public class TsdAppDbContext : DbContext
    {
        
        public TsdAppDbContext(DbContextOptions<TsdAppDbContext> tsdOptions) : base(tsdOptions)
        {
        }

   
        public DbSet<TsdCategory> TsdCategories { get; set; }
        public DbSet<TsdProducts> TsdProducts { get; set; }
    }
}
