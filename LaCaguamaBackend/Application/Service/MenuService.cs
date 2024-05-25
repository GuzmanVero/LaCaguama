using LaCaguamaBackend.Application.Dtos;
using LaCaguamaBackend.Domain.Interface;

namespace LaCaguamaBackend.Application.Service
{
    public class MenuService : IMenuService
    {
        private readonly IMenuRepository _repository;
        public MenuService(IMenuRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<MenuDto>> GetAllMenu()
        {
            return await _repository.GetAllMenu();
        }
    }
}
