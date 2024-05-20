namespace LaCaguamaBackend.Domain.Models
{
    public class Bebidas
    {
        public int BebidaID { get; set; }
        public decimal PrecioUnitario { get; set; }
        public int Categoria_ID { get; set; }
        public int Inventario_ID { get; set; }
        public virtual Categoria Categoria { get; set; }
        public virtual Inventario Inventario { get; set; }
    }
}
