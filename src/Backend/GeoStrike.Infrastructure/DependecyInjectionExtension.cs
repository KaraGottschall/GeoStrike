#region

using GeoStrike.Domain.Repositories.Building;
using GeoStrike.Domain.Repositories.Player;
using GeoStrike.Domain.Repositories.PlayerBuilding;
using GeoStrike.Infrastructure.DataAccess.Repositories.Building;
using GeoStrike.Infrastructure.DataAccess.Repositories.Player;
using GeoStrike.Infrastructure.DataAccess.Repositories.PlayerBuilding;
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
            serviceCollection.AddScoped<IWriteOnlyPlayerBuildingRepository, PlayerBuildingRepository>();
        }
    }
}