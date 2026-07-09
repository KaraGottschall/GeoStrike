// Solução: GeoStrike | Projeto: GeoStrike.Domain
// Licenciado sob a Licença MIT. Veja o arquivo LICENSE na raiz para mais detalhes.
// Criado em: 09/07/2026 por Kara Gottschall

namespace GeoStrike.Domain.Models;

public class BuildingDefinition
{
    public BuildingType Type { get; init; }
    public string Name { get; init; } = string.Empty;
    public string Description { get; init; } = string.Empty;

    public ResourceType? ResourceType { get; init; }
    public int BaseProductionRate { get; init; }
    public double BaseConstructionCost { get; init; }
}