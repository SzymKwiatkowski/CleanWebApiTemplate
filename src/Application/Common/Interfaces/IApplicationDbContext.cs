using RestApiTemplate.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace RestApiTemplate.Application.Common.Interfaces;

public interface IApplicationDbContext
{
    DbSet<TodoList> TodoLists { get; }

    DbSet<TodoItem> TodoItems { get; }

    DbSet<BoardTask> BoardTasks { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
