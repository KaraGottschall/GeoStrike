#region

using GeoStrike.Application.UseCases.PlayerBuilding;
using GeoStrike.Comunication.Requests;
using Microsoft.AspNetCore.Mvc;

#endregion

namespace GeoStrike.API.Controllers;

[ApiController, Route("[controller]")]
public class BuildingController : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> StartEvolvingBuilding(
        [FromBody] StartEvolvingPlayerBuildingRequest request,
        [FromServices] IStartEvolvingPlayerBuildingUseCase service
    )
    {
        bool result = await service.ExecuteAsync(request);
        return Ok(result);
    }
}