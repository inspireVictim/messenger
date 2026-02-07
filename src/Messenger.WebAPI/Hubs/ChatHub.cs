using Microsoft.AspNetCore.SignalR;

namespace Messenger.WebAPI.Hubs;

// Заглушка SignalR Hub. Реальное подписывание на чаты и рассылка сообщений — зона ответственности разработчика WebAPI/Infrastructure.

public class ChatHub : Hub
{
    public override Task OnConnectedAsync()
    {
        return base.OnConnectedAsync();
    }

    public Task JoinChatAsync(string chatId)
    {
        return Groups.AddToGroupAsync(Context.ConnectionId, chatId);
    }

    public Task LeaveChatAsync(string chatId)
    {
        return Groups.RemoveFromGroupAsync(Context.ConnectionId, chatId);
    }
}
