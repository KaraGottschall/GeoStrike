#region

using GeoStrike.Domain.Repositories.Building;
using GeoStrike.Domain.Repositories.Player;
using GeoStrike.Infrastructure.DataAccess.Repository.Building;
using Microsoft.Extensions.DependencyInjection;

#endregion

namespace GeoStrike.Infrastructure;

public static class DependecyInjectionExtension
{
    extension(IServiceCollection serviceCollection)
    {
        public void AddInfrastructure()
        {
            serviceCollection.AddScoped<IReadOnlyBuildingRepository, BuildingRepository>();
            serviceCollection.AddScoped<IReadOnlyPlayerRepository, PlayerRepository>();
        }
    }
}