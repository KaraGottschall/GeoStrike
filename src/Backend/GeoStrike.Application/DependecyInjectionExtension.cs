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