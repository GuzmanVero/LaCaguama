using LaCaguamaBackend.Application.Dtos;

namespace LaCaguamaBackend.Domain.Interface
{
    public interface IMenuService
    {
        Task<List<MenuDto>> GetAllMenu();
    }
}
