#region

using GeoStrike.Comunication.Requests;

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