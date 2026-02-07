namespace Messenger.Domain.Interfaces;

// Шифрование — деталь реализации (алгоритм, ключи). Domain только требует контракт: зашифровать/расшифровать.

public interface IEncryptionService
{
    Task<string> EncryptAsync(string plainText, CancellationToken ct = default);
    Task<string> DecryptAsync(string cipherText, CancellationToken ct = default);
}
