using Microsoft.EntityFrameworkCore;
using UserManagement.DAL.Entities;
using UserManagement.DAL.Repositories.Interfaces;

namespace UserManagement.DAL.Repositories.Impl
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(DbContext context) : base(context) { }

        public async Task<User> GetByEmailAsync(string email)
        {
            return await _dbSet.FirstOrDefaultAsync(u => u.Email == email);
        }
    }
}
