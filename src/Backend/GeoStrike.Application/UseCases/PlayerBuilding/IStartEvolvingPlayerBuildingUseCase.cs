// Solução: GeoStrike | Projeto: GeoStrike.Application
// Licenciado sob a Licença MIT. Veja o arquivo LICENSE na raiz para mais detalhes.
// Criado em: 08/07/2026 por Kara Gottschall

namespace GeoStrike.Application.UseCases.PlayerBuilding;

public interface IStartEvolvingPlayerBuildingUseCase
{
    Task<bool> ExecuteAsync(StartEvolvingPlayerBuildingRequest request);
}