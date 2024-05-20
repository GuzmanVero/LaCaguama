namespace LaCaguamaBackend.Application.Dtos
{
    public class InventarioBebidaProveedorDto
    {
        public string NombreBebida { get; set; }
        public int Stock { get; set; }
        public string NombreProveedor { get; set; }
        public string TipoCategoria { get; set; }
        public decimal PrecioUnitario { get; set; }
    }
}
