# Messenger.Domain

Ядро. Ни от кого не зависит.

## Твоя зона

- Сущности: `User`, `Chat`, `Message`, `ChatParticipant`.
- Интерфейсы: `IUserRepository`, `IChatRepository`, `IMessageRepository`, `IEncryptionService`, `IJwtService`.

## Правила

- Только чистая модель и контракты. Никаких ссылок на EF, ASP.NET, конкретные БД или библиотеки.
- Новые сущности и интерфейсы согласуй с архитектором; от них зависят Application и Infrastructure.

## Куда не лезть

Реализации репозиториев и сервисов — в Infrastructure. Здесь только интерфейсы.
