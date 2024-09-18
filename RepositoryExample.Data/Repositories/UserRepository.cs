using Microsoft.EntityFrameworkCore;
using RepositoryExample.Data.Repositories.IRepositories;
using RepositoryExample.Models.Entities;

namespace RepositoryExample.Data.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(DbContext context) : base(context)
        {
        }

       
    }
}
