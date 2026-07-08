namespace GeoStrike.Infrastructure.DataAccess.Repositories.PlayerBuilding;

public class PlayerBuildingRepository(GeoStrikeDbContext dbContext) : IWriteOnlyPlayerBuildingRepository
{
    public async Task IncreasePlayerBuildingLevelBy(Guid playerId, Guid buildingId, int amount)
    {
        await dbContext.PlayerBuildings
            .Where(pb => pb.PlayerId == playerId && pb.BuildingId == buildingId)
            .ExecuteUpdateAsync(setters => setters
                .SetProperty(pb => pb.Level, pb => pb.Level + amount));
    }
}