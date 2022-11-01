using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace se22m060_swe_ca.WebUI.Controllers;

[AllowAnonymous]
public class FoodController : ApiControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetTodaysMenu()
    {
        return Ok(await Mediator.Send(new GetFoodQuery()));
    }
}
