using LaCaguamaBackend.Application.Dtos;
using LaCaguamaBackend.Domain.Interface;

namespace LaCaguamaBackend.Application.Service
{
    public class BebidaService : IBebidaService
    {
        private readonly IBebidaRepository _repository;
        public BebidaService(IBebidaRepository repository)
        {
            _repository = repository;

        }

        public async Task<List<BebidasDto>> GetAllBebidas(string nombre)
        {
            return await _repository.GetAllBebidas(nombre);
        }

        public async Task<List<InventarioBebidaProveedorDto>> GetBebida(string proveedor, string categoria, string nombreBebida, int stock, decimal precioUnitario)
        {
            return await _repository.GetBebida(proveedor, categoria, nombreBebida, stock, precioUnitario);
        }

        public async Task<List<BebidasDto>> GetBebidas()
        {
            return await _repository.GetBebidas();
        }
    }
}
