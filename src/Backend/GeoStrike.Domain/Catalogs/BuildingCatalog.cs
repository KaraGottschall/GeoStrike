// Solução: GeoStrike | Projeto: GeoStrike.Domain
// Licenciado sob a Licença MIT. Veja o arquivo LICENSE na raiz para mais detalhes.
// Criado em: 09/07/2026 por Kara Gottschall

using GeoStrike.Domain.Models;

namespace GeoStrike.Domain.Catalogs;

public static class BuildingCatalog
{
    private static readonly Dictionary<BuildingType, BuildingDefinition> BuildingDefinitions = new()
    {
        [BuildingType.HeadQuarter] = new()
        {
            Type = BuildingType.HeadQuarter,
            Name = "Head Quarter",
            Description = "The command center of your tactical base.",
            ResourceType = null,
            BaseProductionRate = 0
        },
        [BuildingType.OilRefinary] = new()
        {
            Type = BuildingType.OilRefinary,
            Name = "Oil Refinary",
            Description = "Industrial infrastructure dedicated to the extraction"
                          + " and refining of crude oil from the tactical region.",
            ResourceType = ResourceType.Oil,
            BaseProductionRate = 100
        }
    };

    public static BuildingDefinition Get(BuildingType type) => BuildingDefinitions[type];
}