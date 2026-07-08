namespace GeoStrike.Application.Configuration;

public class BuildingRules
{
    public static double CalculateMoneyCostToEvolve(BuildingType buildingType, int targetLevel)
    {
        return buildingType switch
        {
            BuildingType.HeadQuarter => targetLevel * 1.2,
            var _ => throw new ArgumentOutOfRangeException(nameof(buildingType), buildingType, null)
        };
    }

    public static TimeSpan CalculateTimeSpentOnEvolution(BuildingType buildingType, int targetLevel)
    {
        return buildingType switch
        {
            BuildingType.HeadQuarter => TimeSpan.FromMinutes(targetLevel * 1.2),
            var _ => TimeSpan.FromMinutes(3)
        };
    }
}