using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace HubbardParkApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ValuesController : ControllerBase
  {
    private readonly ILogger<ValuesController> _logger;

    public ValuesController(ILogger<ValuesController> logger)
    {
      _logger = logger;
    }
    [HttpGet]
    public ActionResult<string> Get()
    {
      _logger.LogInformation("dear god please work!! Please!!!!");
      return "Hello space World";
    }
  }
}
