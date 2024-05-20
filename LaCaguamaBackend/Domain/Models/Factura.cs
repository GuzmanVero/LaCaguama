namespace LaCaguamaBackend.Domain.Models
{
    public class Factura
    {
        public int FacturaID { get; set; }
        public DateTime Fecha_Factura { get; set; }
        public int Orden_ID { get; set; }
        public virtual Ordenes Ordenes { get; set; }
    }
}
