using Messenger.Domain.Interfaces;

namespace Messenger.Application.UseCases.SendMessage;

// Шифрование контента — через IEncryptionService. Application решает, что шифровать; как — в Infrastructure.

public class SendMessageHandler
{
    private readonly IMessageRepository _messageRepository;
    private readonly IEncryptionService _encryptionService;

    public SendMessageHandler(IMessageRepository messageRepository, IEncryptionService encryptionService)
    {
        _messageRepository = messageRepository;
        _encryptionService = encryptionService;
    }

    public async Task<Guid> HandleAsync(SendMessageCommand command, CancellationToken ct = default)
    {
        // Зашифровать PlainTextContent, сохранить Message с ContentEncrypted. Заглушка.
        await Task.CompletedTask;
        return Guid.Empty;
    }
}
