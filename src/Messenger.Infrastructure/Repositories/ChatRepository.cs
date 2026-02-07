using Messenger.Domain.Entities;
using Messenger.Domain.Interfaces;
using Messenger.Infrastructure.Persistence;

namespace Messenger.Infrastructure.Repositories;

public class ChatRepository : IChatRepository
{
    private readonly AppDbContext _db;

    public ChatRepository(AppDbContext db)
    {
        _db = db;
    }

    public async Task<Chat?> GetByIdAsync(Guid id, CancellationToken ct = default)
    {
        await Task.CompletedTask;
        return null;
    }

    public async Task<Guid> AddAsync(Chat chat, CancellationToken ct = default)
    {
        await Task.CompletedTask;
        return chat.Id;
    }
}
