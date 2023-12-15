using Microsoft.AspNetCore.Mvc;

[Route("api/montyhall")]
[ApiController]
public class MontyHallController : ControllerBase
{
    private readonly MontyHallService _montyHallService;

    public MontyHallController(MontyHallService montyHallService)
    {
        _montyHallService = montyHallService;
    }

    [HttpPost("simulate")]
    public ActionResult<MontyHallSimulationResult> SimulateGames([FromBody] SimulationRequest request)
    {
        if (request == null)
        {
            return BadRequest("Invalid input");
        }

        MontyHallSimulationResult result = _montyHallService.SimulateGames(request.TotalGames, request.SwitchDoor);

        return Ok(result);
    }
}
