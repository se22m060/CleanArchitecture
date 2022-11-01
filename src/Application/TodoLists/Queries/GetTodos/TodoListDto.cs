using se22m060_swe_ca.Application.Common.Mappings;
using se22m060_swe_ca.Domain.Entities;

namespace se22m060_swe_ca.Application.TodoLists.Queries.GetTodos;

public class TodoListDto : IMapFrom<TodoList>
{
    public TodoListDto()
    {
        Items = new List<TodoItemDto>();
    }

    public int Id { get; set; }

    public string? Title { get; set; }

    public string? Colour { get; set; }

    public IList<TodoItemDto> Items { get; set; }
}
