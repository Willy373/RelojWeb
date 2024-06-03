using Microsoft.EntityFrameworkCore;
using RelojWeb.Models;

namespace RelojWeb.Context
{
    public class RelojContext : DbContext
    {
        public RelojContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Reloj> Relojes { get; set; }
        public DbSet<Venta> Ventas { get; set; }
        
    }

}
