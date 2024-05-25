namespace LaCaguamaBackend.Domain.Models
{
    public class Menu
    {
        public int MenuID { get; set; }
        public int Plato_ID { get; set; }
        public int Bebida_ID { get; set; }
        public virtual Platos Platos { get; set; }
        public virtual Bebidas Bebidas { get; set; }
    }
}
