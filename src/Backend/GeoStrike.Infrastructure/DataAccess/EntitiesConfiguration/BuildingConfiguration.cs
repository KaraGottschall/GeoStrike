// Solução: GeoStrike | Projeto: GeoStrike.Infrastructure
// Licenciado sob a Licença MIT. Veja o arquivo LICENSE na raiz para mais detalhes.
// Criado em: 07/07/2026 por Kara Gottschall

namespace GeoStrike.Infrastructure.DataAccess.EntitiesConfiguration;

public class BuildingConfiguration : IEntityTypeConfiguration<Building>
{
    public static readonly Guid HeadquartersTemplateId = Guid.Parse("CDEAFBCE-68B1-4127-940A-A6211B1A43D7");
    public static readonly Guid OilrefinaryTemplateId = Guid.Parse("B9336DD7-CFAA-4B03-A0B3-D46AF7A94B96");

    private static readonly IReadOnlyList<Building> StartingBuildings = new List<Building>
    {
        new()
        {
            Id = HeadquartersTemplateId,
            Type = BuildingType.HeadQuarter,
            ConstructionCost = 0.0
        },
        new()
        {
            Id = OilrefinaryTemplateId,
            Type = BuildingType.OilRefinery,
            ConstructionCost = 100.0
        }
    };

    public void Configure(EntityTypeBuilder<Building> builder)
    {
        builder.HasKey(b => b.Id);

        builder.HasData(StartingBuildings);
    }
}