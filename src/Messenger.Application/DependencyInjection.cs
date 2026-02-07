using Microsoft.Extensions.DependencyInjection;
using Messenger.Application.UseCases.RegisterUser;
using Messenger.Application.UseCases.CreateChat;
using Messenger.Application.UseCases.SendMessage;

namespace Messenger.Application;

// Регистрация use case handler'ов. Контроллеры вызывают только их, не репозитории напрямую.

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<RegisterUserHandler>();
        services.AddScoped<CreateChatHandler>();
        services.AddScoped<SendMessageHandler>();
        return services;
    }
}
