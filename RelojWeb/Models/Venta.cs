using System.ComponentModel.DataAnnotations;

namespace RelojWeb.Models
{
    public class Venta
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime Fecha { get; set; }
        [Required]
        public decimal Total { get; set; }

        //Foreign key 1..*
        public int UsuarioId { get; set; }
        public int ClienteId { get; set; }
        public int RelojId { get; set; }

        public virtual Usuario? Usuario { get; set; }
        public virtual Cliente? Cliente { get; set; }
        public virtual Reloj? Reloj { get; set; }

    }
}
