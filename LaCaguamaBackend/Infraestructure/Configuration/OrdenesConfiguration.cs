using LaCaguamaBackend.Domain.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace LaCaguamaBackend.Infraestructure.Configuration
{
    public class OrdenesConfiguration : IEntityTypeConfiguration<Ordenes>
    {
        public void Configure(EntityTypeBuilder<Ordenes> builder)
        {
            builder.ToTable("Ordenes");

            builder.HasKey(e => e.OrdenID);
            builder.Property(e => e.Cliente).IsRequired().HasMaxLength(255);
            builder.Property(e => e.Total).IsRequired();
            builder.Property(e => e.Descuento).IsRequired();
            builder.HasOne(e => e.TipoPagoNavigation).WithMany().HasForeignKey(e => e.Tipo_Pago);
            builder.HasOne(e => e.Usuarios).WithMany().HasForeignKey(e => e.Usuario_ID);
            builder.HasOne(e => e.Mesa).WithMany().HasForeignKey(e => e.Mesa_ID);
            builder.HasOne(e => e.Pedidos).WithMany().HasForeignKey(e => e.Pedido_ID);
        }
    }
}
