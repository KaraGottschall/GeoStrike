#region

using GeoStrike.Domain.Enums;

#endregion

namespace GeoStrike.Domain.Repositories.Building;

public interface IReadOnlyBuildingRepository
{
    Task<BuildingType> GetBuildingTypeById(Guid buildingId);
}