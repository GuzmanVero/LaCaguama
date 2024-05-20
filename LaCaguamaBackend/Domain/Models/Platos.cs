namespace LaCaguamaBackend.Domain.Models
{
    public class Platos
    {
        public int PlatoID { get; set; }
        public string Nombre_Plato { get; set; }
        public decimal Precio_Unitario { get; set; }
        public string Descripcion { get; set; }
        public int? Extra_ID { get; set; }
        public virtual Extra Extra { get; set; }
    }
}
