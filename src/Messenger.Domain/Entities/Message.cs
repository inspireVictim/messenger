namespace Messenger.Domain.Entities;

// Сообщение принадлежит чату и автору. Контент может храниться уже зашифрованным — шифрование в Infrastructure.

public class Message
{
    public Guid Id { get; set; }
    public Guid ChatId { get; set; }
    public Guid SenderId { get; set; }
    public string ContentEncrypted { get; set; } = string.Empty;
    public DateTime SentAt { get; set; }
}
