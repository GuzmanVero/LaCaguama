using LaCaguamaBackend.Application.Dtos;

namespace LaCaguamaBackend.Domain.Interface
{
    public interface IBebidaService
    {
        Task<List<InventarioBebidaProveedorDto>> GetBebida(string proveedor, string categoria, string nombreBebida, int stock, decimal precioUnitario);
        Task<List<BebidasDto>> GetBebidas();
        Task<List<BebidasDto>> GetAllBebidas(string nombre);
    }
}
