// Solução: GeoStrike | Projeto: GeoStrike.Domain
// Licenciado sob a Licença MIT. Veja o arquivo LICENSE na raiz para mais detalhes.
// Criado em: 07/07/2026 por Kara Gottschall

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