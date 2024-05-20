using LaCaguamaBackend.Application.Dtos;
using LaCaguamaBackend.Domain.Interface;
using Microsoft.EntityFrameworkCore;

namespace LaCaguamaBackend.Infraestructure.Repository
{
    public class InventarioRepository : IInventarioRepository
    {
        private readonly LaCaguamaDbContext _context;
        public InventarioRepository(LaCaguamaDbContext context)
        {
            _context = context;
        }

        public async Task<List<InventarioDto>> GetInventoryByArtesanales()
        {
            var query = from inv in _context.Inventarios
                        join b in _context.Bebidas on inv.InventarioID equals b.Inventario_ID
                        join cat in _context.Categorias on b.Categoria_ID equals cat.CategoriaID
                        where cat.Tipo == "Artesanales"
                        select new InventarioDto
                        {
                            Tipo = cat.Tipo,
                            NombreBebida = inv.NombreBebida,
                            Stock = inv.Stock
                        };

            return await query.ToListAsync();
        }

        public async Task<List<InventarioDto>> GetInventoryByCategory()
        {
            var query = from inv in _context.Inventarios
                        join b in _context.Bebidas on inv.InventarioID equals b.Inventario_ID
                        join cat in _context.Categorias on b.Categoria_ID  equals cat.CategoriaID
                        select new InventarioDto
                        {
                            Tipo = cat.Tipo,
                            NombreBebida = inv.NombreBebida,
                            Stock = inv.Stock
                        };
            return await query.ToListAsync();
        }

        public async Task<List<InventarioDto>> GetInventoryByImportadas()
        {
            var query = from inv in _context.Inventarios
                        join b in _context.Bebidas on inv.InventarioID equals b.Inventario_ID
                        join cat in _context.Categorias on b.Categoria_ID equals cat.CategoriaID
                        where cat.Tipo == "Importadas"
                        select new InventarioDto
                        {
                            Tipo = cat.Tipo,
                            NombreBebida = inv.NombreBebida,
                            Stock = inv.Stock
                        };

            return await query.ToListAsync();
        }

        public async Task<List<InventarioDto>> GetInventoryByNacionales()
        {
            var query = from inv in _context.Inventarios
                        join b in _context.Bebidas on inv.InventarioID equals b.Inventario_ID
                        join cat in _context.Categorias on b.Categoria_ID equals cat.CategoriaID
                        where cat.Tipo == "Nacionales"
                        select new InventarioDto
                        {
                            Tipo = cat.Tipo,
                            NombreBebida = inv.NombreBebida,
                            Stock = inv.Stock
                        };

            return await query.ToListAsync();
    
        }

        public async Task<List<InventarioDto>> GetInventoryBySinAlcohol()
        {
            var query = from inv in _context.Inventarios
                        join b in _context.Bebidas on inv.InventarioID equals b.Inventario_ID
                        join cat in _context.Categorias on b.Categoria_ID equals cat.CategoriaID
                        where cat.Tipo == "Sin Alcohol"
                        select new InventarioDto
                        {
                            Tipo = cat.Tipo,
                            NombreBebida = inv.NombreBebida,
                            Stock = inv.Stock
                        };

            return await query.ToListAsync();
        }

        public async Task<List<InventarioDto>> GetInventoryBySiseFresea()
        {
            var query = from inv in _context.Inventarios
                        join b in _context.Bebidas on inv.InventarioID equals b.Inventario_ID
                        join cat in _context.Categorias on b.Categoria_ID equals cat.CategoriaID
                        where cat.Tipo == "Si se fresea"
                        select new InventarioDto
                        {
                            Tipo = cat.Tipo,
                            NombreBebida = inv.NombreBebida,
                            Stock = inv.Stock
                        };

            return await query.ToListAsync();
        }
    }
}
