namespace GeoStrike.Comunication.Requests;

public class StartEvolvingPlayerBuildingRequest
{
    public Guid BuildingId { get; init; }
    public Guid PlayerId { get; init; }
}