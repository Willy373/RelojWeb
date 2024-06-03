using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace RelojWeb.Models
{
    public class Reloj
    {
        public int Id { get; set; }
        public string? Marca { get; set; }
        public string? Modelo { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public string? Foto { get; set; } //Almacenar la ubicación de la foto 

        //Cargar Foto
        [NotMapped] //No va migrar la BBDD
        [Display(Name = "Cargar Foto")]
        public IFormFile? FotoFile { get; set; }

    }
}
