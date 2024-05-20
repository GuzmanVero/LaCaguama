using LaCaguamaBackend.Application.Dtos;

namespace LaCaguamaBackend.Domain.Interface
{
    public interface ICategoriaRepository
    {
        Task<List<CategoriaNameDto>> GetAllCategoriaName();
    }
}
