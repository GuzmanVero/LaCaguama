using LaCaguamaBackend.Application.Dtos;
using LaCaguamaBackend.Domain.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LaCaguamaBackend.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class InventarioController : ControllerBase
    {
        private readonly IInventarioService _service;

        public InventarioController(IInventarioService service)
        {
            _service = service;
        }

        [HttpGet("GetAll")]
        [ProducesResponseType(StatusCodes.Status200OK)]       
        public async Task<ActionResult<List<InventarioDto>>> GetInventoryByCategory()
        {
            var Invetario = await _service.GetInventoryByCategory();
            return Ok(Invetario);
        }
        [HttpGet("GetAll/Artesanales")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<InventarioDto>>> GetInventoryByArtesanales()
        {
            var Invetario = await _service.GetInventoryByArtesanales();
            return Ok(Invetario);
        }
        [HttpGet("GetAll/SinAlcohol")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<InventarioDto>>> GetInventoryBySinAlcohol()
        {
            var Invetario = await _service.GetInventoryBySinAlcohol();
            return Ok(Invetario);
        }
        [HttpGet("GetAll/Importadas")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<InventarioDto>>> GetInventoryByImportadas()
        {
            var Invetario = await _service.GetInventoryByImportadas();
            return Ok(Invetario);
        }
        [HttpGet("GetAll/SiseFresea")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<InventarioDto>>> GetInventoryBySiseFresea()
        {
            var Invetario = await _service.GetInventoryBySiseFresea();
            return Ok(Invetario);
        }
        [HttpGet("GetAll/Nacionales")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<InventarioDto>>> GetInventoryByNacionales()
        {
            var Invetario = await _service.GetInventoryByNacionales();
            return Ok(Invetario);
        }

    }
}
