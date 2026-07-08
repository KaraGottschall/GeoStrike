namespace GeoStrike.Domain.Repositories.PlayerBuilding;

public interface IWriteOnlyPlayerBuildingRepository
{
    Task IncreasePlayerBuildingLevelBy(Guid playerId, Guid buildingId, int amount);
}