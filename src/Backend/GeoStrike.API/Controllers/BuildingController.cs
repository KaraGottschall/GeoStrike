// Solução: GeoStrike | Projeto: GeoStrike.API
// Licenciado sob a Licença MIT. Veja o arquivo LICENSE na raiz para mais detalhes.
// Criado em: 07/07/2026 por Kara Gottschall

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