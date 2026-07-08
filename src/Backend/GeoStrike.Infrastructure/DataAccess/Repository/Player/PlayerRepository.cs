#region

using GeoStrike.Infrastructure.DataAccess;
using PlayerEntity = GeoStrike.Domain.Entities.Player;

#endregion

namespace GeoStrike.Domain.Repositories.Player;

public class PlayerRepository(GeoStrikeDbContext dbContext) : IReadOnlyPlayerRepository
{
    public async Task<bool> HasMoneyEnough(Guid playerId, double targetAmount)
    {
        PlayerEntity? player = await dbContext.Players.FindAsync(playerId);

        double? currency = player?.Money;

        return currency >= targetAmount;
    }
}