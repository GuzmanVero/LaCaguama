using LaCaguamaBackend.Domain.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace LaCaguamaBackend.Infraestructure.Configuration
{
    public class InventarioConfiguration : IEntityTypeConfiguration<Inventario>
    {
        public void Configure(EntityTypeBuilder<Inventario> builder)
        {
            builder.ToTable("Inventario");

            builder.HasKey(e => e.InventarioID);
            builder.Property(e => e.NombreBebida).IsRequired().HasMaxLength(255);
            builder.Property(e => e.Stock).IsRequired();
            builder.HasOne(e => e.Proveedor).WithMany().HasForeignKey(e => e.Proveedor_ID);
        }
    }
}
