using LaCaguamaBackend.Domain.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace LaCaguamaBackend.Infraestructure.Configuration
{
    public class ExtraConfiguration : IEntityTypeConfiguration<Extra>
    {
        public void Configure(EntityTypeBuilder<Extra> builder)
        {
            builder.ToTable("Extra");

            builder.HasKey(e => e.ExtraID);
            builder.Property(e => e.Nombre).IsRequired().HasMaxLength(255);
            builder.Property(e => e.PrecioUnitario).IsRequired();
        }
    }
}
