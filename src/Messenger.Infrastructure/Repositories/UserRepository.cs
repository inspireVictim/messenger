using Messenger.Domain.Entities;
using Messenger.Domain.Interfaces;
using Messenger.Infrastructure.Persistence;

namespace Messenger.Infrastructure.Repositories;

// Infrastructure реализует интерфейсы из Domain. Так мы не привязываем Application к EF и можем менять БД.

public class UserRepository : IUserRepository
{
    private readonly AppDbContext _db;

    public UserRepository(AppDbContext db)
    {
        _db = db;
    }

    public async Task<User?> GetByIdAsync(Guid id, CancellationToken ct = default)
    {
        await Task.CompletedTask;
        return null;
    }

    public async Task<User?> GetByEmailAsync(string email, CancellationToken ct = default)
    {
        await Task.CompletedTask;
        return null;
    }

    public async Task<Guid> AddAsync(User user, CancellationToken ct = default)
    {
        await Task.CompletedTask;
        return user.Id;
    }
}
