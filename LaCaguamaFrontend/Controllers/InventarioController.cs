using LaCaguamaFrontend.Models;
using LaCaguamaFrontend.Models.Dto;
using Microsoft.AspNetCore.Mvc;

namespace LaCaguamaFrontend.Controllers
{
    public class InventarioController : Controller
    {
        /*public IActionResult Inventario()
        {
            return View();
        }*/
        private readonly IHttpClientFactory _httpClientFactory;

        public InventarioController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        [HttpGet]
        public async Task<IActionResult> Inventario()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44347/Inventario/");

                // Preparar todas las llamadas API
                var artesanalesTask = client.GetAsync("GetAll/Artesanales");
                var sinAlcoholTask = client.GetAsync("GetAll/SinAlcohol");
                var importadasTask = client.GetAsync("GetAll/Importadas");
                var siSeFreseaTask = client.GetAsync("GetAll/SiseFresea");
                var nacionalesTask = client.GetAsync("GetAll/Nacionales");

                // Esperar todas las tareas
                await Task.WhenAll(artesanalesTask, sinAlcoholTask);

                // Procesar las respuestas
                var artesanales = await artesanalesTask.Result.Content.ReadAsAsync<List<InventarioDto>>();
                var sinAlcohol = await sinAlcoholTask.Result.Content.ReadAsAsync<List<InventarioDto>>();
                var impotadas = await importadasTask.Result.Content.ReadAsAsync<List<InventarioDto>>();
                var siseFresea = await siSeFreseaTask.Result.Content.ReadAsAsync<List<InventarioDto>>();
                var nacionales = await nacionalesTask.Result.Content.ReadAsAsync<List<InventarioDto>>();

                // Preparar el modelo para la vista
                var model = new InventariobebidaModel
                {
                    Artesanales = artesanales,
                    SinAlcohol = sinAlcohol,
                    Importadas = impotadas,
                    SiseFresea = siseFresea,
                    Nacionales = nacionales
                };

                return View(model);
            }
        }

        public async Task<IActionResult> Proveedor()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44347/Proveedor/");

                // Suponiendo que "GetAll/Artesanales" es tu endpoint para artesanales
                var response = await client.GetAsync("GetAll");
                if (response.IsSuccessStatusCode)
                {
                    var data = await response.Content.ReadAsAsync<List<ProveedorDto>>();
                    var model = new ProveedorModel
                    {
                        Proveedores = data
                    };
                    return View(model);
                }
            }
            return View(new ProveedorModel());
        }

        [HttpGet]
        public IActionResult Agregar()
        {
            return View(new InventarioBebidaProveedorDto());
        }
        [HttpPost]
        public async Task<IActionResult> Agregar(InventarioBebidaProveedorDto bebida)
        {
            var client = _httpClientFactory.CreateClient("API"); // Obtener el cliente configurado
            var response = await client.PostAsJsonAsync("Bebida/InsertBebida", bebida);
            if (response.IsSuccessStatusCode)
            {
                // Lógica en caso de éxito
                return RedirectToAction("Inventario"); // Redirecciona a la vista deseada tras el éxito
            }
            else
            {
                // Manejar errores
                return View(bebida); // Devuelve a la vista original en caso de error
            }
        }

    }
}
