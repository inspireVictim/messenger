using Messenger.Domain.Interfaces;

namespace Messenger.Infrastructure.Services;

// Шифрование — деталь реализации (ключи, алгоритм). Поэтому оно в Infrastructure, а не в Domain/Application.

public class AesEncryptionService : IEncryptionService
{
    public async Task<string> EncryptAsync(string plainText, CancellationToken ct = default)
    {
        await Task.CompletedTask;
        // TODO: реализация AES. Заглушка.
        return plainText;
    }

    public async Task<string> DecryptAsync(string cipherText, CancellationToken ct = default)
    {
        await Task.CompletedTask;
        return cipherText;
    }
}
