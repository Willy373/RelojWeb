using RelojWeb.Dto;

namespace RelojWeb.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string? Cuenta { get; set; }
        public string? Password { get; set; }
        public string? NombreCompleto { get; set; }
        public RolEnum Rol { get; set; }
        public int Celular { get; set; }
    }
}
