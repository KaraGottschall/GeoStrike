#region

using GeoStrike.Communication.Requests;

#endregion

namespace CommonTestUtilities.Requests;

public class StartEvolvingPlayerBuildingRequestBuilder
{
    public static StartEvolvingPlayerBuildingRequest Build() => new()
    {
        PlayerId = Guid.NewGuid(),
        BuildingId = Guid.NewGuid(),
    };
}