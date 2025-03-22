using Microsoft.AspNetCore.Mvc;

namespace sqsPub.api.Controller;

[ApiController]
[Route("api/[controller]")]
public class GunShipController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok();
    }
    
    [HttpPost]
    public IActionResult DoCommand()
    {
        return Ok();
    }
}