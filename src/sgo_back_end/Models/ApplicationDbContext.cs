using Microsoft.EntityFrameworkCore;

namespace sgo_back_end.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Doador> Doadores { get; set; }
        public DbSet<Voluntario> Voluntarios { get; set; }
    }
}
