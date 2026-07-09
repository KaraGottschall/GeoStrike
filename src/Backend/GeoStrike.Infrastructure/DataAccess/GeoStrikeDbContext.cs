// Solução: GeoStrike | Projeto: GeoStrike.Infrastructure
// Licenciado sob a Licença MIT. Veja o arquivo LICENSE na raiz para mais detalhes.
// Criado em: 07/07/2026 por Kara Gottschall

namespace GeoStrike.Infrastructure.DataAccess;

public class GeoStrikeDbContext(DbContextOptions dbContextOptions) : DbContext(dbContextOptions)
{
    public DbSet<Building> Buildings { get; set; }
    public DbSet<PlayerEntity> Players { get; set; }
    public DbSet<PlayerBuildingEntity> PlayerBuildings { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(GeoStrikeDbContext).Assembly);
    }
}