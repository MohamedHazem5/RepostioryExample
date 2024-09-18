using RepositoryExample.Data.Repositories.IRepositories;

namespace RepositoryExample.Data.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IUserRepository Users { get; }
        ICategoryRepository Categories { get; }
        int save();
    }
}
