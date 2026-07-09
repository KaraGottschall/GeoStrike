// Solução: GeoStrike | Projeto: GeoStrike.Infrastructure
// Licenciado sob a Licença MIT. Veja o arquivo LICENSE na raiz para mais detalhes.
// Criado em: 08/07/2026 por Kara Gottschall

namespace GeoStrike.Infrastructure.DataAccess.EntitiesConfiguration;

public class PlayerBuildingConfiguration : IEntityTypeConfiguration<PlayerBuildingEntity>
{
    public void Configure(EntityTypeBuilder<PlayerBuildingEntity> builder)
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

        builder.HasData(
            new PlayerBuildingEntity
            {
                Id = Guid.Parse("3CD60ECA-D0CE-4F25-8501-938B1E07ECBB"),

                PlayerId = PlayerConfiguration.JohnDoeId,
                BuildingId = BuildingConfiguration.HeadquartersTemplateId,

                Level = 2,
                Quantity = 1
            },
            new PlayerBuildingEntity
            {
                Id = Guid.Parse("4A99048B-403E-417B-8EFA-943322E46816"),

                PlayerId = PlayerConfiguration.JohnDoeId,
                BuildingId = BuildingConfiguration.OilrefinaryTemplateId,

                Level = 1,
                Quantity = 1
            }
        );
    }
}