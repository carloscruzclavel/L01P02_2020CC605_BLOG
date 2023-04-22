using System.ComponentModel.DataAnnotations;

namespace L01P02_2020CC605_BLOG.Models
{
    public class publicaciones
    {
        [Key]
        public int publicacionId { get; set; }
        [Display(Name = "Ingrese el titulo de la publicacion")]
        public string? titulo { get; set; }
        [Display(Name = "Ingrese descripcion")]
        public string? descripcion { get; set; }
        [Display(Name = "Ingrese su ID de usuario")]
        public int? usuarioId { get; set; }
    }
}
