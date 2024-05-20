using LaCaguamaBackend.Application.Dtos;
using LaCaguamaBackend.Domain.Interface;

namespace LaCaguamaBackend.Application.Service
{
    public class FacturaService :IFacturaService
    {
        private readonly IFacturaRepository _repository;
        public FacturaService(IFacturaRepository repository)
        {
            _repository = repository;

        }

        public async Task<List<HistorialFacturaDto>> GetAllHistorialFactura()
        {
            return await _repository.GetAllHistorialFactura();
        }

        public async Task<List<HistorialFacturaDto>> GetAllHistorialFacturaFecha(DateTime inicio, DateTime final)
        {
            return await _repository.GetAllHistorialFacturaFecha(inicio, final);
        }
    }
}
