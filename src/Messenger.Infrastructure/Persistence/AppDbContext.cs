using Microsoft.EntityFrameworkCore;
using Messenger.Domain.Entities;

namespace Messenger.Infrastructure.Persistence;

// EF и БД живут только в Infrastructure. Domain не знает про DbContext.
// Конфигурация сущностей — здесь (Fluent API при необходимости).

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<User> Users => Set<User>();
    public DbSet<Chat> Chats => Set<Chat>();
    public DbSet<Message> Messages => Set<Message>();
    public DbSet<ChatParticipant> ChatParticipants => Set<ChatParticipant>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Маппинг и индексы — здесь. Пока без дополнительной конфигурации.
        base.OnModelCreating(modelBuilder);
    }
}
