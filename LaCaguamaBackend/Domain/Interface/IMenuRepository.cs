using LaCaguamaBackend.Application.Dtos;

namespace LaCaguamaBackend.Domain.Interface
{
    public interface IMenuRepository
    {
        Task<List<MenuDto>> GetAllMenu();
    }
}
