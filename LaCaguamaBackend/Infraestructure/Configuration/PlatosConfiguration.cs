using LaCaguamaBackend.Domain.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace LaCaguamaBackend.Infraestructure.Configuration
{
    public class PlatosConfiguration : IEntityTypeConfiguration<Platos>
    {
        public void Configure(EntityTypeBuilder<Platos> builder)
        {
            builder.ToTable("Platos");

            builder.HasKey(e => e.PlatoID);
            builder.Property(e => e.Nombre_Plato).IsRequired().HasMaxLength(255);
            builder.Property(e => e.Precio_Unitario).IsRequired();
            builder.Property(e => e.Descripcion).IsRequired().HasMaxLength(400);
            builder.HasOne(e => e.Extra).WithMany().HasForeignKey(e => e.Extra_ID);
        }
    }
}
