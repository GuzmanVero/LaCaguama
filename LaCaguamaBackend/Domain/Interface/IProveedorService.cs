using LaCaguamaBackend.Application.Dtos;

namespace LaCaguamaBackend.Domain.Interface
{
    public interface IProveedorService
    {
        Task<List<ProveedorDto>> GetAllProveedoresWithBebidas();
        Task<List<ProveedorNameDto>> GetAllProveedoresName();
    }
}
