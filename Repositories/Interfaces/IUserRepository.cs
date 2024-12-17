﻿using UserManagement.DAL.Entities;

namespace UserManagement.DAL.Repositories.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {
        Task<User> GetByEmailAsync(string email);
    }
}
