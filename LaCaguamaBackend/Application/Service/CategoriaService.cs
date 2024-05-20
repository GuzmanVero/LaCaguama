using LaCaguamaBackend.Application.Dtos;
using LaCaguamaBackend.Domain.Interface;

namespace LaCaguamaBackend.Application.Service
{
    public class CategoriaService : ICategoriaService
    {
        private readonly ICategoriaRepository _repository;
        public CategoriaService(ICategoriaRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<CategoriaNameDto>> GetAllCategoriaName()
        {
            return await _repository.GetAllCategoriaName();
        }
    }
}
