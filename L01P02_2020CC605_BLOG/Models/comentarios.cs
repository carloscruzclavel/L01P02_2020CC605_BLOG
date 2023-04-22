using System.ComponentModel.DataAnnotations;

namespace L01P02_2020CC605_BLOG.Models
{
    public class comentarios
    {
        [Key]

        public int cometarioId { get; set; }
        [Display(Name = "Ingrese el ID de la publicacion")]
        public int publicacionId { get; set; }
        [Display(Name = "Ingrese comentario")]
        public string comentario { get; set; }
        [Display(Name = "Ingrese el ID de usuario")]
        public int usuarioId { get; set; }
    }
}
