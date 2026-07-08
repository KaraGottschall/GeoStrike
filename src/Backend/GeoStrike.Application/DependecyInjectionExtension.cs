#region

using GeoStrike.Application.UseCases.PlayerBuilding;
using GeoStrike.Application.UseCases.PlayerBuilding.Evolve;
using Microsoft.Extensions.DependencyInjection;

#endregion

namespace GeoStrike.Application;

public static class DependecyInjectionExtension
{
    extension(IServiceCollection serviceCollection)
    {
        public void AddApplication()
        {
            serviceCollection.AddScoped<IStartEvolvingPlayerBuildingUseCase, StartEvolvingPlayerBuildingUseCase>();
        }
    }
}