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