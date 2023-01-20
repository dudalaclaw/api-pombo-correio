using Microsoft.EntityFrameworkCore;
using pomboCorreio.Models;

namespace pomboCorreio.Data
{
    public class PomboCorreioContext : DbContext
    {
        public PomboCorreioContext(DbContextOptions<PomboCorreioContext> opts)
            : base(opts)
        {

        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Lembrete> Lembrete { get; set; }
    }
}
