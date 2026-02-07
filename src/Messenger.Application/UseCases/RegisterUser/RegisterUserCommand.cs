namespace Messenger.Application.UseCases.RegisterUser;

// Команда — только данные. Бизнес-логики здесь нет.

public record RegisterUserCommand(string UserName, string Email, string Password);
