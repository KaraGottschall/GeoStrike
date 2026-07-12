// Solução: GeoStrike | Projeto: GeoStrike.Infrastructure
// Licenciado sob a Licença MIT. Veja o arquivo LICENSE na raiz para mais detalhes.
// Criado em: 07/07/2026 por Kara Gottschall

using GeoStrike.Domain.Repositories.Catalog.BuildingCatalogRepository;
using GeoStrike.Infrastructure.DataAccess.Repositories.Catalog.BuildingCatalogRepository;

namespace GeoStrike.Infrastructure;

public static class DependecyInjectionExtension
{
    extension(IServiceCollection serviceCollection)
    {
        public void AddInfrastructure()
        {
            // Catalogs
            serviceCollection.AddScoped<IReadOnlyBuildingCatalogRepository, BuildingCatalogRepository>();

            serviceCollection.AddScoped<IReadOnlyBuildingRepository, BuildingRepository>();
            serviceCollection.AddScoped<IReadOnlyPlayerRepository, PlayerRepository>();
            serviceCollection.AddScoped<IWriteOnlyPlayerBuildingRepository, PlayerBuildingRepository>();
        }
    }
}