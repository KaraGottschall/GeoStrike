// Solução: GeoStrike | Projeto: GeoStrike.Domain.Catalog
// Licenciado sob a Licença MIT. Veja o arquivo LICENSE na raiz para mais detalhes.
// Criado em: 09/07/2026 por Kara Gottschall

namespace GeoStrike.Domain.Catalog;

public static class BuildingCatalog
{
    private static readonly Dictionary<BuildingType, BuildingDefinition> Definitions;

    static BuildingCatalog()
    {
        Assembly assembly = Assembly.GetExecutingAssembly();
        const string resourceName = "GeoStrike.Domain.Catalog.StaticData.buildings.json";

        using Stream stream = assembly.GetManifestResourceStream(resourceName)
                              ?? throw new FileNotFoundException(
                                  $"Recurso embutido '{resourceName}' não foi encontrado.");

        using StreamReader reader = new(stream);
        string json = reader.ReadToEnd();

        CatalogRoot? root = JsonSerializer.Deserialize(json, CatalogJsonContext.Default.CatalogRoot);

        if (root?.Buildings == null)
            throw new InvalidOperationException("Falha ao carregar o catálogo de edifícios do arquivo JSON.");

        Definitions = root.Buildings.ToDictionary(b => b.Type);
    }

    public static BuildingDefinition Get(BuildingType type) =>
        Definitions.TryGetValue(type, out BuildingDefinition? definition)
            ? definition
            : throw new KeyNotFoundException($"O edifício do tipo '{type}' não foi mapeado no catálogo.");
}

[JsonSerializable(typeof(CatalogRoot))]
[JsonSourceGenerationOptions(
    PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase,
    Converters =
    [
        typeof(JsonStringEnumConverter<BuildingType>),
        typeof(JsonStringEnumConverter<ResourceType>),
        typeof(JsonStringEnumConverter<JobRoleType>)
    ]
)]
internal partial class CatalogJsonContext : JsonSerializerContext;

internal class CatalogRoot
{
    public List<BuildingDefinition> Buildings { get; set; } = [];
}