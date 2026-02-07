using Messenger.Domain.Interfaces;

namespace Messenger.Application.UseCases.RegisterUser;

// Работаем через интерфейсы репозиториев — так слой не знает про БД и легко тестируется моками.
// DbContext здесь не фигурирует: всё persistence идёт через репозитории, которые регистрируются в WebAPI/Infrastructure.

public class RegisterUserHandler
{
    private readonly IUserRepository _userRepository;

    public RegisterUserHandler(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<Guid> HandleAsync(RegisterUserCommand command, CancellationToken ct = default)
    {
        // Бизнес-логика регистрации — здесь. Валидация, хеширование пароля (через сервис), проверка дубликата по email.
        // Пока заглушка: возвращаем пустой Id. Реализацию допишет разработчик слоя Application.
        await Task.CompletedTask;
        return Guid.Empty;
    }
}
