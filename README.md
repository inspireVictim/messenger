# Messenger — архитектурный каркас backend

Clean Architecture на .NET 8. Это не готовый продукт, а **заготовка под команду**: каждый разработчик работает в своём слое, без пересечений.

## Правило зависимостей

- **Domain** — ни от кого не зависит. Только сущности и интерфейсы.
- **Application** — зависит только от Domain. Use cases, никакого EF/DbContext.
- **Infrastructure** — зависит от Application и Domain. Реализации репозиториев, EF, шифрование, JWT.
- **WebAPI** — зависит от Application и Infrastructure. Контроллеры, SignalR, DI.

Циклических зависимостей быть не должно. Не тащите ссылки на WebAPI или Infrastructure в Domain/Application.

## Кто за что отвечает

| Слой           | Кто работает | Что делает |
|----------------|--------------|------------|
| Domain         | Бэкенд-архитектор / команда Domain | Сущности, интерфейсы репозиториев и сервисов. Никакого EF, никакого ASP.NET. |
| Application    | Разработчик use cases | Handlers (RegisterUser, CreateChat, SendMessage и т.д.). Вся бизнес-логика здесь. Вызов только через интерфейсы. |
| Infrastructure | Разработчик инфраструктуры | AppDbContext, репозитории, AesEncryptionService, JwtService. Всё, что связано с БД и внешними сервисами. |
| WebAPI         | Разработчик API | Контроллеры, SignalR Hub, Program.cs, DI. Контроллеры только вызывают Application, логику не содержат. |

## Куда нельзя лезть

- В **Domain** не добавлять ссылки на EF, ASP.NET, конкретные реализации.
- В **Application** не использовать DbContext и не знать про PostgreSQL/конкретную БД.
- В **WebAPI** не писать бизнес-логику — только вызов handler'ов из Application.

## Сборка и запуск

```bash
dotnet restore
dotnet build
```

Запуск API (нужен PostgreSQL на localhost или через docker-compose):

```bash
cd src/Messenger.WebAPI && dotnet run
```

Через Docker:

```bash
docker compose up --build
```

API: `http://localhost:5000`. PostgreSQL: порт 5432, логин/пароль `postgres/postgres`, БД `messenger`.

## Структура решения

```
src/
  Messenger.Domain/       # Сущности, интерфейсы
  Messenger.Application/  # Use cases (handlers)
  Messenger.Infrastructure/ # EF, репозитории, сервисы
  Messenger.WebAPI/       # API, контроллеры, SignalR
```

Подробнее — README в каждом проекте.
# messenger
