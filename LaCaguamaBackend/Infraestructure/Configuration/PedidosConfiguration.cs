using LaCaguamaBackend.Domain.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace LaCaguamaBackend.Infraestructure.Configuration
{
    public class PedidosConfiguration : IEntityTypeConfiguration<Pedidos>
    {
        public void Configure(EntityTypeBuilder<Pedidos> builder)
        {
            builder.ToTable("Pedidos");

            builder.HasKey(e => e.PedidosID);
            builder.HasOne(e => e.Menu).WithMany().HasForeignKey(e => e.Menu_ID);
        }
    }
}
