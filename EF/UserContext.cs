using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using UserManagement.DAL.Entities;

namespace UserManagement.DAL.EF
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
    }
}
