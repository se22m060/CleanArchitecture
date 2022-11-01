using System.Globalization;
using se22m060_swe_ca.Application.Common.Interfaces;
using se22m060_swe_ca.Application.TodoLists.Queries.ExportTodos;
using se22m060_swe_ca.Infrastructure.Files.Maps;
using CsvHelper;

namespace se22m060_swe_ca.Infrastructure.Files;

public class CsvFileBuilder : ICsvFileBuilder
{
    public byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records)
    {
        using var memoryStream = new MemoryStream();
        using (var streamWriter = new StreamWriter(memoryStream))
        {
            using var csvWriter = new CsvWriter(streamWriter, CultureInfo.InvariantCulture);

            csvWriter.Configuration.RegisterClassMap<TodoItemRecordMap>();
            csvWriter.WriteRecords(records);
        }

        return memoryStream.ToArray();
    }
}
