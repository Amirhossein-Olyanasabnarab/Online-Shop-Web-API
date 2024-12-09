using Microsoft.EntityFrameworkCore;
using OnlineShop.Application.Interfaces.Contexts;
using OnlineShop.Domain.Entities.Users;

namespace OnlineShop.Persistence.Contexts;

public class DataBaseContext : DbContext, IDataBaseContext
{
    public DataBaseContext(DbContextOptions options) : base(options)
    {
        
    }
    public DbSet<User> Users { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<UserInRole> UserInRoles { get; set; }
}