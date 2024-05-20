using LaCaguamaBackend.Domain.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace LaCaguamaBackend.Infraestructure.Configuration
{
    public class UsuariosConfiguration : IEntityTypeConfiguration<Usuarios>
    {
        public void Configure(EntityTypeBuilder<Usuarios> builder)
        {
            builder.ToTable("Usuarios");

            builder.HasKey(e => e.UsuarioID);
            builder.Property(e => e.Nombre).IsRequired().HasMaxLength(255);
            builder.Property(e => e.Contrasena).IsRequired().HasMaxLength(255);
            builder.HasOne(e => e.Empleado).WithMany().HasForeignKey(e => e.Empleado_ID);
        }
    }
}
