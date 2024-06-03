using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace RelojWeb.Models
{
    public class Reloj
    {
        [Key]
        public int Id { get; set; }
        [Required, MinLength(4)]
        public string? Marca { get; set; }
        [Required, MinLength(4)]
        public string? Modelo { get; set; }
        [Required]
        public decimal Precio { get; set; }
        [Required]
        public int Stock { get; set; }
        public string? Foto { get; set; } //Almacenar la ubicación de la foto 

        //Cargar Foto
        [NotMapped] //No va migrar la BBDD
        [Display(Name = "Cargar Foto")]
        public IFormFile? FotoFile { get; set; }

        //Relaciones 1
        public virtual List<Venta>? Ventas { get; set; }

    }
}
