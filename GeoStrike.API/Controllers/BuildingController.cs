#region

using GeoStrike.Application.UseCases.Building;
using GeoStrike.Comunication.Requests;
using Microsoft.AspNetCore.Mvc;

#endregion

namespace GeoStrike.API.Controllers;

[ApiController, Route("[controller]")]
public class BuildingController : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> StartEvolvingBuilding(
        [FromBody] StartEvolvingBuildingRequest request,
        [FromServices] IStartEvolvingBuildingUseCase service
    )
    {
        bool result = await service.ExecuteAsync(request);
        return Ok(result);
    }
}