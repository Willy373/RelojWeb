using RelojWeb.Dto;
using System.ComponentModel.DataAnnotations;

namespace RelojWeb.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        [Required, MinLength(4), MaxLength(50)]
        public string? Cuenta { get; set; }
        [Required, MinLength(4), MaxLength(12)]
        public string? Password { get; set; }
        [Required, MinLength(4), MaxLength(50)]
        public string? NombreCompleto { get; set; }
        [Required]
        public RolEnum Rol { get; set; }
        public int Celular { get; set; }

        //Relaciones 1
        public virtual List<Venta>? Ventas { get; set; }
    }
}
