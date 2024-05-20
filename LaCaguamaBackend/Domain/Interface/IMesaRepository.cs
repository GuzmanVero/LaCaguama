using LaCaguamaBackend.Application.Dtos;

namespace LaCaguamaBackend.Domain.Interface
{
    public interface IMesaRepository
    {
        Task<List<MesasDto>> GetAllMesas();
    }
}
