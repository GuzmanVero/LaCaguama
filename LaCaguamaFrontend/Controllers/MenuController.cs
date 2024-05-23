using LaCaguamaFrontend.Models;
using LaCaguamaFrontend.Models.Dto;
using Microsoft.AspNetCore.Mvc;

namespace LaCaguamaFrontend.Controllers
{
    public class MenuController : Controller
    {
        public async Task<IActionResult> Menu()
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

    }
}
