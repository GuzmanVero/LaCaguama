using LaCaguamaBackend.Domain.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace LaCaguamaBackend.Infraestructure.Configuration
{
    public class BebidasConfiguration : IEntityTypeConfiguration<Bebidas>
    {
        public void Configure(EntityTypeBuilder<Bebidas> builder)
        {
            builder.ToTable("Bebidas");

            builder.HasKey(e => e.BebidaID);
            builder.Property(e => e.PrecioUnitario).IsRequired();
            builder.HasOne(e => e.Categoria).WithMany().HasForeignKey(e => e.Categoria_ID);
            builder.HasOne(e => e.Inventario).WithMany().HasForeignKey(e => e.Inventario_ID);
        }
    }
}
