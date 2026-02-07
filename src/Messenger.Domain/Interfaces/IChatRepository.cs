using Messenger.Domain.Entities;

namespace Messenger.Domain.Interfaces;

public interface IChatRepository
{
    Task<Chat?> GetByIdAsync(Guid id, CancellationToken ct = default);
    Task<Guid> AddAsync(Chat chat, CancellationToken ct = default);
}
