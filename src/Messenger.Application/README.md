# Messenger.Application

Use cases. Зависит только от Domain.

## Твоя зона

- Команды и handler'ы: `RegisterUser`, `CreateChat`, `SendMessage` и все будущие сценарии.
- Вся бизнес-логика живёт здесь. Работа с данными — только через интерфейсы из Domain (репозитории, IEncryptionService и т.д.).

## Правила

- Не использовать DbContext и не знать про PostgreSQL. Только интерфейсы.
- Handlers получают зависимости через конструктор; регистрация — в `DependencyInjection.cs`. Новый use case — новый handler + при необходимости регистрация в DI (в Application и вызов из WebAPI).

## Куда не лезть

Реализации репозиториев, EF, шифрование, JWT — в Infrastructure. Контроллеры и маршруты — в WebAPI.
