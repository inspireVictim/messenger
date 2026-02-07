namespace Messenger.Domain.Entities;

// Связь многие-ко-многим: пользователь — участник чата. Отдельная сущность, чтобы хранить роль/время входа при необходимости.

public class ChatParticipant
{
    public Guid Id { get; set; }
    public Guid ChatId { get; set; }
    public Guid UserId { get; set; }
    public DateTime JoinedAt { get; set; }
}
