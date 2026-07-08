namespace GeoStrike.Infrastructure.DataAccess.Repositories.Building;

public class BuildingRepository(GeoStrikeDbContext dbContext) : IReadOnlyBuildingRepository
{
    public async Task<BuildingType> GetBuildingTypeById(Guid buildingId)
    {
        BuildingType? buildingType = await dbContext.Buildings
            .Where(b => b.Id == buildingId)
            .Select(b => b.Type)
            .FirstOrDefaultAsync();

        return buildingType.Value;
    }
}