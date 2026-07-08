namespace GeoStrike.Domain.Repositories.Building;

public interface IReadOnlyBuildingRepository
{
    Task<int> CurrentBuildingLevel();
}