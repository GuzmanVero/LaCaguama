using LaCaguamaBackend.Domain.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace LaCaguamaBackend.Infraestructure.Configuration
{
    public class FacturaConfiguration : IEntityTypeConfiguration<Factura>
    {
        public void Configure(EntityTypeBuilder<Factura> builder)
        {
            builder.ToTable("Factura");

            builder.HasKey(e => e.FacturaID);
            builder.Property(e => e.Fecha_Factura).IsRequired();
            builder.HasOne(e => e.Ordenes).WithMany().HasForeignKey(e => e.Orden_ID);
        }
    }
}
