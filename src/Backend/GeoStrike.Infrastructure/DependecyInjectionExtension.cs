// Solução: GeoStrike | Projeto: GeoStrike.Infrastructure
// Licenciado sob a Licença MIT. Veja o arquivo LICENSE na raiz para mais detalhes.
// Criado em: 07/07/2026 por Kara Gottschall

namespace GeoStrike.Infrastructure;

public static class DependecyInjectionExtension
{
    extension(IServiceCollection serviceCollection)
    {
        public void AddInfrastructure()
        {
            serviceCollection.AddScoped<IReadOnlyBuildingRepository, BuildingRepository>();
            serviceCollection.AddScoped<IReadOnlyPlayerRepository, PlayerRepository>();
            serviceCollection.AddScoped<IWriteOnlyPlayerBuildingRepository, PlayerBuildingRepository>();
        }
    }
}