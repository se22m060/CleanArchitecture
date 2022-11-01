using se22m060_swe_ca.Application.Common.Mappings;
using se22m060_swe_ca.Domain.Entities;

namespace se22m060_swe_ca.Application.Common.Models;

// Note: This is currently just used to demonstrate applying multiple IMapFrom attributes.
public class LookupDto : IMapFrom<TodoList>, IMapFrom<TodoItem>
{
    public int Id { get; set; }

    public string? Title { get; set; }
}
