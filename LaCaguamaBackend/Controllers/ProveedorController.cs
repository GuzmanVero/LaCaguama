using LaCaguamaBackend.Application.Dtos;
using LaCaguamaBackend.Domain.Interface;
using LaCaguamaBackend.Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LaCaguamaBackend.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProveedorController : ControllerBase
    {
        private readonly IProveedorService _service;

        public ProveedorController(IProveedorService service)
        {
            _service = service;
        }
        [HttpGet("GetAll/")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<ProveedorDto>>> GetAllProveedoresWithBebidas()
        {
            var proveedor = await _service.GetAllProveedoresWithBebidas();
            return Ok(proveedor);
        }

        [HttpGet("GetAll/Names")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<ProveedorNameDto>>> GetAllProveedoresName()
        {
            var proveedor = await _service.GetAllProveedoresName();
            return Ok(proveedor);
        }
    }
}
