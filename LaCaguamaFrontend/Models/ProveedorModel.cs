using LaCaguamaFrontend.Models.Dto;

namespace LaCaguamaFrontend.Models
{
    public class ProveedorModel
    {
        public List<ProveedorDto> Proveedores { get; set; } = new List<ProveedorDto>();
        public List<CategoriaDto> Categoria { get; set; } = new List<CategoriaDto>();
    }
}
