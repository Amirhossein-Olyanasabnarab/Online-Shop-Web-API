using Microsoft.EntityFrameworkCore;
using OnlineShop.Domain.Entities.Users;

namespace OnlineShop.Application.Interfaces.Contexts;

public interface IDataBaseContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<UserInRole> UserInRoles { get; set; }
    int SaveChanges();
    int SaveChanges(bool acceptAllChangesOnSuccess);
    Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = new CancellationToken());
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken());
}