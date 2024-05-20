using LaCaguamaBackend.Domain.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace LaCaguamaBackend.Infraestructure.Configuration
{
    public class CategoriaConfiguration : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.ToTable("Categoria");

            builder.HasKey(e => e.CategoriaID);
            builder.Property(e => e.Tipo).IsRequired().HasMaxLength(255);
        }
    }
}
