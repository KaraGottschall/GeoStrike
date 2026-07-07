#region

using GeoStrike.Application.UseCases.Building;
using GeoStrike.Application.UseCases.Building.Evolve;
using Microsoft.Extensions.DependencyInjection;

#endregion

namespace GeoStrike.Application;

public static class DependecyInjectionExtension
{
    extension(IServiceCollection serviceCollection)
    {
        public void AddApplication()
        {
            serviceCollection.AddScoped<IStartEvolvingBuildingUseCase, StartEvolvingBuildingUseCase>();
        }
    }
}