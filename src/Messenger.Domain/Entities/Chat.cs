namespace Messenger.Domain.Entities;

// Чат — агрегат для группы сообщений. Не тянем сюда навигационные свойства из EF — только данные.

public class Chat
{
    public Guid Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public bool IsGroup { get; set; }
    public DateTime CreatedAt { get; set; }
}
