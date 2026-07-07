#region

using GeoStrike.Domain.Enums;

#endregion

namespace GeoStrike.Domain.Entities;

public class Building
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public Guid PlayerId { get; private set; }
    public BuildingType Type { get; private set; }
    public short Level { get; private set; }
    public DateTime? CompletionDate { get; private set; }
}