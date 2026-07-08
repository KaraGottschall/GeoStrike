namespace GeoStrike.Domain.Repositories.Player;

public interface IReadOnlyPlayerRepository
{
    Task<bool> HasMoneyEnough(Guid playerId, double targetAmount);
}