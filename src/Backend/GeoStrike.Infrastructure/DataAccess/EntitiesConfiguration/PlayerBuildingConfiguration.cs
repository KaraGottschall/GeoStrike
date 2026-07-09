// Solução: GeoStrike | Projeto: GeoStrike.Infrastructure
// Licenciado sob a Licença MIT. Veja o arquivo LICENSE na raiz para mais detalhes.
// Criado em: 08/07/2026 por Kara Gottschall

namespace GeoStrike.Infrastructure.DataAccess.EntitiesConfiguration;

public class PlayerBuildingConfiguration : IEntityTypeConfiguration<PlayerBuilding>
{
    public void Configure(EntityTypeBuilder<PlayerBuilding> builder)
    {
        builder.HasKey(pb => pb.Id);

        builder.HasOne(pb => pb.Player)
            .WithMany(p => p.Buildings)
            .HasForeignKey(pb => pb.PlayerId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(pb => pb.Building)
            .WithMany()
            .HasForeignKey(pb => pb.BuildingId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasData(new PlayerBuilding
        {
            Id = Guid.Parse("3CD60ECA-D0CE-4F25-8501-938B1E07ECBB"),

            PlayerId = PlayerConfiguration.JohnDoeId,
            BuildingId = BuildingConfiguration.HeadquartersTemplateId,

            Level = 2,
            Quantity = 1
        });
    }
}