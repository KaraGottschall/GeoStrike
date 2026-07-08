#region

using GeoStrike.Domain.Repositories.Building;

#endregion

namespace GeoStrike.Infrastructure.DataAccess.Repository.Building;

public class BuildingRepository : IReadOnlyBuildingRepository
{
    public Task<int> CurrentBuildingLevel() => throw new NotImplementedException();
}