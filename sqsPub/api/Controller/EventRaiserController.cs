using Microsoft.AspNetCore.Mvc;

namespace sqsPub.api.Controller;

[ApiController]
[Route("api/[controller]")]
public class EventRaiserController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok();
    }
}