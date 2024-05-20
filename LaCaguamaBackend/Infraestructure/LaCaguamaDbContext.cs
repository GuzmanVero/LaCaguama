using Microsoft.EntityFrameworkCore;
using System.Net;
using System.Reflection;
using System;
using LaCaguamaBackend.Domain.Models;
using Microsoft.AspNetCore.Components.Web.Virtualization;

namespace LaCaguamaBackend.Infraestructure
{
    public class LaCaguamaDbContext : DbContext
    {
        public LaCaguamaDbContext()
        {
        }

        public LaCaguamaDbContext(DbContextOptions<LaCaguamaDbContext> options)
        : base(options)
        {
        }

        public virtual DbSet<Bebidas> Bebidas{ get; set; }
        public virtual DbSet<Categoria> Categorias{ get; set; }
        public virtual DbSet<Empleado> Empleados{ get; set; }
        public virtual DbSet<Extra> Extras{ get; set; }
        public virtual DbSet<Factura> Facturas{ get; set; }
        public virtual DbSet<Inventario> Inventarios{ get; set; }
        public virtual DbSet<Menu> Menus{ get; set; }
        public virtual DbSet<Mesa> Mesas{ get; set; }
        public virtual DbSet<Ordenes> Ordenes{ get; set; }
        public virtual DbSet<Pedidos> Pedidos{ get; set; }
        public virtual DbSet<Platos> Platos{ get; set; }
        public virtual DbSet<Proveedor> Proveedores { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<TipoPago> TipoPagos{ get; set; }
        public virtual DbSet<Usuarios> Usuarios{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
