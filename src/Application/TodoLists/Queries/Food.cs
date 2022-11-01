using se22m060_swe_ca.Domain.Common;

namespace se22m060_swe_ca.Application.TodoLists.Queries.GetTodos;

public class Food : BaseAuditableEntity
{
    public Food(string name, string description, decimal price, DateTime menuDate)
    {
        Name = name;
        Description = description;
        Price = price;
        MenuDate = menuDate;
    }

    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public DateTime MenuDate { get; set; }
}