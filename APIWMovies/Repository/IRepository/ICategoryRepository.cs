using APIWMovies.DAL.Models;

namespace APIWMovies.Repository.IRepository
{
    public interface ICategoryRepository
    {
        Task<ICollection<Category>> GetCategoriesAsync(); // Obtener todas las categorías
        Task<Category> GetCategoryAsync(int id); // Obtener una categoría por su ID
        Task<bool> CategoryExistsByIdAsync(int id); // Verificar si una categoría existe por su ID
        Task<bool> CategoryExistsByNameAsync(string name); // Verificar si una categoría existe por su nombre
        Task<bool> CreateCategoryAsync(Category category); // Crear una nueva categoría
        Task<bool> UpdateCategoryAsync(Category category); // Actualizar una categoría existente
        Task<bool> DeleteCategoryAsync(int id); // Eliminar una categoría por su ID
    }
}
