// Solução: GeoStrike | Projeto: GeoStrike.Domain
// Licenciado sob a Licença MIT. Veja o arquivo LICENSE na raiz para mais detalhes.
// Criado em: 08/07/2026 por Kara Gottschall

namespace GeoStrike.Domain.Repositories.PlayerBuilding;

public interface IWriteOnlyPlayerBuildingRepository
{
    Task IncreasePlayerBuildingLevelBy(Guid playerId, Guid buildingId, int amount);
}