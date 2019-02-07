using Microsoft.AspNetCore.Mvc;

namespace HubbardParkApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ValuesController : ControllerBase
  {
    [HttpGet]
    public ActionResult<string> Get()
    {
      return "Hello space World";
    }
  }
}
