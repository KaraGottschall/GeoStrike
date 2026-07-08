#region

using GeoStrike.Domain.Enums;

#endregion

namespace GeoStrike.Domain.Entities;

public class Building
{
    public Guid Id { get; set; } = Guid.NewGuid();

    // public Guid PlayerId { get; private set; }
    public BuildingType Type { get; set; }

    public short startLevel { get; private set; } = 0;
    // public short Level { get; private set; }
    // public DateTime? CompletionDate { get; private set; }
}