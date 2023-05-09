using Microsoft.EntityFrameworkCore;
using ViajesCoahuilaAPI.Configurations;
using ViajesCoahuilaAPI.Models;

namespace ViajesCoahuilaAPI.Data
{
    public class ViajesContext:DbContext
    {
        public ViajesContext(DbContextOptions<ViajesContext> options):base(options)
        {
           
        }
        public ViajesContext()
        {

        }
        public DbSet<Usuario>   Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Usuario>(new UsuariosConfiguration());
        }

        
    }
}
