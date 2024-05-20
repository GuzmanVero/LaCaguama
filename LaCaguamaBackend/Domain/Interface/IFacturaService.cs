using LaCaguamaBackend.Application.Dtos;

namespace LaCaguamaBackend.Domain.Interface
{
    public interface IFacturaService
    {
        Task<List<HistorialFacturaDto>> GetAllHistorialFactura();
        Task<List<HistorialFacturaDto>> GetAllHistorialFacturaFecha(DateTime inicio, DateTime final);
    }
}
