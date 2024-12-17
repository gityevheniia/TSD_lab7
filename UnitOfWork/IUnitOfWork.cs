using UserManagement.DAL.Repositories.Interfaces;

namespace UserManagement.DAL.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IUserRepository Users { get; }
        Task SaveAsync();
    }
}
