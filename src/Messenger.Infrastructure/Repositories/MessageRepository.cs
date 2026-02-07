using Messenger.Domain.Entities;
using Messenger.Domain.Interfaces;
using Messenger.Infrastructure.Persistence;

namespace Messenger.Infrastructure.Repositories;

public class MessageRepository : IMessageRepository
{
    private readonly AppDbContext _db;

    public MessageRepository(AppDbContext db)
    {
        _db = db;
    }

    public async Task<Message?> GetByIdAsync(Guid id, CancellationToken ct = default)
    {
        await Task.CompletedTask;
        return null;
    }

    public async Task<Guid> AddAsync(Message message, CancellationToken ct = default)
    {
        await Task.CompletedTask;
        return message.Id;
    }
}
