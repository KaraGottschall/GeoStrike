// Solução: GeoStrike | Projeto: GeoStrike.API
// Licenciado sob a Licença MIT. Veja o arquivo LICENSE na raiz para mais detalhes.
// Criado em: 09/07/2026 por Kara Gottschall

namespace GeoStrike.API.Controllers;

[ApiController, Route("[controller]")]
public class PlayerController : ControllerBase
{
    [HttpGet("{id:guid}")]
    public async Task<IActionResult> GetPlayerById(
        [FromRoute] Guid id,
        [FromServices] IGetPlayerByIdUseCase service
    )
    {
        GetPlayerByIdRequest request = new() { PlayerId = id };
        Player? result = await service.ExecuteAsync(request);
        return Ok(result);
    }
}