using Microsoft.AspNetCore.Mvc;
using se22m060_swe_ca.Application.Common.Models;
using se22m060_swe_ca.Application.TodoItems.Queries.GetTodoItemsWithPagination;

namespace se22m060_swe_ca.WebUI.Controllers;

public class FoodController : ApiControllerBase
{
    public FoodController()
    {
    }

    [HttpGet]
    [Route("")]
    public async Task<IActionResult> GetTodaysMenu()
    {
        return Ok(await Mediator.Send(new GetFoodQuery()));
    }
}
