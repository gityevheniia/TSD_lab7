using UserManagement.DAL.EF;
using UserManagement.DAL.Repositories.Impl;
using UserManagement.DAL.Repositories.Interfaces;

namespace UserManagement.DAL.UnitOfWork
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private readonly UserContext _context;
        private IUserRepository _users;

        public EFUnitOfWork(UserContext context)
        {
            _context = context;
        }

        public IUserRepository Users => _users ??= new UserRepository(_context);

        public async Task SaveAsync() => await _context.SaveChangesAsync();

        public void Dispose() => _context.Dispose();
    }
}
