using LaCaguamaBackend.Application.Dtos;
using LaCaguamaBackend.Domain.Interface;
using Microsoft.EntityFrameworkCore;

namespace LaCaguamaBackend.Infraestructure.Repository
{
    public class MenuRepository : IMenuRepository
    {
        private readonly LaCaguamaDbContext _context;
        public MenuRepository(LaCaguamaDbContext context)
        {
            _context = context;
        }

        public async Task<List<MenuDto>> GetAllMenu()
        {
            var query = from i in _context.Inventarios
                        join b in _context.Bebidas on i.InventarioID equals b.Inventario_ID
                        join m in _context.Menus on b.BebidaID equals m.Bebida_ID
                        join p in _context.Platos on m.Plato_ID equals p.PlatoID
                        select new MenuDto
                        {
                            NombreBebida = i.NombreBebida,
                            NombrePlato = p.Nombre_Plato
                        };
            return await query.ToListAsync();
        }
    }
}
