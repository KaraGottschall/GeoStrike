#region

using GeoStrike.Domain.Repositories.Player;
using Microsoft.EntityFrameworkCore;
using PlayerEntity = GeoStrike.Domain.Entities.Player;
using PlayerBuildingEntity = GeoStrike.Domain.Entities.PlayerBuilding;

#endregion

namespace GeoStrike.Infrastructure.DataAccess.Repositories.Player;

public class PlayerRepository(GeoStrikeDbContext dbContext) : IReadOnlyPlayerRepository
{
    public async Task<PlayerEntity?> GetByIdAsync(Guid playerId) => await dbContext.Players
        .Include(p => p.Buildings)
        .ThenInclude(pb => pb.Building)
        .FirstOrDefaultAsync(p => p.Id == playerId);

    public async Task<bool> HasMoneyEnough(Guid playerId, double targetAmount)
    {
        PlayerEntity? player = await dbContext.Players.FindAsync(playerId);

        double? currency = player?.Money;

        return currency >= targetAmount;
    }

    public async Task<PlayerBuildingEntity?> GetPlayerBuildingById(Guid playerId, Guid buildingId)
    {
        PlayerBuildingEntity? playerBuilding = await dbContext.PlayerBuildings
            .FirstOrDefaultAsync(pb => pb.PlayerId == playerId && pb.BuildingId == buildingId);

        return playerBuilding;
    }
}