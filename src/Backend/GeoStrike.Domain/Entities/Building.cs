namespace GeoStrike.Domain.Entities;

public class Building
{
    public Guid Id { get; init; } = Guid.NewGuid();
    public BuildingType Type { get; init; }
    public short StartLevel { get; private set; } = 1;
}