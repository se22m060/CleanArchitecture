using se22m060_swe_ca.Application.TodoLists.Queries.ExportTodos;

namespace se22m060_swe_ca.Application.Common.Interfaces;

public interface ICsvFileBuilder
{
    byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
}
