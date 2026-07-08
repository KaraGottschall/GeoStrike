namespace GeoStrike.Communication.Requests;

public class StartEvolvingPlayerBuildingRequest
{
    public Guid BuildingId { get; set; }
    public Guid PlayerId { get; set; }
}