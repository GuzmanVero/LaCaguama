using LaCaguamaBackend.Application.Dtos;

namespace LaCaguamaBackend.Domain.Interface
{
    public interface IProveedorRepository
    {
        Task<List<ProveedorDto>> GetAllProveedoresWithBebidas();
        Task<List<ProveedorNameDto>> GetAllProveedoresName();
    }
}
