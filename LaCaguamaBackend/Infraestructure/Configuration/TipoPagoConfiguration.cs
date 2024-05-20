using LaCaguamaBackend.Domain.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace LaCaguamaBackend.Infraestructure.Configuration
{
    public class TipoPagoConfiguration : IEntityTypeConfiguration<TipoPago>
    {
        public void Configure(EntityTypeBuilder<TipoPago> builder)
        {
            builder.ToTable("TipoPago");

            builder.HasKey(e => e.PagoID);
            builder.Property(e => e.Nombre).IsRequired().HasMaxLength(255);
        }
    }
}
