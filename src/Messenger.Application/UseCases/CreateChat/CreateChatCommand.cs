namespace Messenger.Application.UseCases.CreateChat;

public record CreateChatCommand(string Title, bool IsGroup, Guid CreatorId);
