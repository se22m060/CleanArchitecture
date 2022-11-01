using Microsoft.AspNetCore.Mvc;

namespace se22m060_swe_ca.WebUI.Controllers;

[ApiExplorerSettings(IgnoreApi = true)]
public class OidcConfigurationController : Controller
{
    private readonly ILogger<OidcConfigurationController> logger;

    public OidcConfigurationController(ILogger<OidcConfigurationController> _logger)
    {
        logger = _logger;
    }

    [HttpGet("_configuration/{clientId}")]
    public IActionResult GetClientRequestParameters([FromRoute] string clientId)
    {
        return Ok(clientId);
    }
}
