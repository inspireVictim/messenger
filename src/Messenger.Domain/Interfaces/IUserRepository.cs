using Messenger.Domain.Entities;

namespace Messenger.Domain.Interfaces;

// Репозитории объявляем в Domain, реализуем в Infrastructure. Так Application не знает про БД.

public interface IUserRepository
{
    Task<User?> GetByIdAsync(Guid id, CancellationToken ct = default);
    Task<User?> GetByEmailAsync(string email, CancellationToken ct = default);
    Task<Guid> AddAsync(User user, CancellationToken ct = default);
}
