using LaCaguamaBackend.Application.Dtos;

namespace LaCaguamaBackend.Domain.Interface
{
    public interface IInventarioService
    {
        Task<List<InventarioDto>> GetInventoryByCategory();
        Task<List<InventarioDto>> GetInventoryByNacionales();
        Task<List<InventarioDto>> GetInventoryBySinAlcohol();
        Task<List<InventarioDto>> GetInventoryByImportadas();
        Task<List<InventarioDto>> GetInventoryBySiseFresea();
        Task<List<InventarioDto>> GetInventoryByArtesanales();
    }
}
