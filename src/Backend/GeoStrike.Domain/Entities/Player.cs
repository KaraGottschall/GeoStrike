namespace GeoStrike.Domain.Entities;

public class Player
{
    public Guid Id { get; set; } = Guid.CreateVersion7();
    public string Name { get; set; } = string.Empty;

    public double Money { get; set; }
    public int Gold { get; set; }
    public int Oil { get; set; }

    public ICollection<PlayerBuilding> Buildings { get; set; } = new List<PlayerBuilding>();

    public bool HasMoneyEnough(double costToUpgrade) => Money >= costToUpgrade;
}