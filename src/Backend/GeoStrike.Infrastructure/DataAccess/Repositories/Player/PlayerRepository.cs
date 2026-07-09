// Solução: GeoStrike | Projeto: GeoStrike.Infrastructure
// Licenciado sob a Licença MIT. Veja o arquivo LICENSE na raiz para mais detalhes.
// Criado em: 07/07/2026 por Kara Gottschall

namespace GeoStrike.Infrastructure.DataAccess.Repositories.Player;

public class PlayerRepository(GeoStrikeDbContext dbContext) : IReadOnlyPlayerRepository
{
    public async Task<PlayerEntity?> GetByIdAsync(Guid playerId) => await dbContext.Players
        .Include(p => p.Buildings)
        .ThenInclude(pb => pb.Building)
        .FirstOrDefaultAsync(p => p.Id == playerId);

    public async Task<PlayerBuildingEntity?> GetPlayerBuildingById(Guid playerId, Guid buildingId)
    {
        PlayerBuildingEntity? playerBuilding = await dbContext.PlayerBuildings
            .FirstOrDefaultAsync(pb => pb.PlayerId == playerId && pb.BuildingId == buildingId);

        return playerBuilding;
    }
}