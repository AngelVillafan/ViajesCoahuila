using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ViajesCoahuilaAPI.Configurations
{
    public class UsuariosConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("usuario");

            builder.HasKey(x => x.Id)
                .HasName("id");
            builder.Property(x => x.Alias)
                .HasMaxLength(30)
                .IsRequired()
                .HasColumnName("alias")
                .HasColumnType("varchar");
            builder.Property(x => x.Nombre)
                .HasMaxLength(60)
                .HasColumnName("nombre")
                .HasColumnType("varchar")
                .IsRequired();
            builder.Property(x=>x.Telefono)
                .HasColumnName("telefono")
                .HasColumnType("varchar(10)")
                
                .IsRequired();
            builder.Property(x => x.CalificacionChofer)
                .HasColumnName("calif_chofer")
                .HasColumnType("float")
                .HasDefaultValue(0);
            builder.Property(x=>x.CalificacionPasajero)
                .HasColumnName("calif_pasajero")
                .HasColumnType("float")
                .HasDefaultValue(0);
            
        }
    }
}
