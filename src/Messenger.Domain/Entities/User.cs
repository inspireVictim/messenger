namespace Messenger.Domain.Entities;

// Этот слой не должен зависеть ни от EF, ни от ASP.NET.
// Здесь только чистая бизнес-модель. User — корневая сущность для идентификации и чатов.

public class User
{
    public Guid Id { get; set; }
    public string UserName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string PasswordHash { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; }
}
