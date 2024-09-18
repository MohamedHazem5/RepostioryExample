using RepositoryExample.Models.Entities;

namespace RepositoryExample.Business.Services.IServices
{
    internal interface IUserService
    {
        IEnumerable<User> GetAllUsers();
        void AddUser(User user);

    }
}
