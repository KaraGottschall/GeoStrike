// Solução: GeoStrike | Projeto: GeoStrike.Domain
// Licenciado sob a Licença MIT. Veja o arquivo LICENSE na raiz para mais detalhes.
// Criado em: 07/07/2026 por Kara Gottschall

namespace GeoStrike.Domain.Repositories.Player;

public interface IReadOnlyPlayerRepository
{
    Task<PlayerEntity> GetByIdAsync(Guid playerId);
    Task<bool> HasMoneyEnough(Guid playerId, double targetAmount);
    Task<PlayerBuildingEntity?> GetPlayerBuildingById(Guid playerId, Guid buildingId);
}