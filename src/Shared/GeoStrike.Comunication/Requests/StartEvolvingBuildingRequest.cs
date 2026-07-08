namespace GeoStrike.Comunication.Requests;

public class StartEvolvingBuildingRequest
{
    public Guid BuildingId { get; set; }
    public Guid PlayerId { get; set; }
    public DateTime? CompletionDate { get; set; }
}