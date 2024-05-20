using LaCaguamaBackend.Application.Dtos;
using LaCaguamaBackend.Domain.Interface;
using Microsoft.EntityFrameworkCore;

namespace LaCaguamaBackend.Infraestructure.Repository
{
    public class MesaRepository : IMesaRepository
    {
        private readonly LaCaguamaDbContext _context;
        public MesaRepository(LaCaguamaDbContext context)
        {
            _context = context;
        }

        public async Task<List<MesasDto>> GetAllMesas()
        {
            var query = from m in _context.Mesas
                        select new MesasDto
                        {
                            NombreMesa = m.Nombre_Mesa
                        };
            return await query.ToListAsync();
        }
    }
}
