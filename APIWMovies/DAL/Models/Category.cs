using System.ComponentModel.DataAnnotations;

namespace APIWMovies.DAL.Models
{
    public class Category : AuditBase
    {
        [Required] // indica que el campo es obligatorio

        [Display(Name = "Nombre de la categoría")] // me sirve para mostrar un nombre amigable en las vistas
        public string Name { get; set; }
    }
}
