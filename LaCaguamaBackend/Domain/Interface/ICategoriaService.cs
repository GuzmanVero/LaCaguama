using LaCaguamaBackend.Application.Dtos;

namespace LaCaguamaBackend.Domain.Interface
{
    public interface ICategoriaService
    {
        Task<List<CategoriaNameDto>> GetAllCategoriaName();
    }
}
