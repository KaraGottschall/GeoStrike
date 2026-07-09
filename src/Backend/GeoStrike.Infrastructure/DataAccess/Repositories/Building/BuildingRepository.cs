// Solução: GeoStrike | Projeto: GeoStrike.Infrastructure
// Licenciado sob a Licença MIT. Veja o arquivo LICENSE na raiz para mais detalhes.
// Criado em: 08/07/2026 por Kara Gottschall

namespace GeoStrike.Infrastructure.DataAccess.Repositories.Building;

public class BuildingRepository(GeoStrikeDbContext dbContext) : IReadOnlyBuildingRepository
{
    public async Task<BuildingType> GetBuildingTypeById(Guid buildingId)
    {
        BuildingType? buildingType = await dbContext.Buildings
            .Where(b => b.Id == buildingId)
            .Select(b => b.Type)
            .FirstOrDefaultAsync();

        return buildingType.Value;
    }
}