// Solução: GeoStrike | Projeto: GeoStrike.Infrastructure
// Licenciado sob a Licença MIT. Veja o arquivo LICENSE na raiz para mais detalhes.
// Criado em: 07/07/2026 por Kara Gottschall

namespace GeoStrike.Infrastructure.DataAccess.EntitiesConfiguration;

public class BuildingConfiguration : IEntityTypeConfiguration<Building>
{
    public static readonly Guid HeadquartersTemplateId = Guid.Parse("CDEAFBCE-68B1-4127-940A-A6211B1A43D7");

    public void Configure(EntityTypeBuilder<Building> builder)
    {
        builder.HasKey(b => b.Id);

        builder.HasData(new Building
        {
            Id = HeadquartersTemplateId,
            Type = BuildingType.HeadQuarter
        });
    }
}