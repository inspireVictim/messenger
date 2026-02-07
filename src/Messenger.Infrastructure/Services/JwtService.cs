using Messenger.Domain.Interfaces;

namespace Messenger.Infrastructure.Services;

// JWT — инфраструктурная деталь (секреты, алгоритм). Реализуем интерфейс из Domain, регистрируем в DI.

public class JwtService : IJwtService
{
    public string GenerateToken(Guid userId, string userName)
    {
        // TODO: создать JWT с нужными claims. Заглушка.
        return string.Empty;
    }

    public (Guid? UserId, bool IsValid) ValidateToken(string token)
    {
        return (null, false);
    }
}
