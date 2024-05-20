using LaCaguamaBackend.Application.Dtos;
using LaCaguamaBackend.Domain.Interface;

namespace LaCaguamaBackend.Application.Service
{
    public class MesaService : IMesaService
    {
        private readonly IMesaRepository _repository;
        public MesaService(IMesaRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<MesasDto>> GetAllMesas()
        {
            return await _repository.GetAllMesas();
        }
    }
}
