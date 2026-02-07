using Messenger.Domain.Entities;

namespace Messenger.Domain.Interfaces;

public interface IMessageRepository
{
    Task<Message?> GetByIdAsync(Guid id, CancellationToken ct = default);
    Task<Guid> AddAsync(Message message, CancellationToken ct = default);
}
