// Solução: GeoStrike | Projeto: GeoStrike.Application
// Licenciado sob a Licença MIT. Veja o arquivo LICENSE na raiz para mais detalhes.
// Criado em: 07/07/2026 por Kara Gottschall

namespace GeoStrike.Application;

public static class DependecyInjectionExtension
{
    extension(IServiceCollection serviceCollection)
    {
        public void AddApplication()
        {
            serviceCollection.AddScoped<IStartEvolvingPlayerBuildingUseCase, StartEvolvingPlayerBuildingUseCase>();
            serviceCollection.AddScoped<IGetPlayerByIdUseCase, GetPlayerByIdUseCase>();
        }
    }
}