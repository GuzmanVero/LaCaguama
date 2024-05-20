using LaCaguamaBackend.Application.Dtos;
using LaCaguamaBackend.Domain.Interface;

namespace LaCaguamaBackend.Application.Service
{
    public class ExtraService : IExtraService
    {
        private readonly IExtraRepository _repository;
        public ExtraService(IExtraRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<ExtrasDto>> GetAllEctraWithName(string nombre)
        {
            return await _repository.GetAllEctraWithName(nombre);
        }

        public async Task<List<ExtrasDto>> GetAllExtras()
        {
            return await _repository.GetAllExtras();
        }

        public async Task<ExtrasDto> InsertExtra(string nombre, decimal precio)
        {
            return await _repository.InsertExtra(nombre, precio);
        }
    }
}
