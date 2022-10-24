using Microsoft.EntityFrameworkCore;

namespace proj_ong_backend.Models
{
    public class ApplicationDbContext : DbContext 
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Doador> Doadores { get; set; }
        
    }
}
