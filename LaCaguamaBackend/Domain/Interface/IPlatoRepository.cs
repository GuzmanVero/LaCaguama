using LaCaguamaBackend.Application.Dtos;

namespace LaCaguamaBackend.Domain.Interface
{
    public interface IPlatoRepository
    {
        Task<List<PlatoDto>> GetAllPlato();
        Task<List<PlatoDto>> GetAllPlatoWithName(string nombre);
        Task<PlatoDto> InsertPlato(string nombre, string descripcion, decimal precio, string NombreExtra);
    }
}
