using LaCaguamaFrontend.Models.Dto;
using LaCaguamaFrontend.Models;
using Microsoft.AspNetCore.Mvc;

namespace LaCaguamaFrontend.Controllers
{
    public class PedidosController : Controller
    {
        public IActionResult Mesas()
        {
            return View();
        }

        public async Task<IActionResult> Pedido()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44347/");

                // Preparar todas las llamadas API
                var bebidaTask = client.GetAsync("Bebida/GetAll/bebidasMenu");
                var extraTask = client.GetAsync("Extra/GetAll");
                var platoTask = client.GetAsync("Plato/GetAll");

                // Esperar todas las tareas
                await Task.WhenAll(bebidaTask, extraTask, platoTask);

                // Procesar las respuestas
                var bebida = await bebidaTask.Result.Content.ReadAsAsync<List<BebidaDto>>();
                var extra = await extraTask.Result.Content.ReadAsAsync<List<ExtraDto>>();
                var plato = await platoTask.Result.Content.ReadAsAsync<List<PlatoDto>>();

                // Preparar el modelo para la vista
                var model = new MenuModel
                {
                    bebida = bebida,
                    Extra = extra,
                    Plato = plato,
                };

                return View(model);
            }
        }

        public IActionResult Ordenes()
        {
            return View();
        }

        public async Task<IActionResult> Menus()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44347/Menu/");

                var response = await client.GetAsync("GetAll/Menu");
                if (response.IsSuccessStatusCode)
                {
                    var data = await response.Content.ReadAsAsync<List<MenusDto>>();
                    var model = new MenusModel
                    {
                        menu = data
                    };
                    return View(model);
                }
            }
            return View(new MenusModel());
        }
    }
}
