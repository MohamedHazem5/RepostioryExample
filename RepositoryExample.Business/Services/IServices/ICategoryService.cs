using RepositoryExample.Models.Entities;

namespace RepositoryExample.Business.Services.IServices
{
    public interface ICategoryService
    {
        IEnumerable<Category> GetAllCategories();

        void AddCategory(Category category);
    }
}
