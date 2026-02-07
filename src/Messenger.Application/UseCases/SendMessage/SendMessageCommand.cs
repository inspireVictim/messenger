namespace Messenger.Application.UseCases.SendMessage;

public record SendMessageCommand(Guid ChatId, Guid SenderId, string PlainTextContent);
