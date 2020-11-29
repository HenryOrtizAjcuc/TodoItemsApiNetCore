using Microsoft.EntityFrameworkCore;

namespace TodoApi.Models
{
    public class TodoContext : DbContext
    {
        // En ASP.NET Core, los servicios (como el contexto de la base de datos) deben registrarse
        // con el contenedor de inserción de dependencias (DI). El Contenedor proporciona el
        // servicio a los controladores.
        public TodoContext(DbContextOptions<TodoContext> options) : base(options)
        {
        }

        public DbSet<TodoItem> TodoItems { get; set; }
    }
}
