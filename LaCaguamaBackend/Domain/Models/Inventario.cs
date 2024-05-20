namespace LaCaguamaBackend.Domain.Models
{
    public class Inventario
    {
        public int InventarioID { get; set; }
        public string NombreBebida { get; set; }
        public int Stock { get; set; }
        public int Proveedor_ID { get; set; }
        public virtual Proveedor Proveedor { get; set; }
    }
}
