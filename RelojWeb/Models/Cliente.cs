using System.ComponentModel.DataAnnotations;

namespace RelojWeb.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        [Required, MinLength(4)]
        public string? NombreCompleto { get; set; }
        public string? Direccion { get; set; }
        [Required]
        public int Ci { get; set; }

        //Relaciones 1
        public virtual List<Venta>? Ventas { get; set; }
    }
}
