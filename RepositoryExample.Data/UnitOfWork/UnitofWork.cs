using Microsoft.EntityFrameworkCore;
using RepositoryExample.Data.Repositories.IRepositories;
using RepositoryExample.Data.Repositories;

namespace RepositoryExample.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbContext _context;
        public IUserRepository Users { get; }
        public ICategoryRepository Categories { get; }

        public UnitOfWork(DbContext context)
        {
            _context = context;
            Users = new UserRepository(_context);
            Categories = new CategoryRepository(_context);
        }

        public int save() => _context.SaveChanges();

        public void Dispose() => _context.Dispose();
    }
}
