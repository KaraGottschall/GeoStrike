// Solução: GeoStrike | Projeto: GeoStrike.Application
// Licenciado sob a Licença MIT. Veja o arquivo LICENSE na raiz para mais detalhes.
// Criado em: 07/07/2026 por Kara Gottschall

namespace GeoStrike.Application.Configuration;

public class BuildingRules
{
    public static double EvolutionCostMultiplier(BuildingType buildingType) => buildingType switch
    {
        BuildingType.HeadQuarter => 1.02,
        BuildingType.OilRefinary => 1.04,
        var _ => throw new ArgumentOutOfRangeException(nameof(buildingType), buildingType, null)
    };

    public static double GetConstructionFee(BuildingType buildingType) => buildingType switch
    {
        BuildingType.HeadQuarter => 200,
        BuildingType.OilRefinary => 240,
        var _ => throw new ArgumentOutOfRangeException(nameof(buildingType), buildingType, null)
    };
}