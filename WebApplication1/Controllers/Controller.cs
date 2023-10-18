using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplication1.DTO;
using WebApplication1.Service;

namespace WebApplication1.Controllers;

[ApiController]
[Route("api/v1/mapper")]
public class Controller : ControllerBase
{
  

    private readonly ILogger<Controller> _logger;
    private readonly Mapper _mapper;

    public Controller(ILogger<Controller> logger, Mapper mapper)
    {
        _logger = logger;
        _mapper = mapper;
    }

    [HttpGet]
    public ActionResult<Root> GetDummyData()
    {
        RootRequest requestFraAPI = null;  //GetDataFromAPI(); METODE HER FOR Å HENT DATA FRA API'ET OG PARSE DET TIL RootRequest
        return Ok(_mapper.MapRoot2ToRoot(requestFraAPI));
    }
}
