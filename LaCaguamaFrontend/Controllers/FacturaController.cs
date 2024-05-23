using LaCaguamaFrontend.Models;
using LaCaguamaFrontend.Models.Dto;
using Microsoft.AspNetCore.Mvc;

namespace LaCaguamaFrontend.Controllers
{
    public class FacturaController : Controller
    {
        public async Task<IActionResult> Historial()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44347/Factura/");

                var response = await client.GetAsync("GetAll/Tipo");
                if (response.IsSuccessStatusCode)
                {
                    var data = await response.Content.ReadAsAsync<List<HistorialDto>>();
                    var model = new HistorialFacturaModel
                    {
                        Historial = data
                    };
                    return View(model);
                }
            }
            return View(new HistorialFacturaModel());
        }

    }
}
