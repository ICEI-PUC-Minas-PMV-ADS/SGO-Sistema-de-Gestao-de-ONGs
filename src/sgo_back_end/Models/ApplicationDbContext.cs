using Microsoft.EntityFrameworkCore;
using SGO_Sistema_de_Gestao_ONGs.Models;

namespace sgo_back_end.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Doador> Doadores { get; set; }
        public DbSet<Voluntario> Voluntarios { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
