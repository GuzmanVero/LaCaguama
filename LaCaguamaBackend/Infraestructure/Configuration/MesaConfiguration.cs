using LaCaguamaBackend.Domain.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace LaCaguamaBackend.Infraestructure.Configuration
{
    public class MesaConfiguration : IEntityTypeConfiguration<Mesa>
    {
        public void Configure(EntityTypeBuilder<Mesa> builder)
        {
            builder.ToTable("Mesa");

            builder.HasKey(e => e.MesaID);
            builder.Property(e => e.Nombre_Mesa).IsRequired().HasMaxLength(255);
        }
    }
}
