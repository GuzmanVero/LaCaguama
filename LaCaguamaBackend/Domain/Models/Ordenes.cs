namespace LaCaguamaBackend.Domain.Models
{
    public class Ordenes
    {
        public int OrdenID { get; set; }
        public string Cliente { get; set; }
        public decimal Total { get; set; }
        public decimal Descuento { get; set; }
        public int Tipo_Pago { get; set; }
        public int Usuario_ID { get; set; }
        public int Mesa_ID { get; set; }
        public int Pedido_ID { get; set; }
        public virtual TipoPago TipoPagoNavigation { get; set; }
        public virtual Usuarios Usuarios { get; set; }
        public virtual Mesa Mesa { get; set; }
        public virtual Pedidos Pedidos { get; set; }
    }
}
