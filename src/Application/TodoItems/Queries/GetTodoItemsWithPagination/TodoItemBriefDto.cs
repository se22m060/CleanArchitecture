using se22m060_swe_ca.Application.Common.Mappings;
using se22m060_swe_ca.Domain.Entities;

namespace se22m060_swe_ca.Application.TodoItems.Queries.GetTodoItemsWithPagination;

public class TodoItemBriefDto : IMapFrom<TodoItem>
{
    public int Id { get; set; }

    public int ListId { get; set; }

    public string? Title { get; set; }

    public bool Done { get; set; }
}
