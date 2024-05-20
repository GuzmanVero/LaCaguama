using LaCaguamaBackend.Application.Dtos;
using LaCaguamaBackend.Domain.Interface;
using LaCaguamaBackend.Domain.Models;
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LaCaguamaBackend.Infraestructure.Repository
{
    public class ExtraRepository :IExtraRepository
    {
        private readonly LaCaguamaDbContext _context;
        public ExtraRepository(LaCaguamaDbContext context)
        {
            _context = context;
        }

        public async Task<List<ExtrasDto>> GetAllEctraWithName(string nombre)
        {
            var query = from e in _context.Extras
                        where e.Nombre.ToLower().Contains(nombre.ToLower())
                        select new ExtrasDto
                        {
                            Nombre = e.Nombre,
                            PrecioUnitario = e.PrecioUnitario
                        };
            return await query.ToListAsync();
        }

        public async Task<List<ExtrasDto>> GetAllExtras()
        {
            var query = from e in _context.Extras
                        select new ExtrasDto
                        {
                            Nombre = e.Nombre,
                            PrecioUnitario = e.PrecioUnitario
                        };
            return await query.ToListAsync();
        }

        public async Task<ExtrasDto> InsertExtra(string nombre, decimal precio)
        {
            var nuevoextra = new Extra
            {
                Nombre = nombre,
                PrecioUnitario= precio,
            };

            _context.Extras.Add(nuevoextra);
            await _context.SaveChangesAsync();

            return new ExtrasDto
            {
                Nombre = nuevoextra.Nombre,
                PrecioUnitario = nuevoextra.PrecioUnitario,

            };
        }
    }
}
