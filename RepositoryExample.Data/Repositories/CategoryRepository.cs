using Microsoft.EntityFrameworkCore;
using RepositoryExample.Data.Repositories.IRepositories;
using RepositoryExample.Models.Entities;

namespace RepositoryExample.Data.Repositories
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(DbContext context) : base(context)
        {
        }
    }
}
