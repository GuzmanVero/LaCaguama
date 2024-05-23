using LaCaguamaBackend.Application.Dtos;
using LaCaguamaBackend.Domain.Interface;
using LaCaguamaBackend.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace LaCaguamaBackend.Infraestructure.Repository
{
    public class PlatoRepository : IPlatoRepository
    {
        private readonly LaCaguamaDbContext _context;
        public PlatoRepository(LaCaguamaDbContext context)
        {
            _context = context;
        }

        public async Task<List<PlatoDto>> GetAllPlato()
        {
            var query = from e in _context.Platos
                        join t in _context.Extras on e.Extra_ID equals t.ExtraID
                        select new PlatoDto
                        {
                            NombrePlato = e.Nombre_Plato,
                            PrecioUnitario = e.Precio_Unitario,
                            Descripcion = e.Descripcion,
                            NombreExtra = t.Nombre
                        };
            return await query.ToListAsync();
        }

        public async Task<List<PlatoDto>> GetAllPlatoWithName(string nombre)
        {
            var query = from e in _context.Platos
                        where e.Nombre_Plato.ToLower().Contains(nombre.ToLower())
                        select new PlatoDto
                        {
                            NombrePlato = e.Nombre_Plato,
                            PrecioUnitario = e.Precio_Unitario,
                            Descripcion = e.Descripcion
                        };
            return await query.ToListAsync();
        }

        public async Task<PlatoDto> InsertPlato(string nombre, string descripcion, decimal precio, string NombreExtra)
        {
            var extra = await _context.Extras.FirstOrDefaultAsync(e => e.Nombre == NombreExtra);
            if (extra == null)
            {
                throw new Exception("El extra especificado no existe.");
            }

            var nuevoPlato = new Platos
            {
                Nombre_Plato = nombre,
                Descripcion = descripcion,
                Precio_Unitario = precio,
                Extra_ID = extra.ExtraID
            };

            _context.Platos.Add(nuevoPlato);
            await _context.SaveChangesAsync();

            return new PlatoDto
            {
                NombrePlato = nuevoPlato.Nombre_Plato,
                Descripcion = nuevoPlato.Descripcion,
                PrecioUnitario = nuevoPlato.Precio_Unitario,
            };
        }
    }
}
