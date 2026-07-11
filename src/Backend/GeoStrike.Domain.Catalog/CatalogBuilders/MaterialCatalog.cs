// Solução: GeoStrike | Projeto: GeoStrike.Domain.Catalog
// Licenciado sob a Licença MIT. Veja o arquivo LICENSE na raiz para mais detalhes.
// Criado em: 11/07/2026 por Kara Gottschall

namespace GeoStrike.Domain.Catalog;

public static class MaterialCatalog
{
    private static readonly Dictionary<MaterialType, MaterialDefinition> Definitions;

    static MaterialCatalog()
    {
        Assembly assembly = Assembly.GetExecutingAssembly();
        const string resourceName = "GeoStrike.Domain.Catalog.StaticData.materials.json";

        using Stream stream = assembly.GetManifestResourceStream(resourceName)
                              ?? throw new FileNotFoundException(
                                  $"Recurso embutido '{resourceName}' não foi encontrado.");

        using StreamReader reader = new(stream);
        string json = reader.ReadToEnd();

        MaterialCatalogRoot? root =
            JsonSerializer.Deserialize(json, MaterialCatalogJsonContext.Default.MaterialCatalogRoot);

        if (root?.Materials == null)
            throw new InvalidOperationException("Falha ao carregar o catálogo de edifícios do arquivo JSON.");

        Definitions = root.Materials.ToDictionary(j => j.Type);
    }

    public static MaterialDefinition Get(MaterialType type) =>
        Definitions.TryGetValue(type, out MaterialDefinition? definition)
            ? definition
            : throw new KeyNotFoundException($"O material do tipo '{type}' não foi mapeado no catálogo.");
}

[JsonSerializable(typeof(MaterialCatalogRoot))]
[JsonSourceGenerationOptions(
    PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase,
    Converters = [typeof(JsonStringEnumConverter<MaterialType>)]
)]
internal partial class MaterialCatalogJsonContext : JsonSerializerContext;

internal class MaterialCatalogRoot
{
    public List<MaterialDefinition> Materials { get; set; } = [];
}