namespace Messenger.Domain.Interfaces;

// Выдача и проверка JWT — деталь инфраструктуры. Domain задаёт контракт, реализация в Infrastructure.

public interface IJwtService
{
    string GenerateToken(Guid userId, string userName);
    (Guid? UserId, bool IsValid) ValidateToken(string token);
}
