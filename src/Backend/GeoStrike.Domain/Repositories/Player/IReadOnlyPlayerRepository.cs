namespace GeoStrike.Domain.Repositories.Player;

public interface IReadOnlyPlayerRepository
{
    Task<PlayerEntity> GetByIdAsync(Guid playerId);
    Task<bool> HasMoneyEnough(Guid playerId, double targetAmount);
    Task<PlayerBuildingEntity?> GetPlayerBuildingById(Guid playerId, Guid buildingId);
}