using Microsoft.EntityFrameworkCore;

namespace L01P02_2020CC605_BLOG.Models
{
    public class blogDBContext : DbContext
    {
        public blogDBContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<usuarios> usuarios { get; set; }
        public DbSet<publicaciones> publicaciones { get; set; }
        public DbSet<calificaciones> calificaciones { get; set; }
        public DbSet<comentarios> comentarios { get; set; }
    }
}
