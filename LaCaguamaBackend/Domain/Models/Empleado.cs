namespace LaCaguamaBackend.Domain.Models
{
    public class Empleado
    {
        public int EmpleadoID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public string Sexo { get; set; }
        public decimal SueldoNeto { get; set; }
        public decimal SueldoLiquido { get; set; }
        public int RolID { get; set; }
        public virtual Roles Roles { get; set; }
    }
}
