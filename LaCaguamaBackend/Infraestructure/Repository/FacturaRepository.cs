using LaCaguamaBackend.Application.Dtos;
using LaCaguamaBackend.Domain.Interface;
using LaCaguamaBackend.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Globalization;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace LaCaguamaBackend.Infraestructure.Repository
{
    public class FacturaRepository : IFacturaRepository
    {
        private readonly LaCaguamaDbContext _context;
        public FacturaRepository(LaCaguamaDbContext context)
        {
            _context = context;
        }

        public async Task<List<HistorialFacturaDto>> GetAllHistorialFactura()
        {
            var historial = from f in _context.Facturas
                            join o in _context.Ordenes on f.Orden_ID equals o.OrdenID
                            join tp in _context.TipoPagos on o.Tipo_Pago equals tp.PagoID
                            select new HistorialFacturaDto
                            {
                                MesFactura = f.Fecha_Factura.ToString("MMMM"),
                                DiaFactura = f.Fecha_Factura.ToString("dddd"),
                                Nombre = tp.Nombre,
                                Total = o.Total

                            };
            return await historial.ToListAsync();

        }

        public async Task<List<HistorialFacturaDto>> GetAllHistorialFacturaFecha(DateTime inicio, DateTime final)
        {
            var historial = from f in _context.Facturas
                            join o in _context.Ordenes on f.Orden_ID equals o.OrdenID
                            join tp in _context.TipoPagos on o.Tipo_Pago equals tp.PagoID
                            where f.Fecha_Factura >= inicio && f.Fecha_Factura <= final
                            select new HistorialFacturaDto
                            {
                                MesFactura = f.Fecha_Factura.ToString("MMMM"),
                                DiaFactura = f.Fecha_Factura.ToString("dddd"),
                                Nombre = tp.Nombre,
                                Total = o.Total
                            };

            return await historial.ToListAsync();
        }
    }
}