using se22m060_swe_ca.Application.Common.Mappings;
using se22m060_swe_ca.Domain.Entities;

namespace se22m060_swe_ca.Application.TodoLists.Queries.ExportTodos;

public class TodoItemRecord : IMapFrom<TodoItem>
{
    public string? Title { get; set; }

    public bool Done { get; set; }
}
