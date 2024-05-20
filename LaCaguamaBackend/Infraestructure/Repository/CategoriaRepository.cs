using LaCaguamaBackend.Application.Dtos;
using LaCaguamaBackend.Domain.Interface;
using Microsoft.EntityFrameworkCore;

namespace LaCaguamaBackend.Infraestructure.Repository
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly LaCaguamaDbContext _context;
        public CategoriaRepository(LaCaguamaDbContext context)
        {
            _context = context;
        }

        public async Task<List<CategoriaNameDto>> GetAllCategoriaName()
        {
            var query = from c in _context.Categorias
                        select new CategoriaNameDto
                        {
                            Tipo = c.Tipo
                        };
            return await query.ToListAsync();
        }
    }
}
