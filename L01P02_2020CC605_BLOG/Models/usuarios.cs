using System.ComponentModel.DataAnnotations;

namespace L01P02_2020CC605_BLOG.Models
{
    public class usuarios
    {
        [Key]
        public int usuarioId { get; set; }
        [Display(Name = "Ingrese el ID del Rol")]
        public int rolId { get; set; }
        [Display(Name = "Ingrese nombre de usuario")]
        public string? nombreUsuario { get; set; }
        [Display(Name = "Ingrese contraseña")]
        public string clave { get; set; }
        [Display(Name = "Ingrese su nombre")]
        public string nombre { get; set;}
        [Display(Name = "Ingrese su apellido")]
        public string apellido { get; set; }
    }
}
