using LaCaguamaBackend.Domain.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace LaCaguamaBackend.Infraestructure.Configuration
{
    public class EmpleadoConfiguration : IEntityTypeConfiguration<Empleado>
    {
        public void Configure(EntityTypeBuilder<Empleado> builder)
        {
            builder.ToTable("Empleado");

            builder.HasKey(e => e.EmpleadoID);
            builder.Property(e => e.Nombre).IsRequired().HasMaxLength(255);
            builder.Property(e => e.Apellido).IsRequired().HasMaxLength(255);
            builder.Property(e => e.Correo).IsRequired().HasMaxLength(255);
            builder.Property(e => e.Sexo).IsRequired().HasMaxLength(100);
            builder.Property(e => e.SueldoNeto).IsRequired();
            builder.Property(e => e.SueldoLiquido).IsRequired();
            builder.HasOne(e => e.Roles).WithMany().HasForeignKey(e => e.RolID);
        }
    }
}
