using LaCaguamaBackend.Application.Dtos;
using LaCaguamaBackend.Domain.Interface;
using LaCaguamaBackend.Domain.Models;

namespace LaCaguamaBackend.Application.Service
{
    public class PlatoService :IPlatoService
    {
        private readonly IPlatoRepository _repository;
        public PlatoService(IPlatoRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<PlatoDto>> GetAllPlato()
        {
            return await _repository.GetAllPlato();
        }

        public async Task<List<PlatoDto>> GetAllPlatoWithName(string nombre)
        {
            return await _repository.GetAllPlatoWithName(nombre);
        }

        public async Task<PlatoDto> InsertPlato(string nombre, string descripcion, decimal precio, string NombreExtra)
        {
            return await _repository.InsertPlato(nombre,descripcion, precio, NombreExtra);
        }
    }
}
