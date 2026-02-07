using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Messenger.Domain.Interfaces;
using Messenger.Infrastructure.Persistence;
using Messenger.Infrastructure.Repositories;
using Messenger.Infrastructure.Services;

namespace Messenger.Infrastructure;

// Регистрация всех реализаций из Infrastructure в DI. WebAPI только вызывает AddInfrastructure().

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, string connectionString)
    {
        services.AddDbContext<AppDbContext>(o => o.UseNpgsql(connectionString));

        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<IChatRepository, ChatRepository>();
        services.AddScoped<IMessageRepository, MessageRepository>();
        services.AddScoped<IEncryptionService, AesEncryptionService>();
        services.AddScoped<IJwtService, JwtService>();

        return services;
    }
}
