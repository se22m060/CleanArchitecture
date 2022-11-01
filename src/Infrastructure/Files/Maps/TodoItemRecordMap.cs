using System.Globalization;
using se22m060_swe_ca.Application.TodoLists.Queries.ExportTodos;
using CsvHelper.Configuration;

namespace se22m060_swe_ca.Infrastructure.Files.Maps;

public class TodoItemRecordMap : ClassMap<TodoItemRecord>
{
    public TodoItemRecordMap()
    {
        AutoMap(CultureInfo.InvariantCulture);

        Map(m => m.Done).ConvertUsing(c => c.Done ? "Yes" : "No");
    }
}
