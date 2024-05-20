using LaCaguamaBackend.Application.Dtos;
using LaCaguamaBackend.Domain.Interface;

namespace LaCaguamaBackend.Application.Service
{
    public class InventarioService : IInventarioService
    {
        private readonly IInventarioRepository _repository;
        public InventarioService(IInventarioRepository repository)
        {
            _repository = repository;

        }

        public async Task<List<InventarioDto>> GetInventoryByArtesanales()
        {
            return await _repository.GetInventoryByArtesanales();
        }

        public async Task<List<InventarioDto>> GetInventoryByCategory()
        {
            return await _repository.GetInventoryByCategory();
        }

        public async Task<List<InventarioDto>> GetInventoryByImportadas()
        {
            return await _repository.GetInventoryByImportadas();
        }

        public async Task<List<InventarioDto>> GetInventoryByNacionales()
        {
            return await _repository.GetInventoryByNacionales();
        }

        public async Task<List<InventarioDto>> GetInventoryBySinAlcohol()
        {
            return await _repository.GetInventoryBySinAlcohol();
        }

        public async Task<List<InventarioDto>> GetInventoryBySiseFresea()
        {
            return await _repository.GetInventoryBySiseFresea();
        }
    }
}
