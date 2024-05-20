using LaCaguamaFrontend.Models.Dto;

namespace LaCaguamaFrontend.Models
{
    public class InventariobebidaModel
    {
        public List<InventarioDto> Artesanales { get; set; } = new List<InventarioDto>();
        public List<InventarioDto> SinAlcohol { get; set; } = new List<InventarioDto>();
        public List<InventarioDto> Importadas { get; set; } = new List<InventarioDto>();
        public List<InventarioDto> SiseFresea { get; set; } = new List<InventarioDto>();
        public List<InventarioDto> Nacionales { get; set; } = new List<InventarioDto>();
    }
}
