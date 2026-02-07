using Messenger.Application;
using Messenger.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Контроллеры не содержат бизнес-логики — только вызывают Application (handlers).
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSignalR();

builder.Services.AddApplication();
builder.Services.AddInfrastructure(builder.Configuration.GetConnectionString("DefaultConnection") ?? "Host=localhost;Database=messenger;Username=postgres;Password=postgres");

var app = builder.Build();

app.UseHttpsRedirection();
app.MapControllers();
app.MapHub<Messenger.WebAPI.Hubs.ChatHub>("/hubs/chat");

app.Run();
