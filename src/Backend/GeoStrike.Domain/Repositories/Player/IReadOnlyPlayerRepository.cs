#region

using PlayerEntity = GeoStrike.Domain.Entities.Player;
using PlayerBuildingEntity = GeoStrike.Domain.Entities.PlayerBuilding;

#endregion

namespace GeoStrike.Domain.Repositories.Player;

public interface IReadOnlyPlayerRepository
{
    Task<PlayerEntity> GetByIdAsync(Guid playerId);
    Task<bool> HasMoneyEnough(Guid playerId, double targetAmount);
    Task<PlayerBuildingEntity?> GetPlayerBuildingById(Guid playerId, Guid buildingId);
}