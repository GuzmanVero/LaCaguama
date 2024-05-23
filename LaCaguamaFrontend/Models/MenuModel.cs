using LaCaguamaFrontend.Models.Dto;

namespace LaCaguamaFrontend.Models
{
    public class MenuModel
    {
        public List<BebidaDto> bebida { get; set; } = new List<BebidaDto>();
        public List<PlatoDto> Plato { get; set; } = new List<PlatoDto>();
        public List<ExtraDto> Extra { get; set; } = new List<ExtraDto>();
    }
}
