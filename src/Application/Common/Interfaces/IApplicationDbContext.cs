using se22m060_swe_ca.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using se22m060_swe_ca.Application.TodoLists.Queries.GetTodos;

namespace se22m060_swe_ca.Application.Common.Interfaces;

public interface IApplicationDbContext
{
    DbSet<TodoList> TodoLists { get; }

    DbSet<TodoItem> TodoItems { get; }

    DbSet<Food> FoodItems { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
