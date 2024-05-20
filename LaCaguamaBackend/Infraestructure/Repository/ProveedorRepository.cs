using LaCaguamaBackend.Application.Dtos;
using LaCaguamaBackend.Domain.Interface;
using Microsoft.EntityFrameworkCore;

namespace LaCaguamaBackend.Infraestructure.Repository
{
    public class ProveedorRepository : IProveedorRepository
    {
        private readonly LaCaguamaDbContext _context;
        public ProveedorRepository(LaCaguamaDbContext context)
        {
            _context = context;
        }

        public async Task<List<ProveedorNameDto>> GetAllProveedoresName()
        {
            var query = from p in _context.Proveedores
                        select new ProveedorNameDto
                        {
                            Nombre = p.Nombre
                        };
            return await query.ToListAsync();
        }

        public async Task<List<ProveedorDto>> GetAllProveedoresWithBebidas()
        {
            var query = from p in _context.Proveedores
                        join i in _context.Inventarios on p.ProveedorID equals i.Proveedor_ID
                        select new ProveedorDto
                        {
                            Nombre = p.Nombre,
                            NombreBebida = i.NombreBebida,
                            Telefono = p.Telefono,
                            Direccion = p.Direccion
                        };
            return await query.ToListAsync();
        }
    }
}
