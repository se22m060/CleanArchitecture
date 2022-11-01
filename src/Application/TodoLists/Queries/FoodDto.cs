using System.Runtime.Serialization;

namespace se22m060_swe_ca.Application.TodoLists.Queries.GetTodos;

[DataContract]
public class FoodDto
{
    public FoodDto(Food food)
    {
        Name = food.Name;
        Description = food.Description;
        Price = food.Price;
        MenuDate = food.MenuDate;
    }

    public FoodDto(string name, string description, decimal price, DateTime menuDate)
    {
        Name = name;
        Description = description;
        Price = price;
        MenuDate = menuDate;
    }

    [DataMember(Name = "name")]
    public string Name { get; set; }
    
    [DataMember(Name = "desc")]
    public string Description { get; set; }

    [DataMember(Name = "price")]
    public decimal Price { get; set; }

    [DataMember(Name = "menuDate")]
    public DateTime MenuDate { get; set; }
}