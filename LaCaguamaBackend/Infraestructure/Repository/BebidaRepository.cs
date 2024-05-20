using LaCaguamaBackend.Application.Dtos;
using LaCaguamaBackend.Domain.Interface;
using LaCaguamaBackend.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace LaCaguamaBackend.Infraestructure.Repository
{
    public class BebidaRepository : IBebidaRepository
    {
        private readonly LaCaguamaDbContext _context;
        public BebidaRepository(LaCaguamaDbContext context)
        {
            _context = context;
        }

        public async Task<List<BebidasDto>> GetAllBebidas(string nombre)
        {
            var query = from i in _context.Inventarios
                        join b in _context.Bebidas on i.InventarioID equals b.Inventario_ID
                        join c in _context.Categorias on b.Categoria_ID equals c.CategoriaID
                        where i.NombreBebida.ToLower().Contains(nombre.ToLower())
                        select new BebidasDto
                        {
                            NombreBebida = i.NombreBebida,
                            TipoCategoria = c.Tipo,
                            PrecioUnitario = b.PrecioUnitario
                        };
            return await query.ToListAsync();
        }

        public async Task<List<InventarioBebidaProveedorDto>> GetBebida(string proveedor, string categoria, string nombreBebida,
            int stock,decimal precioUnitario)
        {
            var proveedorEntity = await _context.Proveedores
            .FirstOrDefaultAsync(p => p.Nombre == proveedor);
            if (proveedorEntity == null)
            {
                throw new Exception("Proveedor no encontrado");
            }
            var categoriaEntity = await _context.Categorias
            .FirstOrDefaultAsync(c => c.Tipo == categoria);
            if (categoriaEntity == null)
            {
                throw new Exception("Categoría no encontrada");
            }
            var nuevoInventario = new Inventario
            {
                NombreBebida = nombreBebida, 
                Stock = stock, 
                Proveedor_ID = proveedorEntity.ProveedorID
            };
            _context.Inventarios.Add(nuevoInventario);
            await _context.SaveChangesAsync();

            var nuevaBebida = new Bebidas
            {
                PrecioUnitario = precioUnitario,
                Categoria_ID = categoriaEntity.CategoriaID,
                Inventario_ID = nuevoInventario.InventarioID
            };
            _context.Bebidas.Add(nuevaBebida);
            await _context.SaveChangesAsync();
            var dto = new InventarioBebidaProveedorDto
            {
                NombreBebida = nuevoInventario.NombreBebida,
                Stock = nuevoInventario.Stock,
                NombreProveedor = proveedorEntity.Nombre,
                TipoCategoria = categoriaEntity.Tipo,
                PrecioUnitario = nuevaBebida.PrecioUnitario
            };

            return new List<InventarioBebidaProveedorDto> { dto };
        }

        public async Task<List<BebidasDto>> GetBebidas()
        {
            var query = from i in _context.Inventarios
                        join b in _context.Bebidas on i.InventarioID equals b.Inventario_ID
                        join c in _context.Categorias on b.Categoria_ID equals c.CategoriaID
                        select new BebidasDto
                        {
                            NombreBebida = i.NombreBebida,
                            TipoCategoria = c.Tipo,
                            PrecioUnitario = b.PrecioUnitario
                        };
            return await query.ToListAsync();   
        }
    }
}
