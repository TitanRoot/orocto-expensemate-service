using Microsoft.AspNetCore.Mvc;

namespace Orocto.ExpenseMate.API;

[ApiController]
[Route("api/[controller]")]
public class LoginController : ControllerBase
{
    public LoginController(ILogger<LoginController> logger)
    {
        
    }
    
    [HttpGet]
    [Route("Get/v1")]
    public IActionResult Get()
    {
        return Ok("Hello World");
    }
    
    
}