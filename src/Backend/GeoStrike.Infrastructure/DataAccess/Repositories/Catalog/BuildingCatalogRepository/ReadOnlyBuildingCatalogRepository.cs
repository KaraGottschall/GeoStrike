// Solução: GeoStrike | Projeto: GeoStrike.Infrastructure
// Licenciado sob a Licença MIT. Veja o arquivo LICENSE na raiz para mais detalhes.
// Criado em: 11/07/2026 por Kara Gottschall

using GeoStrike.Domain.Models;
using GeoStrike.Domain.Repositories.Catalog.BuildingCatalogRepository;
using Microsoft.Azure.Cosmos;
using static System.Net.HttpStatusCode;

namespace GeoStrike.Infrastructure.DataAccess.Repositories.Catalog.BuildingCatalogRepository;

public class BuildingCatalogRepository(CosmosClient cosmosClient) : IReadOnlyBuildingCatalogRepository
{
    private readonly Container _container = cosmosClient.GetContainer("GeoStrikeCatalog", "Buildings");

    public async Task<BuildingDefinition?> GetByTypeAsync(BuildingType buildingType)
    {
        try
        {
            string buildingKey = buildingType.ToString();

            ItemResponse<BuildingDefinition> response =
                await _container.ReadItemAsync<BuildingDefinition>(buildingKey, new(buildingKey));

            return response.Resource;
        }
        catch (CosmosException ex) when (ex.StatusCode == NotFound)
        {
            return null;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}