using System.ComponentModel.DataAnnotations;

namespace L01P02_2020CC605_BLOG.Models
{
    public class calificaciones
    {
        [Key]

        public int calificacionId { get; set; }
        [Display(Name = "Ingrese el ID de la publicacion")]
        public int publicacionId { get; set; }
        [Display(Name = "Ingrese el ID de usuario")]
        public int usuarioId { get; set; }
        [Display(Name = "Ingrese la calificacion")]
        public int calificacion { get; set; }
    }
}
