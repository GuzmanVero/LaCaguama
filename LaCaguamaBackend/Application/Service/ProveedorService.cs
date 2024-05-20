using LaCaguamaBackend.Application.Dtos;
using LaCaguamaBackend.Domain.Interface;

namespace LaCaguamaBackend.Application.Service
{
    public class ProveedorService : IProveedorService
    {
        private readonly IProveedorRepository _repository;
        public ProveedorService(IProveedorRepository repository)
        {
            _repository = repository;

        }

        public async Task<List<ProveedorNameDto>> GetAllProveedoresName()
        {
           return await _repository.GetAllProveedoresName();
        }

        public async Task<List<ProveedorDto>> GetAllProveedoresWithBebidas()
        {
            return await _repository.GetAllProveedoresWithBebidas();
        }
    }
}
