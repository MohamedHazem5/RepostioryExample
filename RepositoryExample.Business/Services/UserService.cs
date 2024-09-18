using RepositoryExample.Data.UnitOfWork;
using RepositoryExample.Models.Entities;

namespace RepositoryExample.Business.Services
{
    public class UserService
    {
        private readonly IUnitOfWork _unitOfWork;

        public UserService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _unitOfWork.Users.GetAll();
        }

        public void AddUser(User user)
        {
            _unitOfWork.Users.Add(user);
            _unitOfWork.save();
        }
    }
}
