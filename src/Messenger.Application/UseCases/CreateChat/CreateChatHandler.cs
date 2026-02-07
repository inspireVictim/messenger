using Messenger.Domain.Interfaces;

namespace Messenger.Application.UseCases.CreateChat;

// Use case зависит только от интерфейсов Domain. Создание чата и добавление участника — зона ответственности этого handler'а.

public class CreateChatHandler
{
    private readonly IChatRepository _chatRepository;

    public CreateChatHandler(IChatRepository chatRepository)
    {
        _chatRepository = chatRepository;
    }

    public async Task<Guid> HandleAsync(CreateChatCommand command, CancellationToken ct = default)
    {
        // Создать чат, при необходимости добавить Creator как участника. Пока заглушка.
        await Task.CompletedTask;
        return Guid.Empty;
    }
}
