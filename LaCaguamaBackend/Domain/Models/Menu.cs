namespace LaCaguamaBackend.Domain.Models
{
    public class Menu
    {
        public int MenuID { get; set; }
        public int PlatoID { get; set; }
        public int BebidaID { get; set; }
        public virtual Platos Platos { get; set; }
        public virtual Bebidas Bebidas { get; set; }
    }
}
