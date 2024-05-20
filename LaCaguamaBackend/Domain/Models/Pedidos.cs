namespace LaCaguamaBackend.Domain.Models
{
    public class Pedidos
    {
        public int PedidosID { get; set; }
        public int Menu_ID { get; set; }
        public virtual Menu Menu { get; set; }
    }
}
