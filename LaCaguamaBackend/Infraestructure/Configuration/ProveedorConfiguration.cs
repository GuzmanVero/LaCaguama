using LaCaguamaBackend.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LaCaguamaBackend.Infraestructure.Configuration
{
    public class ProveedorConfiguration : IEntityTypeConfiguration<Proveedor>
    {
        public void Configure(EntityTypeBuilder<Proveedor> builder)
        {
            builder.ToTable("Proveedor");

            builder.HasKey(e => e.ProveedorID);
            builder.Property(e => e.Nombre).IsRequired().HasMaxLength(255);
            builder.Property(e => e.Telefono).IsRequired().HasMaxLength(255);
            builder.Property(e => e.Direccion).IsRequired().HasMaxLength(255);
        }
    }
}
