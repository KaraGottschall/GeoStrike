namespace GeoStrike.Domain.Entities;

public class Player
{
    public Guid Id { get; set; } = Guid.CreateVersion7();
    public string Name { get; set; } = string.Empty;

    public int Money { get; set; }
    public int Gold { get; set; }
    public int Oil { get; set; }
}