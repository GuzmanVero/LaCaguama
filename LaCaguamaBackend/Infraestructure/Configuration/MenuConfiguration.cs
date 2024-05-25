using LaCaguamaBackend.Domain.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace LaCaguamaBackend.Infraestructure.Configuration
{
    public class MenuConfiguration : IEntityTypeConfiguration<Menu>
    {
        public void Configure(EntityTypeBuilder<Menu> builder)
        {
            builder.ToTable("Menu");

            builder.HasKey(e => e.MenuID);
            builder.HasOne(e => e.Platos).WithMany().HasForeignKey(e => e.Plato_ID);
            builder.HasOne(e => e.Bebidas).WithMany().HasForeignKey(e => e.Bebida_ID);
        }
    }
}
