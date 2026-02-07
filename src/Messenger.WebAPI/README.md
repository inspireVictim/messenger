# Messenger.WebAPI

Точка входа: HTTP API и SignalR.

## Твоя зона

- `Program.cs`, настройка DI, pipeline.
- Контроллеры, SignalR Hub'ы.
- Маршруты, аутентификация (вызов JwtService через интерфейс уже зарегистрирован в Infrastructure).

## Правила

- Контроллеры не содержат бизнес-логики. Только вызов handler'ов из Application и возврат ответа.
- Все зависимости (репозитории, сервисы, handlers) регистрируются в Application и Infrastructure; в WebAPI только вызов `AddApplication()` и `AddInfrastructure()`.

## Куда не лезть

Бизнес-логика — в Application. Реализации репозиториев и сервисов — в Infrastructure. Сущности и интерфейсы — в Domain.
