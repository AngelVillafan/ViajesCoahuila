using Microsoft.EntityFrameworkCore;
using ViajesCoahuilaAPI.Models;

namespace ViajesCoahuilaAPI.Data
{
    public class ViajesContext:DbContext
    {
        public DbSet<Usuario>   Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "database=viajes; password=root; user=root; server=localhost";
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString))
        }
    }
}
