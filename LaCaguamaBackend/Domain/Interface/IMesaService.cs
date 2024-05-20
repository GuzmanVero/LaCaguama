using LaCaguamaBackend.Application.Dtos;

namespace LaCaguamaBackend.Domain.Interface
{
    public interface IMesaService
    {
        Task<List<MesasDto>> GetAllMesas();
    }
}
