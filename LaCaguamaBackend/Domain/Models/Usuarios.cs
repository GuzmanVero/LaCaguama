namespace LaCaguamaBackend.Domain.Models
{
    public class Usuarios
    {
        public int UsuarioID { get; set; }
        public string Nombre { get; set; }
        public string Contrasena { get; set; }
        public int Empleado_ID { get; set; }
        public virtual Empleado Empleado { get; set; }
    }
}
